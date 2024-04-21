using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class CustomerController : Controller

    {

        static List<Customer> customers = new List<Customer>()
        {
            new Customer { id = 1,name="Fatma",email="Fatma@gmail.com",phone="98765432"},
            new Customer { id = 2,name="Awdhah",email="Awdhah@gmail.com",phone="23456789"}
        };
        public IActionResult Index()
        {
            return View(customers);
        }   


        public IActionResult Details(int id)
        {
            var customer = customers.SingleOrDefault(a => a.id == id);
            if (customers == null)
            {
                return RedirectToAction("Index");

            }
            return View(customer);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddCustomerForm model)
        {
            if (ModelState.IsValid)
            {
                var name = model.name;
                var email = model.email;
                var phone = model.phone;

                var newCustomer = new Customer();
                newCustomer.name = name;
                newCustomer.email = email;
                newCustomer.phone = phone;
                customers.Add(newCustomer);
                return RedirectToAction("Index");
            }
            return View("Add");

        }
    }
}

