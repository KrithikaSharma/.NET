using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_28thJan
{
    /*
    1. Create a console application to book train tickets. Create a Passanger class with (Name, Age)
    and write a function called TicketBooking(no_of_tickets) that takes no.of tickets to be booked.
    If the no of tickets is > 5 per booking, raise an user defined exception, and print "cannot book more than 2 tickets".
    Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking method by accepting all required details.
    */
    class BookingTicketsException:ApplicationException
    {
        public BookingTicketsException(string msg):base(msg)
        {

        }
    }
    class Passenger
    {
        string Name;
        int age;
        public void TicketBooking(int no_of_tickets)
        {
            
            if(no_of_tickets>5)
            {
                throw (new BookingTicketsException("A person can only book atmost 5 tickets!!"));
            }
            else
            {
                Console.Write("Enter your Name: ");
                Name = Console.ReadLine();
                Console.Write("Enter age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wishing you a happy and safe journey!!");
            }

        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int tickets;
            Passenger p = new Passenger();
            try
            {
                Console.Write("enter no of tickets u want to book: ");
                tickets = int.Parse(Console.ReadLine());
                p.TicketBooking(tickets);
            }
            catch(BookingTicketsException bte)
            {
                Console.WriteLine("Booking tickets Exception Message: "+bte.Message);
            }
            Console.Read();
        }
    }
}
/*
enter no of tickets u want to book: 4
Enter your Name: Krithika
Enter age: 21
Wishing you a happy and safe journey!!

enter no of tickets u want to book: 6
Booking tickets Exception Message: A person can only book atmost 5 tickets!!

enter no of tickets u want to book: 5
Enter your Name: Sharma
Enter age: 19
Wishing you a happy and safe journey!!
*/
