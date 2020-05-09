using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.GymTrainingMachines {
    public class GymTrainingMachineManager {
        private readonly FitnesDbContext fitnesDbContext;
        public GymTrainingMachineManager(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
    }
}
