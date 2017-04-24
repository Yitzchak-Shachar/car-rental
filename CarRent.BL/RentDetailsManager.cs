using CarRent.DAL;
using CarRent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.BL
{
    public class RentDetailsManager
    {
        public IEnumerable<RentDetails> GetRentDetails()
        {
            using (var context = new RentContext())
            {
                return context.Rents.ToArray();
            }
        }
        public RentDetails GetRentDetailsById(int rentDetailsId)
        {
            using (var context = new RentContext())
            {
                return context.Rents.Find(rentDetailsId);
            }
        }

        public void AddRentDetails(RentDetails rentDetails)
        {
            using (var context = new RentContext())
            {
                context.Rents.Attach(rentDetails);
                context.Entry(rentDetails).State = rentDetails.RentDetailsId == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void RemoveRentDetails(int rentDetailsId)
        {
            using (var context = new RentContext())
            {
                // context.Users.Add(user);
                RentDetails rentDetailsToDelete = context.Rents.Find(rentDetailsId);
                if (rentDetailsToDelete != null)
                {
                    context.Entry(rentDetailsToDelete).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                else
                {
                    // TODO: if userToDelete is null, report it or return something

                }
            }
        }

        public void UpdateRentDetails(RentDetails rentDetails)
        {
            // TODO: validate user exist on db befor trying to update
            // check if needs both Add\Update methods
            using (var context = new RentContext())
            {
                // context.Users.Add(user);
                context.Rents.Attach(rentDetails);
                context.Entry(rentDetails).State = rentDetails.RentDetailsId == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
