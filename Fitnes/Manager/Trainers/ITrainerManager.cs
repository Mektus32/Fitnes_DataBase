using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Trainers {
    interface ITrainerManager {
        Task<Trainer> AddSubscription(CreateOrUpdateTrainerRequest request);
        Task<IReadOnlyCollection<Trainer>> GetAll();
        Task<Trainer> UpdateSubscription(Guid id, CreateOrUpdateTrainerRequest request);
        Task<Trainer> GetById(Guid id);
    }
}
