using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Gyms {
    public class GymWithTrainingMachines {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<string> MachineNames { get; set; }

        public override string ToString() {
            string str = "";
            for (int i = 0; i < MachineNames.Count; ++i) {
                if (i + 1 != MachineNames.Count)
                    str += MachineNames[i] + ',';
                else {
                    str += MachineNames[i];
                }
            }
            return str;
        }
    }
}
