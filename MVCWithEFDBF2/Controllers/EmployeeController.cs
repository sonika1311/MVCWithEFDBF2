using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWithEFDBF2.Models;

namespace MVCWithEFDBF2.Controllers
{
    public class EmployeeController : Controller
    {
        MVCDBEntities dc = new MVCDBEntities();
        public ViewResult DisplayEmployees()
        {
            var Emps = dc.Employees;
                //.Where(E =>E.Status==true);
            return View(Emps);
        }
        public ViewResult DisplayEmployee(int Eid)
        {
            var employee = dc.Employees.Find(Eid);
            return View(employee);
        }
    }
}