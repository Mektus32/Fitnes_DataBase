using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Position")]
    public class Position : IUniqueIdentifyEntity {
        private readonly FitnesDbContext fitnesDbContext;
        public Position(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
