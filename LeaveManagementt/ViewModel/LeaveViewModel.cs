using LeaveManagementt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveManagementt.ViewModel
{
    public class LeaveViewModel
    {
        public IEnumerable<Leave> Leaves { get; set; }
        public int LeaveId { get; set; }

        public LeaveDetail LeaveDetail  { get; set; }

        public IEnumerable<Status> Statuses { get; set; }

        public int StatusId { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
        public int Employee_Id { get; set; }

      
    }
}