using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRent.Entities;

namespace CarRent.MVC.Models
{
    public class CarTypeVM
    {
        public int CarTypeId { get; set; }
        public string Manufacture { get; set; }
        public int ManufactionYear { get; set; }
        public string Model { get; set; }
        public double DailyCost { get; set; }
        public double LateReturnDailyCost { get; set; }
        public Gear Gear { get; set; }

        public virtual ICollection<CarVM> Cars { get; set; }

        public CarTypeVM()
        {
            //temp code
            // for the  ShowCarTypes() Action
        }
        public CarTypeVM(CarType carType)
        {
            CarTypeId = carType.CarTypeId;
            Manufacture = carType.Manufacture;
            ManufactionYear = carType.ManufactionYear;
            Model = carType.Model;
            DailyCost = carType.DailyCost;
            LateReturnDailyCost = carType.LateReturnDailyCost;
            Gear = carType.Gear;
        }
    }
}

