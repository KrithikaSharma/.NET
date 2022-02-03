using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cricket; //question1 added as a reference 
using System.Collections;
using ConcessionAssignment; // question4(class library of c# .net framework added as a reference 
//using ConcessionAssignment.ConcessionClass; // why is this not working-----refer

namespace Assigment4
{
    class Products
    {
        public int productId;
        public string productName;
        public float productPrice;

        public Products(int pid,string pname,float pprice)
        {
            productId = pid;
            productName = pname;
            productPrice = pprice;
        }
    }

    class Stationery
    {
        List<string> stn = new List<string>();
        public void AddItems()
        {
            // we can take input from user
            stn.Add("Pen");
            stn.Add("Calender");
            stn.Add("Board");
            stn.Add("Duster");
            stn.Add("Stapler");
            stn.Add("Geometry Box");
        }

        public void DisplayItems()
        {
            Console.WriteLine($"---- Following {stn.Count} items are available in the stationary----");
            foreach (var item in stn)
            {
                Console.WriteLine(item);
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            // ----- question 1 soln start
            #region
            /// summary
            /// not able to add summary don't know why-----check later
            Console.Write("Enter no of matches played: ");
            int no_of_matches = Convert.ToInt32(Console.ReadLine());

            Class1.PointsCalulation(no_of_matches);
            #endregion
            // ###### question 1 soln end
            
            //----question-2 soln
            ProductAssignmentLogic();

            // ---question-3 soln
            Stationery stobj = new Stationery();
            stobj.AddItems();
            stobj.DisplayItems();
            // ###### question 3 soln end

            // ---question-4 soln
            Console.Write("Enter age for purchasing ticket: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int totalfare = 850;
            ConcessionAssignment.ConcessionClass.CalculateConcession(age, totalfare);
            // ###### question 4 soln end

            Console.Read();
        }
        public static void ProductAssignmentLogic()
        {
            List<Products> prodlist = new List<Products>();
            prodlist.Add(new Products(501, "Laptop", 76043.67f));
            prodlist.Add(new Products(506, "Desk", 150430.45f));
            prodlist.Add(new Products(532, "Router", 2000.9f));
            prodlist.Add(new Products(509, "Mouse", 270));

            /*
            // code to take product info from user
            Console.Write("Enter no of products: ");
            int no_of_products = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < no_of_products; i++)
            {
                Console.Write($"Enter product {i+1} id: ");
                int pid = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter product {i+1} name: ");
                string name= Console.ReadLine();

                Console.Write($"Enter product {i + 1} price: ");
                float price = Convert.ToSingle(Console.ReadLine());

                prodlist.Add(new Products(pid, name, price));
            }
            */

            foreach (Products p in prodlist)
            {
                Console.WriteLine(p.productId + " " + p.productName + " " + p.productPrice);
            }

            //sort based on price
            Console.WriteLine("Product details based on price...");
            var result = (from prd in prodlist
                          orderby prd.productPrice
                          select prd).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.productId + " " + item.productName + " " + item.productPrice);
            }

        }
    }
}
