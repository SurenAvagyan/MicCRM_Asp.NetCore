using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicCRM.Data.Entities
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool Deleted { get; set; }
    }
}
