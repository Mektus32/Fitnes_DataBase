using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Subscription")]
    public class Subscription {
        private readonly FitnesDbContext fitnesDbContext;
        public Subscription(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ushort Price { get; set; }

        public Guid? ProgramWorkoutId { get; set; }
        [ForeignKey(nameof(ProgramWorkoutId))]
        public ProgramWorkout ProgramWorkout { get; set; }
    }
}
