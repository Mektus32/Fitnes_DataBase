using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Gym")]
    public class Gym {
        private readonly FitnesDbContext fitnesDbContext;
        public Gym(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
        [Key]
        [Required]
        [Column("GymId")]
        public Guid GymId { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("Adress")]
        public string Address { get; set; }

        public List<GymTrainingMachine> GymTrainingMachines { get; set; }
    }
}
