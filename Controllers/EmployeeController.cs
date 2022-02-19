using AddEmployeeMigration.Entity;
using AddEmployeeMigration.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AddEmployeeMigration.Controllers
{
    public class EmployeeController : Controller
    {
        
        public ActionResult Index()
        {
            EmployeeDbContext context = new EmployeeDbContext();
            List<EmployeeInfo> detailList = new List<EmployeeInfo>();
            detailList = context.EmployeeInformation.ToList();


            return View(detailList);
        }

        
        public IActionResult Details(int id)
        {
            EmployeeDbContext context = new EmployeeDbContext();
            List<EmployeeInfo> detailList = new List<EmployeeInfo>();
            detailList = context.EmployeeInformation.Where(x => x.ID == id).ToList();
          
            return View(detailList);
        }

      
        public ActionResult Create()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmSimple emsimple)
        {
            EmployeeDbContext context = new EmployeeDbContext();
            EmployeeInfo employeeInfo = new EmployeeInfo();
            employeeInfo.ID = emsimple.ID;
            employeeInfo.FirstName = emsimple.FirstName;    
            employeeInfo.LastName = emsimple.LastName;
            employeeInfo.Email = emsimple.Email;
            context.Add(employeeInfo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
