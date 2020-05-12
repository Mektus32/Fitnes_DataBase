using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Trainers {
    public interface ITrainerManager {
        public Task<IReadOnlyCollection<TrainerWithPWAndEmployeeName>> GetAll();
        public Task<Trainer> GetTrainerById(int id);
        public Task<(List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>)> CreateListForViewCreateTrainer();
        public Task AddTrainer(CreateOrUpdateTrainerRequest request);
        public Task UpdateTrainer(int id, CreateOrUpdateTrainerRequest request);
        public Task DeleteTrainer(int id);
    }
}
