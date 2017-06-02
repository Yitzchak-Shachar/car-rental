using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRent.Entities;

namespace CarRent.MVC.Models
{
    public class UserVM
    {
        public int UserId { get; set; }
        // :TODO - add T"Z DataValidation
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public string UserName { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
        public virtual ICollection<RentDetailsVM> Rents { get; set; }


        public User GetUserVMAsUser()
        {
            return new User()
            {
                FullName = this.FullName,
                UserName = this.UserName,
                Password = this.Password
            };
        }

    }
}

namespace CarRent.MVC.Models
{
    public enum Gender
    {
        Male,
        Female
    }
}