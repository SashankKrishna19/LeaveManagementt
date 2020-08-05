using LeaveManagementt.Models;
using LeaveManagementt.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveManagementt.Controllers
{
    public class LeaveApplicationController : Controller
    {
        // GET: LeaveApplication
        LeaveManagementDBEntities1 db = new LeaveManagementDBEntities1();

        public ActionResult Index()
        {
            List<Leave> leaves = db.Leaves.ToList();
            ViewBag.leaves = new SelectList(leaves, "LeaveId", "LeaveType");
            return View();
        }
        [HttpPost]
        public ActionResult ApplyLeave(LeaveDetail leaveDetail)
        {
            //if (!ModelState.IsValid)
            //{
            //    var viewModel = new LeaveViewModel
            //    {
            //        LeaveDetail = leaveDetail,
            //        Leaves = db.Leaves.ToList()
            //    };
            //}
            db.LeaveDetails.Add(leaveDetail);
            if (leaveDetail.Status == null)
            {
                leaveDetail.LeaveStatus = 1;
            }
            if (leaveDetail.TypeOfLeave == null)
            {
                leaveDetail.TypeOfLeave = 1;
            }

            db.SaveChanges();

            return RedirectToAction("Index", "ManagingDirector");
        }
    }
}