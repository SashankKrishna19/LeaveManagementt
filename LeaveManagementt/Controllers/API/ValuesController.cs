using LeaveManagementt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LeaveManagementt.Controllers.API
{
    public class ValuesController : ApiController
    {
        LeaveManagementDBEntities1 db = new LeaveManagementDBEntities1();
        public IHttpActionResult Getemp()
        {

            var results = db.Employees.ToList();
            return Ok(results);
        }

        //GET api/values/5
         public IHttpActionResult Getempid(Employee empsearch)
        {

            Employee empdetails = empsearch;
            //empdetails = db.Employees.Where(x => x.EmployeeId).Select(x => new Employee()
            //{
            //    EmployeeId = x.EmployeeId,
            //    EmployeeName = x.EmployeeName,
            //    RoleID = x.RoleID,
            //    UserName = x.UserName,
            //    Password = x.Password,
            //    MailId = x.MailId,
            //    PhoneNumber = x.PhoneNumber


            //}).FirstOrDefault<Employee>();
            empdetails = db.Employees.Find(empsearch);

            if (empdetails == null)
            {
                return NotFound();

            }
            return Ok(empdetails);
        }
    }
}
