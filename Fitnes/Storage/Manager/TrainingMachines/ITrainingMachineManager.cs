using Fitnes.Storage.Manager.TrainingMachines;
using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.TrainingMachines {
    public interface ITrainingMachineManager {
        public Task<IReadOnlyCollection<TrainingMachine>> GetAll();
        public Task<TrainingMachine> GetTrainingMachineById(int id);
        public Task AddTrainingMachine(CreateOrUpdateTrainingMachineRequest request);
        public Task UpdateTrainingMachine(int id, CreateOrUpdateTrainingMachineRequest request);
        public Task DeleteTrainingMachine(int id);
    }
}
