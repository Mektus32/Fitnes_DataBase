using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("GymTrainingMachine")]
    
    public class GymTrainingMachine {
        private readonly FitnesDbContext fitnesDbContext;
        public GymTrainingMachine(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
        public Guid? GymId { get; set; }
        public Gym Gym { get; set; }

        public Guid? TrainingMachineId { get; set; }
        public TrainingMachine TrainingMachine { get; set; }
    }
}
