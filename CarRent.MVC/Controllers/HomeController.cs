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
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ChooseCar()
        {
            var cm = new CarManager();
            var cars = cm.GetCars();
            var ViewModals = cars.Select(car => new CarVM()
            {
                Type = car.CarType.ToString(),
                LicenceNumber = car.LicenceNumber
            });
            return View(ViewModals);
        }

        public ActionResult ShowCars()
        {
            var cm = new CarManager();
            var cars = cm.GetCars();
            var ViewModals = cars.Select(car => new CarVM()
            {
                Type = car.CarType.ToString(),
                LicenceNumber = car.LicenceNumber
            });
            return View(ViewModals);
        }

        [HttpPost]
        public ActionResult AddCar(CarVM newCar)
        {
            if (newCar.CarId != 0)
            {
                // TODO: perfor validation before sending to DB
                var cm = new CarManager();
                cm.UpdateCar(new Car() { LicenceNumber = newCar.LicenceNumber });

                return Redirect("ShowCars");
            }
            else
                return View("Error");
        }

    public ActionResult ShowCarTypes()
        {
            var ctm = new CarTypeManager();
            var carTypes = ctm.GetCarTypes();
            var ViewModals = carTypes.Select(carT => new CarTypeVM()
            {
                CarTypeId = carT.CarTypeId,
                Manufacture=carT.Manufacture
            
            });

            return View(ViewModals);
        }


    }
}