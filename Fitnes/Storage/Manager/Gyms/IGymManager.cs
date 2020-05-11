using Fitnes.Storage.Manager.Gyms;
using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Gyms {
    public interface IGymManager {
        public Task<IReadOnlyCollection<GymWithTrainingMachines>> GetAll();
        public Task<List<KeyValuePair<bool, string>>> CreateListWithTrainingMachines(int? id);
        public Task<Gym> GetGymById(int id);
        public Task AddGym(CreateOrUpdateGymRequest request);
        public Task UpdateGym(int id, CreateOrUpdateGymRequest request);
        public Task DeleteGym(int id);
    }
}
