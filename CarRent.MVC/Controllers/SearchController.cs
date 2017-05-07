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
        private CarManager carMgr;
        private CarTypeManager carTypeMgr;
        public SearchController()
        {
            carMgr = new CarManager();
      carTypeMgr = new CarTypeManager();
        }


        // GET: Search
        public ActionResult Index()
        {
           var allCars=  carMgr.GetCars().Select(car=>new CarVM(car));
            var allCarTypes = carTypeMgr.GetCarTypes();//.Select(ctm => ctm.Manufacture);
            List<SelectListItem> listCarTypes = new List<SelectListItem>();
            listCarTypes.AddRange(allCarTypes.Select(ct => new SelectListItem() { Text = ct.Model, Value = ct.CarTypeId.ToString() }));
            ViewBag.listOfCarTypes = listCarTypes;

            return View(allCars);
        }
    }
}