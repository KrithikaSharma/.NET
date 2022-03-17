using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assign.Models;

namespace MVC_Assign.Controllers
{
    public class CustomerController : Controller
    {
        NorthwindEntities1 Northwinddb = new NorthwindEntities1();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCustomerByCountry()
        {
            List<string> custname = (from cust in Northwinddb.Customers
                                     where cust.Country == "Germany"
                                     select cust.ContactName).ToList();
            return View(custname);
        }

        public ActionResult GetCustomerDetailsById()
        {
            List<Customer> customer = (from cust in Northwinddb.Customers
                                       join o in Northwinddb.Orders
                                       on cust.CustomerID equals o.CustomerID
                                       where o.OrderID == 10248
                                       select cust).ToList();

            return View(customer);
        }
    }
}
