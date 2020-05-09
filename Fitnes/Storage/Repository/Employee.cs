using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Employee")]
    public class Employee : IUniqueIdentifyEntity {
        private readonly FitnesDbContext fitnesDbContext;
        public Employee(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        [Required]
        [Column("PositionId")]
        public Guid PositionId { get; set; }
        [ForeignKey(nameof(PositionId))]
        public Position Position { get; set; }

        [Required]
        [Column("Experience")]
        public double Experience { get; set; }

        [Required]
        [Column("Salary")]
        public ushort Salary { get; set; }

        [Required]
        [Column("GymId")]
        public Guid GymId { get; set; }
        [ForeignKey(nameof(GymId))]
        public Gym Gym { get; set; }
    }
}
