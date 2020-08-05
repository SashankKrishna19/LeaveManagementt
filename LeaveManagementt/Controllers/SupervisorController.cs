using LeaveManagementt.Models;
using LeaveManagementt.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveManagementt.Controllers
{

    public class SupervisorController : Controller
    {

        // GET: Supervisor
        LeaveManagementDBEntities1 db = new LeaveManagementDBEntities1();
        public ActionResult Index()
        {
            try
            {
                List<LeaveViewModel> query = new List<LeaveViewModel>();
                query = (from LeaveDetail in db.LeaveDetails
                         join Employee in db.Employees on LeaveDetail.Employee_Id equals Employee.EmployeeId
                         join Leave in db.Leaves on LeaveDetail.TypeOfLeave equals Leave.LeaveId
                         join Status in db.Status on LeaveDetail.LeaveStatus equals Status.StatusId
                         where LeaveDetail.Employee.RoleID.Equals(3)
                         select new LeaveViewModel
                         {
                             EmployeeName = Employee.EmployeeName,
                             LeaveType = Leave.LeaveType,
                             StatusType = Status.StatusType,
                             FromDate = LeaveDetail.FromDate,
                             ToDate = LeaveDetail.ToDate,
                             LeaveDescription = LeaveDetail.LeaveDescription,
                             LeaveStatus = LeaveDetail.LeaveStatus
                         }).ToList();
                return View(query);
            }
            catch (Exception ex)
            {

            }

            return View();
            //var query = (from LeaveDetail in db.LeaveDetails
            // join Employee in db.Employees on LeaveDetail.Employee_Id equals Employee.EmployeeId

            // select new LeaveViewModel{ Employee.EmployeeName, LeaveDetail.LeaveDescription, LeaveDetail.FromDate, LeaveDetail.ToDate });
            //return View(query);


        }

        public ActionResult LeaveApproval()
        {
            LeaveDetail leave = new LeaveDetail();
            //if (leave.LeaveStatus == 3)
            //{
            //    leave = db.LeaveDetails.FirstOrDefault(x => x.LeaveStatus == 3);
            //    leave.LeaveStatus = 1;
            //}
            //else



            leave = db.LeaveDetails.FirstOrDefault(x => x.LeaveStatus == 1);
            leave.LeaveStatus = 2;
            db.SaveChanges();





            return RedirectToAction("Index", "Supervisor");
        }
        public ActionResult LeaveRejection()
        {
            LeaveDetail leave = new LeaveDetail();


            leave = db.LeaveDetails.FirstOrDefault(x => x.LeaveStatus == 1);
            leave.LeaveStatus = 3;
            db.SaveChanges();



            return RedirectToAction("Index", "Supervisor");
        }
    }
}