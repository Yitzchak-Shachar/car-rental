using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Entities
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
       public string newline { get; set; }

        public GeoLocation GeoLocation { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }

    public class GeoLocation
    {
        public double Longtitude { get; set; }
        public double Latitude { get; set; }
    }
}