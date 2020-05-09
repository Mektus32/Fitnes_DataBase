using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Clients {
    public class CreateOrUpdateClientRequest {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Guid TrainerId { get; set; }
        public Guid GymId { get; set; }
        public Guid ProgramWorkoutId { get; set; }
        public Guid Subscription { get; set; }
    }
}
