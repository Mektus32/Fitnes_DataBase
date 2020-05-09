using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Position")]
    public class Position {
        private readonly FitnesDbContext fitnesDbContext;
        public Position(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }

        [Key]
        [Required]
        public Guid PositionId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
