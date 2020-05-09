using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Gyms {
    interface IGymManager {
        Task<Gym> AddEmployee(CreateOrUpdateGymRequest request);

        Task<IReadOnlyCollection<Gym>> GetAll();
        Task<Gym> UpdateGym(Guid id, CreateOrUpdateGymRequest request);
        Task<Gym> GetById(Guid id);
    }
}
