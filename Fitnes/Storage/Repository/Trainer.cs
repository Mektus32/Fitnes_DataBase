using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Trainer")]
    public class Trainer {
        private readonly FitnesDbContext fitnesDbContext;
        public Trainer(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
        [Required]
        [Key]
        public Guid TrainerId { get; set; }

        public Guid? ProgramWorkoutId { get; set; }
        [ForeignKey(nameof(ProgramWorkoutId))]
        public ProgramWorkout ProgramWorkout {get; set; }

        public Guid? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
    }
}
