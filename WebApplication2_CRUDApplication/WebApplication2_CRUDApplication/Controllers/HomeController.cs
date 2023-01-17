using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2_CRUDApplication.Controllers
{
    public class HomeController : Controller
    {
        /*public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
        // GET: Home
        public ActionResult Index()
        {
            using (TrainingDB2Entities entities = new TrainingDB2Entities())
            {
                List<Customer> customers = entities.Customers_PerformCRUD("SELECT", null, null, null).ToList();

                //Add a Dummy Row.
                customers.Insert(0, new Customer());
                return View(customers.ToList());
            }
        }

        [HttpPost]
        public JsonResult InsertCustomer(Customer customer)
        {
            using (TrainingDB2Entities entities = new TrainingDB2Entities())
            {
                Customer _customer = entities.Customers_PerformCRUD("INSERT", null, customer.Name, customer.Country).FirstOrDefault();
                return Json(_customer);
            }
        }

        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            using (TrainingDB2Entities entities = new TrainingDB2Entities())
            {
                entities.Customers_PerformCRUD("UPDATE", customer.CustomerId, customer.Name, customer.Country);
            }

            return new EmptyResult();
        }

        [HttpPost]
        public ActionResult DeleteCustomer(int customerId)
        {
            using (TrainingDB2Entities entities = new TrainingDB2Entities())
            {
                entities.Customers_PerformCRUD("DELETE", customerId, null, null);
            }

            return new EmptyResult();
        }

    }
}