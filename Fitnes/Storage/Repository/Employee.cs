using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Employee")]
    public class Employee {
        [Key]
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int? PositionId { get; set; }
        [ForeignKey(nameof(PositionId))]
        public Position Position { get; set; }

        [Required]
        public double Experience { get; set; }

        [Required]
        public ushort Salary { get; set; }

        public int? GymId { get; set; }
        [ForeignKey(nameof(GymId))]
        public Gym Gym { get; set; }
    }
}
