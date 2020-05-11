using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Gyms {
    public class CreateOrUpdateGymRequest {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<string> MachinesName { get; set; }
    }
}
