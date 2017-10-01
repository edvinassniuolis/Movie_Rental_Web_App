using Movie_Renta_Web_App.Models;
using Movie_Renta_Web_App.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Movie_Renta_Web_App.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> customers = new List<Customer>
        {
            new Customer() { Id = 1, Name = "James"},
            new Customer() { Id = 2, Name = "John"}
        };
        public ActionResult Index()
        {
            var customerModel = new IndexCustomerModel {Customers = customers};
            return View(customerModel);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = customers.FirstOrDefault((m) => m.Id == id);
            return View(customer);
        }
    }
}