using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee{employeeId=1,firstName="Fatma",lastName="Buyabes",email="Fatma@gmail.com",department="IT"},
            new Employee{employeeId=2,firstName="Awdhah",lastName="Alazmi",email="Awdhah@gmail.com",department="IT"}
        };
        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            var employee = employees.SingleOrDefault(a => a.employeeId == id);
            if (employees == null)
            {
                return RedirectToAction("Index");

            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddEmployeeForm model)
        {
            if (ModelState.IsValid)
            {
                var firstName = model.firstName;
                var lastName = model.lastName;
                var email = model.email;
                var department = model.department;

                var newEmployee = new Employee();
                newEmployee.firstName = firstName;
                newEmployee.lastName = lastName;
                newEmployee.department = department;
                newEmployee.email = email;
                employees.Add(newEmployee);
                return RedirectToAction("Index");
            }
            return View("Add");

        }
    }
}

