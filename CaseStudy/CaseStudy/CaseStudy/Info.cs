using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Info
    {
        public static void Display(Student student)
        {
            Console.WriteLine($"id: {student.id}, name: {student.name}, date of birth: {(student._dateofbirth).ToLongDateString()}");
        }

        public static void Display(Course course)
        {
            Console.WriteLine($"course id: {course.cid}, course name: {course.cname}, course duration: {course.duration}, course fees: {course.fees}/- rs");
        }

        public static void Display(Enroll enroll)
        {

        }
    }
}
