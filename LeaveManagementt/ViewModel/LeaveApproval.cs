using LeaveManagementt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveManagementt.ViewModel
{
    public class LeaveApproval
    {
        public LeaveDetail LeaveDetail { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
    }
}