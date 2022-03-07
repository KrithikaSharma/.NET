using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Student
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name; // setting condition that name cannot be null or have whitespace
        public string name
        {
            get { return _name; }
            set
            {
                if (_name != "" || _name != " ")
                {
                    _name = value;
                }
            }
        }

        public DateTime _dateofbirth { get; set; }

        public Student(int i, string n, DateTime dob)
        {

            _id = i;
            _name = n;
            _dateofbirth = dob;
        }
    }
}
