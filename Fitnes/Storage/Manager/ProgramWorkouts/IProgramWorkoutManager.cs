using Fitnes.Storage.Manager.ProgramWorkouts;
using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.ProgramWorkouts {
    public interface IProgramWorkoutManager {
        public Task<IReadOnlyCollection<ProgramWorkoutWithAuthorName>> GetAll();
        public Task<ProgramWorkout> GetProgramWorkoutById(int id);
        public Task<List<KeyValuePair<int, string>>> CreateListForViewCreateProgramWorkout();
        public Task AddProgramWorkout(CreateOrUpdateProgramWorkoutRequest request);
        public Task UpdateProgramWorkout(int id, CreateOrUpdateProgramWorkoutRequest request);
        public Task DeleteProgramWorkout(int id);
    }
}
