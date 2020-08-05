using LeaveManagementt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;


namespace LeaveManagementt.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        LeaveManagementDBEntities1 db = new LeaveManagementDBEntities1();
        public ActionResult Index()
        {
            return View(db);
        }
        public ActionResult Details()
        {
            Employee empobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44352/api/");
            var consumeapi = hc.GetAsync("Values");
            consumeapi.Wait();
            var readdata = consumeapi.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<Employee>();
                displaydata.Wait();
                empobj = displaydata.Result;
            }
            return View(empobj);
        }
    }
}