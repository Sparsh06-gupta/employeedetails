using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UserData.Models;

namespace UserData.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeContext _employeeContext;
        public HomeController(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public ActionResult Index()
        {
            var employeeList = _employeeContext.Employee.ToList();
            return View(employeeList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeContext.Employee.Add(employee);
                _employeeContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public IActionResult Edit(int id)
        {
            var employee = _employeeContext.Employee.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPut]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeContext.Employee.Update(employee);
                _employeeContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public IActionResult Delete(int id)
        {
            var employees = _employeeContext.Employee.Find(id);
            if (employees == null)
            {
                return NotFound();
            }
            return View(employees);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var employees = _employeeContext.Employee.Find(id);
            _employeeContext.Employee.Remove(employees);
            _employeeContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
