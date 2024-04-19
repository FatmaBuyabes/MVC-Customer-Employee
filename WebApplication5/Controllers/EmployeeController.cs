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
    }
}

