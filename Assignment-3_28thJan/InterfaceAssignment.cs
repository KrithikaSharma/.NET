using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_28thJan
{
    /*
    3.Create an Interface IStudent with StudentId and Name as Properties, ShowDetails() as its method.
    Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods. Test The functionalities.
    */
    interface IStudent
    {
        int sid { get; set; }
        string name { get; set; }

        void ShowDetails();
    }
    class DayScholar : IStudent
    {
        private int daySid;
        string dayname;
        public int sid
        {
            get { return daySid; }
            set { daySid = value; }
        }
        public string name
        {
            get { return dayname; }
            set { dayname = value; }
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Day-Scholar student id is: {daySid} and name is: {dayname}");
        }
    }
    class Resident : IStudent
    {
        private int rSid;
        string rname;
        public int sid
        {
            get { return rSid; }
            set { rSid = value; }
        }
        public string name
        {
            get { return rname; }
            set { rname = value; }
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Residential(Hostel) student id is: {rSid} and name is: {rname}");
        }
    }
    class InterfaceAssignment
    {
        static void Main()
        {
            IStudent ids = new DayScholar();
            ids.sid = 501;
            ids.name = "Krithika";
            ids.ShowDetails();

            IStudent ir = new Resident();
            ir.sid = 290;
            ir.name = "Sharma";
            ir.ShowDetails();

            Console.ReadKey();
        }
    }
}
// output
/*
Day-Scholar student id is: 501 and name is: Krithika
Residential(Hostel) student id is: 290 and name is: Sharma
*/
