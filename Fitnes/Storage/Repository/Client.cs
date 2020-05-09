using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Client")]
    public class Client {
        [Key]
        [Required]
        public int ClientId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public int? TrainerId { get; set; }
        [ForeignKey(nameof(TrainerId))]
        public Trainer Trainer { get; set; }

        public int? SubscriptionId { get; set; }
        [ForeignKey(nameof(SubscriptionId))]
        public Subscription Subscription { get; set; }
    }
}
