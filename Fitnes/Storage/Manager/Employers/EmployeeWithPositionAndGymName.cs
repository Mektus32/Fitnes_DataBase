using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Employers {
    public class EmployeeWithPositionAndGymName { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public double Experience { get; set; }
        public ushort Salary { get; set; }
        public string GymName { get; set; }
    }
}
