using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("ProgramWorkout")]
    public class ProgramWorkout {
        [Key]
        [Required]
        public int ProgramWorkoutId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int AuthorId { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }

        [Required]
        public double Period { get; set; }
    }
}
