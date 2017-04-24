using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.MVC.Models
{
  public  class CarTypeVM
    {
        public int CarTypeId { get; set; }
        public string Manufacture { get; set; }
        //public string Model { get; set; }
        //public double DailyCost { get; set; }
        //public double LateReturnDailyCost { get; set; }
        //public int ManufactionYear { get; set; }
        //public Gear Gear { get; set; }

        //public virtual ICollection<CarVM> Cars { get; set; }
    }
}

namespace CarRent.MVC.Models
{
    public enum Gear
    {
        Automatic,
        Tiptronic,
        Manual
    }
}