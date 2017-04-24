using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CarRent.MVC.Models
{
  public  class RentDetailsVM
    {
        public int RentDetailsId { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime RentStartTime { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime RentReturnTime { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime RentActualReturnTime { get; set; }
        public virtual UserVM User { get; set; }
        public virtual  CarVM Car { get; set; }


    }
}
