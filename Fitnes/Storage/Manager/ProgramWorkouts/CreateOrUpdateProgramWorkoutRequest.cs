﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.ProgramWorkouts {
    public class CreateOrUpdateProgramWorkoutRequest {
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public double Period { get; set; }
    }
}
