using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Enteties
{
  public  class RentDetails
    {
        public int RentDetailsId { get; set; }
        public DateTime? RentStartTime { get; set; }
        public DateTime? RentReturnTime { get; set; }
        public DateTime? RentActualReturnTime { get; set; }
        public virtual User User { get; set; }
        public virtual  Car Car { get; set; }


    }
}
