using Fitnes.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.ProgramWorkouts {
    public class ProgramWorkoutManager {
        private readonly FitnesDbContext fitnesDbContext;
        public ProgramWorkoutManager(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
    }
}
