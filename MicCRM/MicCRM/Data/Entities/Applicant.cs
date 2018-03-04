using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MicCRM.Data.Entities
{
    public class Applicant : EntityBase
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public bool IsStudent { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Description { get; set; }
        
        public virtual Lesson Lesson { get; set; }
    }
}
