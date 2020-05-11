using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.ProgramWorkouts {
    public class ProgramWorkoutWithAuthorName {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Period { get; set; }
    }
}
