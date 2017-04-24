using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Enteties
{
    public class User
    {
        public int UserId { get; set; }
        // :TODO - add T"Z DataValidation
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public string UserName { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
        public  virtual ICollection<RentDetails> Rents { get; set; }

    }
}

namespace CarRent.Enteties
{
    public enum Gender
    {
        Male,
        Female
    }
}