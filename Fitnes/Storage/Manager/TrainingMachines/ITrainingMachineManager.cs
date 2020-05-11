using Fitnes.Storage.Manager.TrainingMachines;
using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.TrainingMachines {
    public interface ITrainingMachineManager {
        public Task<IReadOnlyCollection<TrainingMachineWithGym>> GetAll();
        public Task<List<KeyValuePair<bool, string>>> CreateListWithGym(int? id);
        public Task<TrainingMachine> GetTrainingMachineById(int id);
        public void AddTrainingMachine(CreateOrUpdateTrainingMachineRequest request);
        public void UpdateTrainingMachine(int id, CreateOrUpdateTrainingMachineRequest request);
        public void DeleteTrainingMachine(int id);
    }
}
