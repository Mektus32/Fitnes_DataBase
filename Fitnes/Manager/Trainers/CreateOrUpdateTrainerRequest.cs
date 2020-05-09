using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Trainers {
    public class CreateOrUpdateTrainerRequest {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ushort Experience { get; set; }
        public Guid ProgramWorkout { get; set; }
        public Guid GymId { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
