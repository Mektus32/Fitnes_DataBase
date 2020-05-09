using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Client")]
    public class Client : IUniqueIdentifyEntity {
        private readonly FitnesDbContext fitnesDbContext;
        public Client(FitnesDbContext fitnesDbContext) {
            this.fitnesDbContext = fitnesDbContext;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        [Required]
        [Column("LastName")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Column("TrainerId")]
        public Guid? TrainerId { get; set; }
        [ForeignKey(nameof(TrainerId))]
        public Trainer Trainer { get; set; }

        [Required]
        [Column("Subsription")]
        public Guid SubscriptionId { get; set; }
        [ForeignKey(nameof(SubscriptionId))]
        public Subscription Subscription { get; set; }
    }
}
