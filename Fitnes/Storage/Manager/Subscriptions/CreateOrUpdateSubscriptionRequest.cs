using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Subscriptions {
    public class CreateOrUpdateSubscriptionRequest {
        public string Name { get; set; }
        public ushort Price { get; set; }
        public int Time { get; set; }
    }
}
