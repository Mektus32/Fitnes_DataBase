using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Employers {
    public class CreateOrUpdateEmployeeRequest {
        public string Name { get; set; }
        public int PositionId { get; set; }
        public double Experience { get; set; }
        public ushort Salary { get; set; }
        public int GymId { get; set; }
    }
}
