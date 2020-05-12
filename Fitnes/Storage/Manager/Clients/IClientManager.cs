using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage.Manager.Clients;
using Fitnes.Storage.Repository;

namespace Fitnes.Storage.Manager.Clients {
    public interface IClientManager {
        public Task<IReadOnlyCollection<ClientWithTrainerAndSubscriptionsName>> GetAll();
        public Task<Client> GetClientById(int id);
        public Task<(List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>)> CreateListForViewCreateClient();
        public Task AddClient(CreateOrUpdateClientRequest request);
        public Task UpdateClient(int id, CreateOrUpdateClientRequest request);
        public Task DeleteClient(int id);
        public List<ClientWithTrainerAndSubscriptionsName> SearchClient(string text, int term);
    }
}
