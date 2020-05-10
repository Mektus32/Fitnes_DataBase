using Fitnes.Storage;
using Fitnes.Storage.Manager.Clients;
using Fitnes.Storage.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Clients {
    public class ClientManager : IClientManager {
        private readonly FitnesDbContext context;
        public ClientManager(FitnesDbContext fitnesDbContext) {
            context = fitnesDbContext;
        }

        public async void AddClient(CreateOrUpdateClientRequest request) {
            var client = new Client {
                ClientId = context.Clients.LastOrDefault().ClientId++,
                Name = request.Name,
                TrainerId = request.TrainerId,
                SubscriptionId = request.SubscriptionId
            };
            await context.Clients.AddAsync(client);
            await context.SaveChangesAsync();
        }

        public void DeleteClient(int id) {
            context.Clients.Remove(context.Clients.Find(id));
            context.SaveChanges();
        }

        public async Task<IReadOnlyCollection<ClientWithTrainerAndSubscriptionsName>> GetAll() {
            var tmp = await context.Clients.Include(c => c).ToListAsync();
            List<ClientWithTrainerAndSubscriptionsName> listWithNames = new List<ClientWithTrainerAndSubscriptionsName>();
            foreach (var elem in tmp) {
                listWithNames.Add(new ClientWithTrainerAndSubscriptionsName() { Name = elem.Name, LastName = elem.LastName,
                    TrainerName = context.Employees.Find(context.Trainers.Find(elem.TrainerId).EmployeeId).Name,
                    SubscriptionName = context.Subscriptions.Find(elem.SubscriptionId).Name });
            }
            return listWithNames;
        }

        public async Task<Client> GetClientById(int id) {
            var entity = await context.Clients.FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            return entity;
        }
        public async void UpdateClient(int id, CreateOrUpdateClientRequest request) {
            var client = await context.Clients.FindAsync(id);
            client.Name = request.Name;
            client.LastName = request.LastName;
            client.TrainerId = request.TrainerId;
            client.SubscriptionId = request.SubscriptionId;
            await context.SaveChangesAsync();
        }
        public async Task<(List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>)> CreateListForViewCreateClient() {
            List<KeyValuePair<int, string>> listTrainers = new List<KeyValuePair<int, string>>();
            List<KeyValuePair<int, string>> listSubscriptions = new List<KeyValuePair<int, string>>();
            await context.Trainers.ForEachAsync(elem => listTrainers.Add(new KeyValuePair<int, string>(elem.TrainerId,
             context.Employees.Find(elem.EmployeeId).Name)));
            await context.Subscriptions.ForEachAsync(elem => listSubscriptions.Add(new KeyValuePair<int, string>(elem.SubscriptionId,
                context.Subscriptions.Find(elem.SubscriptionId).Name)));
            return (listTrainers, listSubscriptions);
        }
    }
}
