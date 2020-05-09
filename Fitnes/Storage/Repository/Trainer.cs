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
        [Column("Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("ProgramWorkoutId")]
        public Guid ProgramWorkoutId { get; set; }
        [ForeignKey(nameof(ProgramWorkoutId))]
        public ProgramWorkout ProgramWorkout {get; set; }

        [Required]
        [Column("EmployeeId")]
        public Guid EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
    }
}
