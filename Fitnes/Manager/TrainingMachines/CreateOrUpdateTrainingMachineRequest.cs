using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.TrainingMachines {
    public class CreateOrUpdateTrainingMachineRequest {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsForHand { get; set; }
        public bool IsForLeg { get; set; }
        public bool IsForBack { get; set; }
    }
}
