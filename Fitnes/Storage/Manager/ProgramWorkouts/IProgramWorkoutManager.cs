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
        public void AddProgramWorkout(CreateOrUpdateProgramWorkoutRequest request);
        public void UpdateProgramWorkout(int id, CreateOrUpdateProgramWorkoutRequest request);
        public void DeleteProgramWorkout(int id);
    }
}
