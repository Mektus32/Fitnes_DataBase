using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Clients {
    public class CreateOrUpdateClientRequest {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int? TrainerId { get; set; }
        public int? SubscriptionId { get; set; }
    }
}
