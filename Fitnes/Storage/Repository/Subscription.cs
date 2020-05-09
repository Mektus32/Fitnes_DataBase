using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Subscription")]
    public class Subscription {
        [Key]
        [Required]
        public Guid SubscriptionId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ushort Price { get; set; }

        [Required]
        public DateTime Time { get; set; }
    }
}
