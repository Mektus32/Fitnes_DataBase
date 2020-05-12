using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Trainer")]
    public class Trainer {
        [Required]
        [Key]
        public int TrainerId { get; set; }

        public int? ProgramWorkoutId { get; set; }
        [ForeignKey(nameof(ProgramWorkoutId))]
        public ProgramWorkout ProgramWorkout {get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
    }
}
