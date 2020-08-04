using LeaveManagementt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveManagementt.Controllers
{
    public class ManagingDirectorController : Controller
    {
        // GET: ManagingDirector
        LeaveManagementDBEntities1 db = new LeaveManagementDBEntities1();
        public ActionResult Index()
        {
            var query = from LeaveDetail in db.LeaveDetails
                        where LeaveDetail.Employee.RoleID.Equals(2)
                        select LeaveDetail;
            return View(query);
        }
    }
}