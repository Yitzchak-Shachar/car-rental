using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CarRent.Entities
{
  public  class RentDetails
    {
        public int RentDetailsId { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime RentStartTime { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime RentReturnTime { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime RentActualReturnTime { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }


    }
}
