using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage.Repository;

namespace Fitnes.Manager.Clients {
    interface IClientManager {
        Task<Client> AddClient(CreateOrUpdateClientRequest request);

        Task<IReadOnlyCollection<Client>> GetAll();

        Task<Client> UpdateClient(Guid id, CreateOrUpdateClientRequest request);

        Task<Client> GetById(Guid id);
    }
}
