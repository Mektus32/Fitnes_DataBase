using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.ProgramWorkouts {
    interface IProgramWorkoutManager {
        Task<ProgramWorkout> AddEmployee(CreateOrUpdateProgramWorkoutRequest request);

        Task<IReadOnlyCollection<ProgramWorkout>> GetAll();
        Task<ProgramWorkout> UpdateEmployee(Guid id, CreateOrUpdateProgramWorkoutRequest request);
        Task<ProgramWorkout> GetById(Guid id);
    }
}
