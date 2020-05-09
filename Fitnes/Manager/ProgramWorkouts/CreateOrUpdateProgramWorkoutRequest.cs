using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.ProgramWorkouts {
    public class CreateOrUpdateProgramWorkoutRequest {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DataType Period { get; set; }
    }
}
