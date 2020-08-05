using AutoMapper;
using LeaveManagementt.DTO;
using LeaveManagementt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LeaveManagementt.Controllers.API
{
    public class EmployeesController : ApiController
    {
        private LeaveManagementDBEntities1 db;
        public EmployeesController()
        {
            db = new LeaveManagementDBEntities1();
            db.Configuration.ProxyCreationEnabled = false;
        }

        //Get/api/Employees
        public IEnumerable<EmployeeDto> GetEmployees()
        {
            return db.Employees.ToList().Select(Mapper.Map<Employee, EmployeeDto>);
        }
        //Get /api/employees/1
        public IHttpActionResult GetEmployee(int id)
        {
            var employee = db.Employees.SingleOrDefault(m => m.EmployeeId == id);

            if (employee == null)
                return NotFound();
                //throw new HttpResponseException(HttpStatusCode.NotFound);

            return Ok(Mapper.Map<Employee, EmployeeDto>(employee));
        }

       // // Post/api/Employees
       // [HttpPost]
       // public Employee CreateEmployee(Employee employee)
       // {
       //     if (!ModelState.IsValid)
       //         throw new HttpResponseException(HttpStatusCode.BadRequest);
       //     db.Employees.Add(employee);
       //     db.SaveChanges();
       //     return employee;
       // }
       // //put /api/Employees/1
       // [HttpPut]
       // public void UpdateEmployee(int id, Employee employee)
       // {
       //     if (!ModelState.IsValid)
       //         throw new HttpResponseException(HttpStatusCode.BadRequest);

       //     var employeeInDb = db.Employees.SingleOrDefault(c => c.EmployeeId == id);

       //     if(employeeInDb == null)
       //         throw new HttpResponseException(HttpStatusCode.NotFound);

       //     employeeInDb.EmployeeName = employee.EmployeeName;
       //     employeeInDb.MailId = employee.MailId;
       //     employeeInDb.Password = employee.Password;
       //     employeeInDb.PhoneNumber = employee.PhoneNumber;
       //     employeeInDb.RoleID = employee.RoleID;
       //     employeeInDb.UserName = employee.UserName;

       //     db.SaveChanges();
       // }



       // // Delete /api/Employee/1
       // [HttpDelete]
       //public void DeleteEmployee(int id)
       // {
       //     var employeeInDb = db.Employees.SingleOrDefault(m => m.EmployeeId == id);

       //     if (employeeInDb == null)
       //         throw new HttpResponseException(HttpStatusCode.NotFound);

       //     db.Employees.Remove(employeeInDb);
       //     db.SaveChanges();
       // }


    }
}










