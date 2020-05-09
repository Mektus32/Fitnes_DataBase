using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Gyms {
    public class CreateOrUpdateGymRequest {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid TrainingMachine { get; set; }
    }
}
