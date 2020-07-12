using Microsoft.Ajax.Utilities;
using MyMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
        public ActionResult EmpDetails()
        {
           List<EmployeeDetatils> ObjEmp = new List<EmployeeDetatils>()
            
                {
                //Adding records to list    
                new EmployeeDetatils { Id=1,Name="Vithal Wadje",City="Latur",Address="Kabansangvi" },
                    new EmployeeDetatils {Id=2,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" },
                     new EmployeeDetatils {Id=3,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" },
                      new EmployeeDetatils {Id=4,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" },
                       new EmployeeDetatils {Id=5,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" }
                };
            
            //return Json(ObjEmp, JsonRequestBehavior.AllowGet);
            return View(ObjEmp);
        }
    }
}