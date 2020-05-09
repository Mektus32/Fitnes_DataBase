using Fitnes.Manager.Subscriptions;
using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.TrainingMachines {
    interface ITrainingMachineManager {
        Task<TrainingMachine> AddSubscription(CreateOrUpdateTrainingMachineRequest request);
        Task<IReadOnlyCollection<TrainingMachine>> GetAll();
        Task<TrainingMachine> UpdateSubscription(Guid id, CreateOrUpdateTrainingMachineRequest request);
        Task<TrainingMachine> GetById(Guid id);
    }
}
