using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicCRM.Data.Entities
{
    public class Student : EntityBase
    {
        public Student()
        {
            StudentLessons = new List<StudentLessons>();
        }

        [ForeignKey(nameof(Applicant))]
        public int ApplicantId { get; set; }
        public virtual Applicant Applicant { get; set; }

        [Required]
        public bool IsWorker { get; set; }

        public string Description { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public virtual ICollection<StudentLessons> StudentLessons { get; set; }
    }
}