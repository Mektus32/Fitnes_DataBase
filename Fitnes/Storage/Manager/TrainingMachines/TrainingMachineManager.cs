using Fitnes.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.TrainingMachines {
    public class TrainingMachineManager {
        private readonly FitnesDbContext fitnesDbContext;
        public TrainingMachineManager(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
    }
}
