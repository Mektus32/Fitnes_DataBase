using Fitnes.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Clients {
    public class ClientManager {
        private readonly FitnesDbContext fitnesDbContext;
        public ClientManager(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
    }
}
