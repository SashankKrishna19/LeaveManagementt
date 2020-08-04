using LeaveManagementt.Models;
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
            var query = from LeaveDetail in db.LeaveDetails
                        where LeaveDetail.Employee.RoleID.Equals(3)
                        select  LeaveDetail;
            return View(query);

            //(from LeaveDetail in db.LeaveDetails
            // join Employee in db.Employees on LeaveDetail.EmployeeId equals Employee.Id

            // select new { Employee.EmployeeName, LeaveDetail.LeaveDescription, LeaveDetail.FromDate, LeaveDetail.ToDate });
            //return View(query);

            // SELECT LeaveDetails.EmployeeId,Employee.EmployeeName,Status.StatusType
            //  ,LeaveDetails.LeaveDescription,LeaveDetails.FromDate, LeaveDetails.ToDate
            //FROM Employee ,LeaveDetails,Status
            //WHERE  LeaveDetails.EmployeeId = Employee.Id And LeaveDetails.LeaveStatus = Status.StatusId
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
            
            
            


            return RedirectToAction("Index","Supervisor");
        }
        public ActionResult LeaveRejection()
        {
            LeaveDetail leave = new LeaveDetail();
           

           
                leave = db.LeaveDetails.FirstOrDefault(x => x.LeaveStatus == 1);
                leave.LeaveStatus = 3;
                db.SaveChanges();
            
           
            
            return RedirectToAction("Index","Supervisor");
        }
    }
}