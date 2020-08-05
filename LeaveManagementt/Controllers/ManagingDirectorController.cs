using LeaveManagementt.Models;
using LeaveManagementt.ViewModel;
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
            List<LeaveViewModel> query = new List<LeaveViewModel>();
            query = (from LeaveDetail in db.LeaveDetails
                     join Employee in db.Employees on LeaveDetail.Employee_Id equals Employee.EmployeeId
                     join Leave in db.Leaves on LeaveDetail.TypeOfLeave equals Leave.LeaveId
                     join Status in db.Status on LeaveDetail.LeaveStatus equals Status.StatusId
                     where LeaveDetail.Employee.RoleID.Equals(2)
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
    }
}