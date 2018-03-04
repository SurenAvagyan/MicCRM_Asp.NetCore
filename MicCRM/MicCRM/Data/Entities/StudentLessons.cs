using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCRM.Data.Entities
{
    public class StudentLessons
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
