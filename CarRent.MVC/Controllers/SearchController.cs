using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRent.BL;
using CarRent.MVC.Models;
using CarRent.Entities;

namespace CarRent.MVC.Controllers
{
    public class SearchController : Controller
    {
        private CarManager carManager;

        public SearchController()
        {
            carManager = new CarManager();
        }


        // GET: Search
        public ActionResult Index()
        {
           var allCars=  carManager.GetCars().Select(car=>new CarVM(car));

            return View(allCars);
        }
    }
}