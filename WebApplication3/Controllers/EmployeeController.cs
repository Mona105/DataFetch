using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
         
        public IActionResult Index()
        {
            List<Location> locations = dbContext.Locations.ToList();
            return View(locations);
        }
        public IActionResult EmployeeList(int id)
        {
            List<Employee>
                employees = dbContext.Employees.Where(e => e.location.Id == id).ToList();
            return View(employees);
        }
    }
}
