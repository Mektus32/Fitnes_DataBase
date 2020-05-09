using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Employee")]
    public class Employee {
        private readonly FitnesDbContext fitnesDbContext;
        public Employee(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
        [Key]
        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public Guid? PositionId { get; set; }
        [ForeignKey(nameof(PositionId))]
        public Position Position { get; set; }

        [Required]
        public double Experience { get; set; }

        [Required]
        public ushort Salary { get; set; }

        public Guid? GymId { get; set; }
        [ForeignKey(nameof(GymId))]
        public Gym Gym { get; set; }
    }
}
