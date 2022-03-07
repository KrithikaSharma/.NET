using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Course
    {
        public int cid;
        public string cname;
        public int duration;
        public int fees;

        public Course(int id, string cn, int dur, int fee)
        {
            cid = id;
            cname = cn;
            duration = dur;
            fees = fee;
        }
    }
}
