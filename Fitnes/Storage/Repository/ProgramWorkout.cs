using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("ProgramWorkout")]
    public class ProgramWorkout : IUniqueIdentifyEntity {
        private readonly FitnesDbContext fitnesDbContext;
        public ProgramWorkout(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        [Required]
        [Column("AuthorId")]
        public Guid AuthorId { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }

        [Required]
        [Column("Period")]
        public DataType Period { get; set; }
    }
}
