using Fitnes.Storage;
using Fitnes.Storage.Manager.Clients;
using Fitnes.Storage.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Clients {
    public class ClientManager : IClientManager {
        private readonly FitnesDbContext context;
        public ClientManager(FitnesDbContext fitnesDbContext) {
            context = fitnesDbContext;
        }

        public async Task AddClient(CreateOrUpdateClientRequest request) {
            var client = new Client {
                Name = request.Name,
                LastName = request.LastName,
                TrainerId = request.TrainerId != 0 ? request.TrainerId : null,
                SubscriptionId = request.SubscriptionId != 0 ? request.SubscriptionId : null
            };
            await context.Clients.AddAsync(client);
            await context.SaveChangesAsync();
        }

        public async Task DeleteClient(int id) {
            context.Clients.Remove(context.Clients.Find(id));
            await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<ClientWithTrainerAndSubscriptionsName>> GetAll() {
            var tmp = await context.Clients.Include(c => c).ToListAsync();
            List<ClientWithTrainerAndSubscriptionsName> listWithNames = new List<ClientWithTrainerAndSubscriptionsName>();
            
            foreach (var elem in tmp) {
                listWithNames.Add(new ClientWithTrainerAndSubscriptionsName() {
                    Id = elem.ClientId,
                    Name = elem.Name,
                    LastName = elem.LastName,
                    TrainerName = elem.TrainerId != null ? context.Employees.Find(context.Trainers.Find(elem.TrainerId).EmployeeId).Name : null,
                    SubscriptionName = elem.SubscriptionId != null ? context.Subscriptions.Find(elem.SubscriptionId).Name : null });
            }
            return listWithNames;
        }

        public async Task<Client> GetClientById(int id) {
            var entity = await context.Clients.FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            return entity;
        }
        public async Task UpdateClient(int id, CreateOrUpdateClientRequest request) {
            var client = context.Clients.Find(id);
            client.Name = request.Name;
            client.LastName = request.LastName;
            client.TrainerId = request.TrainerId != 0 ? request.TrainerId : null;
            client.SubscriptionId = request.SubscriptionId != 0 ? request.SubscriptionId : null;
            await context.SaveChangesAsync();
        }
        public async Task<(List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>)> CreateListForViewCreateClient() {
            List<KeyValuePair<int, string>> listTrainers = new List<KeyValuePair<int, string>>();
            List<KeyValuePair<int, string>> listSubscriptions = new List<KeyValuePair<int, string>>();
            await context.Trainers.ForEachAsync(elem => listTrainers.Add(new KeyValuePair<int, string>(elem.TrainerId,
             context.Employees.Find(elem.EmployeeId).Name)));
            await context.Subscriptions.ForEachAsync(elem => listSubscriptions.Add(new KeyValuePair<int, string>(elem.SubscriptionId, elem.Name)));
            return (listTrainers, listSubscriptions);
        }
    }
}
