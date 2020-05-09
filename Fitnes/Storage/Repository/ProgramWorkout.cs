using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("ProgramWorkout")]
    public class ProgramWorkout {
        private readonly FitnesDbContext fitnesDbContext;
        public ProgramWorkout(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public Guid? AuthorId { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }

        [Required]
        public DateTime Period { get; set; }
    }
}
