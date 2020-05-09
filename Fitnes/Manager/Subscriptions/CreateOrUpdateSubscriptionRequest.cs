using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Subscriptions {
    public class CreateOrUpdateSubscriptionRequest {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ushort Price { get; set; }
        public Guid ProgramWorkoutId { get; set; }
    }
}
