using _2020Partialview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2020Partialview.Controllers
{
    public class Class1Controller : Controller
    {
        List<Class1> Places = new List<Class1>()
       {
           new Class1 {PlaceID = 1, Name = "Stl Arch",Price =39.45,},
           new Class1 {PlaceID =1, Name = "Stl Zoo", Price=39.45},
           new Class1 {PlaceID =1, Name= "Larry Flynts",Price =69.00},
        
        };
        
        public PartialViewResult Prototype()
        {
            return PartialView(Places);
        }
        
        
        
        // GET: Class1
        public ActionResult Index()
        {
            return View();
        }
    }
}