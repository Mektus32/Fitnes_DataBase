using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("TrainingMachine")]
    public class TrainingMachine{
        private readonly FitnesDbContext fitnesDbContext;
        public TrainingMachine(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
        [Key]
        [Required]
        [Column("TrainingMachineId")]
        public Guid TrainingMachineId { get; set; }
        public string Name { get; set; }

        [Required]
        [Column("IsForHand")]
        public bool IsForHand { get; set; }

        [Required]
        [Column("IsForLeg")]
        public bool IsForLeg { get; set; }

        [Required]
        [Column("IsForBack")]
        public bool IsForBack { get; set; }

        public List<GymTrainingMachine> GymTrainingMachines { get; set; }
    }
}
