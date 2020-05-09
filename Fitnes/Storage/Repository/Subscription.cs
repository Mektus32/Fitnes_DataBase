using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Subscription")]
    public class Subscription : IUniqueIdentifyEntity {
        private readonly FitnesDbContext fitnesDbContext;
        public Subscription(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        [Required]
        [Column("Price")]
        public ushort Price { get; set; }

        [Required]
        [Column("ProgramWorkoutId")]
        public Guid? ProgramWorkoutId { get; set; }
        [ForeignKey(nameof(ProgramWorkoutId))]
        public ProgramWorkout ProgramWorkout { get; set; }
    }
}
