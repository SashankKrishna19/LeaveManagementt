using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeaveManagementt.DTO
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
       
        public string EmployeeName { get; set; }
        
        public int RoleID { get; set; }
      
        public string UserName { get; set; }
      
        public string Password { get; set; }
        
        public string MailId { get; set; }

        public string PhoneNumber { get; set; }
    }
}