using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CarRent.BL;
using CarRent.Entities;

namespace CarRent.MVC.Models
{
  public  class CarVM
    {
        private Car car;

        public CarVM(Car car)
        {
            CarId = car.CarId;
            TypeID = car.CarTypeId;

        }

        public int CarId { get; set; }
       // public virtual CarTypeVM Type { get; set; }
        public string Type { get; set; }
        public int TypeID { get; set; }
        public int Kilometrage { get; set; }
        public byte[] Image { get; set; }
        public bool RentalValid { get; set; }
        public bool RentalVacant { get; set; }
        public string LicenceNumber { get; set; }
      //  public virtual BranchVM Branch { get; set; }
        public string Branch { get; set; }

        public virtual ICollection<RentDetailsVM> Rents { get; set; }
    }
}
