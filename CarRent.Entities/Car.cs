using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Entities
{
  public  class Car
    {
        public int CarId { get; set; }
        public int CarTypeId { get; set; }
        public virtual CarType CarType { get; set; }
        public int Kilometrage { get; set; }
        public byte[] Image { get; set; }
        public bool RentalValid { get; set; }
        public bool RentalVacant { get; set; }
        public string LicenceNumber { get; set; }
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        public virtual ICollection<RentDetails> Rents { get; set; }
    }
}
