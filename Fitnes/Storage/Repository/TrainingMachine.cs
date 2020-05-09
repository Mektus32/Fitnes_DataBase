﻿using System;
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
        public Guid TrainingMachineId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public bool IsForHand { get; set; }

        [Required]
        public bool IsForLeg { get; set; }

        [Required]
        public bool IsForBack { get; set; }

        public List<GymTrainingMachine> GymTrainingMachines { get; set; }
    }
}