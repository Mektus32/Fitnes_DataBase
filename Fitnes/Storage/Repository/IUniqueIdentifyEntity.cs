using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    interface IUniqueIdentifyEntity {
        [Key]
        [Required]
        [Column("Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
