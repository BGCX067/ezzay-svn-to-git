using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ezzay.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int TutorID { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}