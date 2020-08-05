using LeaveManagementt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveManagementt.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        LeaveManagementDBEntities1 db = new LeaveManagementDBEntities1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Authorise(Employee Emp)
        {
            var emp = db.Employees.Where(a => a.UserName == (Emp.UserName) && a.Password == (Emp.Password)).FirstOrDefault();
            if (emp == null)
            {

                return View("Index", Emp);
            }
            else
            {
                Session["Empid"] = Emp.EmployeeId;
                Session["Employee Name"] = Emp.UserName;


                return RedirectToAction("Index", "LeaveApplication");
            }
        }
        public ActionResult LogOut()
        {
            //int Empid = (int)Session["Empid"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}