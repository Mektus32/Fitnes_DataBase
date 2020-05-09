using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Repository {
    [Table("Author")]
    public class Author {
        [Key]
        [Required]
        public Guid AuthorId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
