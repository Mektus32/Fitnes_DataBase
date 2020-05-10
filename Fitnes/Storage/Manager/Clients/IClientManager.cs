using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage.Manager.Clients;
using Fitnes.Storage.Repository;

namespace Fitnes.Manager.Clients {
    public interface IClientManager {
        public Task<IReadOnlyCollection<ClientWithTrainerAndSubscriptionsName>> GetAll();
        public Task<Client> GetClientById(int id);
        public Task<(List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>)> CreateListForViewCreateClient();
        public void AddClient(CreateOrUpdateClientRequest request);
        public void UpdateClient(int id, CreateOrUpdateClientRequest request);
        public void DeleteClient(int id);
    }
}
