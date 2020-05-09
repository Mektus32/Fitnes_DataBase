using Fitnes.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Subscriptions {
    public class SubscriptionManager {
        private readonly FitnesDbContext fitnesDbContext;
        public SubscriptionManager(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
    }
}
