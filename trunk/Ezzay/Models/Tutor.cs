using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ezzay.Models
{
    public class Tutor
    {
        public int TutorID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}