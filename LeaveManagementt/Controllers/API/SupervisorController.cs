using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LeaveManagementt.Models;
using LeaveManagementt.ViewModel;

namespace LeaveManagementt.Controllers.API
{
    public class SupervisorController : ApiController
    {
        private LeaveManagementDBEntities1 db;
        public SupervisorController()
        {
            db = new LeaveManagementDBEntities1();
            db.Configuration.ProxyCreationEnabled = false;
        }
        //public IEnumerable<LeaveViewModel> GetLeaveViewModels()
        //{
        //    List<LeaveViewModel> query = new List<LeaveViewModel>();
        //    query = (from LeaveDetail in db.LeaveDetails
        //             join Employee in db.Employees on LeaveDetail.Employee_Id equals Employee.EmployeeId
        //             join Leave in db.Leaves on LeaveDetail.TypeOfLeave equals Leave.LeaveId
        //             join Status in db.Status on LeaveDetail.LeaveStatus equals Status.StatusId
        //             where LeaveDetail.Employee.RoleID.Equals(3)
        //             select new LeaveViewModel
        //             {
        //                 EmployeeName = Employee.EmployeeName,
        //                 LeaveType = Leave.LeaveType,
        //                 StatusType = Status.StatusType,
        //                 FromDate = LeaveDetail.FromDate,
        //                 ToDate = LeaveDetail.ToDate,
        //                 LeaveDescription = LeaveDetail.LeaveDescription,
        //                 LeaveStatus = LeaveDetail.LeaveStatus
        //             }).ToList();
        //    return OK(db.LeaveDetails.ToList().Select(Mapper.Map<LeaveDetail,LeaveDetail>));
        //}
}
}
