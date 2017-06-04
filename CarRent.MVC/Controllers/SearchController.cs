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
            var allCars = carMgr.GetCars().Select(car => new CarVM(car));
            var allCarTypes = carTypeMgr.GetCarTypes();//.Select(ctm => ctm.Manufacture);
            List<SelectListItem> listCarTypes = new List<SelectListItem>();
            List<SelectListItem> listCarGearTypes = new List<SelectListItem>();
            listCarTypes.AddRange(allCarTypes.Select(ct => new SelectListItem() { Text = ct.Model, Value = ct.CarTypeId.ToString() }));
            //listCarGearTypes.AddRange( Enum.GetNames(typeof(Gear)).Select(gt => new SelectListItem() { Text = gt.ToString(), Value = ((int)(Enum.Parse((typeof(Gear)),gt))).ToString() }));
            ViewBag.listOfCarTypes = listCarTypes;
            ViewBag.listOfGearTypes = listCarGearTypes;


            return View(allCars);
        }


        [HttpPost]
        public ActionResult GetCarsByCriterion(SearchVM Cretiria)
        {
            //:TODO  why the Cretiria has duplicate fields?

            //var allCars = carMgr.GetCars().Select(car => new CarVM(car));
            //allCars.filterByCretiria(cretiria);
            var allCarTypes = carTypeMgr.GetCarTypes();
            var allMatchings3 = allCarTypes.Where(ct => ((int)ct.Gear).ToString() == Cretiria.SearchGear);
            var allMatchings = allCarTypes.Where(ct =>
            ((int)ct.Gear).ToString() == Cretiria.SearchGear ||
            ct.CarTypeId.ToString() == Cretiria.SearchModel ||
           ( string.IsNullOrEmpty(Cretiria.SearchText) ? false : ct.MatchText(Cretiria.SearchText))
        );
            List<CarType> allMatching2 = new List<CarType>();
            foreach (CarType model in allCarTypes)
            {
                bool isIt = false;
                isIt =isIt|| ((int)model.Gear).ToString() == Cretiria.SearchGear;
                isIt =isIt|| model.CarTypeId.ToString() == Cretiria.SearchModel;
                isIt =isIt|| string.IsNullOrEmpty(Cretiria.SearchText) ? false : model.MatchText(Cretiria.SearchText);
                if (isIt)
                {
                    allMatching2.Add(model);
                }
            }
            //   var allMatchingsText = allModels.Where(ct => ct.MatchText(Cretiria.SearchText) );

            return Json(allCarTypes, JsonRequestBehavior.AllowGet);
        }


    }


}