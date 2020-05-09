using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Employers {
    public class CreateOrUpdateEmployeeRequest {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public ushort Experience { get; set; }
        public ushort Salary { get; set; }
        public Guid GymId { get; set; }
    }
}
