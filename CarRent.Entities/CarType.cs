using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Entities
{
    public class CarType
    {
        public int CarTypeId { get; set; }
        public string Manufacture { get; set; }
        public string Model { get; set; }
        public double DailyCost { get; set; }
        public double LateReturnDailyCost { get; set; }
        public int ManufactionYear { get; set; }
        public Gear Gear { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

        public bool MatchText(string searchText)
        {
            //:TODO - consider this usage to ignore letter case-  CompareOptions.IgnoreCase
            bool DoMatch = false;
            DoMatch = DoMatch || Gear.ToString().Contains(searchText);
            DoMatch = DoMatch || Manufacture.ToString().Contains(searchText);
            DoMatch = DoMatch || string.IsNullOrEmpty(Description) ? true : Description.ToString().Contains(searchText);
            DoMatch = DoMatch || Model.ToString().Contains(searchText);
            return DoMatch;

        }
    }
}

namespace CarRent.Entities
{
    public enum Gear
    {
        Automatic = 1,
        Tiptronic,
        Manual
    }
}