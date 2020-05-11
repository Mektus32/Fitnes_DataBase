using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Trainers {
    public class CreateOrUpdateTrainerRequest {
        public int ProgramWorkoutId { get; set; }
        public int EmployeeId { get; set; }
    }
}
