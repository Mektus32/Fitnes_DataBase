using Fitnes.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Gyms {
    public class GymManager {
        private readonly FitnesDbContext fitnesDbContext;
        public GymManager(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
    }
}
