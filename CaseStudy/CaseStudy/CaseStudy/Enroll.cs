using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Enroll
    {
        private Student student { get; set; }
        private Course course;
        private DateTime enrollmentDate;

        //constructors & getters/setters
        public Enroll(Student s, Course c, DateTime ed)
        {
            student = s;
            course = c;
            enrollmentDate = ed;
        }
    }
}
