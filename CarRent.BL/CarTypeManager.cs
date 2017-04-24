using CarRent.DAL;
using CarRent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.BL
{
   public class CarTypeManager
    {
        public IEnumerable<CarType> GetCarTypes()
        {
            using (var context = new RentContext())
            {
                return context.CarTypes.ToArray();
            }
        }
        public CarType GetCarTypeById(int CarTypeId)
        {
            using (var context = new RentContext())
            {
                return context.CarTypes.Find(CarTypeId);
            }
        }

        public void UpdateCarType(CarType CarType)
        {
            using (var context = new RentContext())
            {
                context.CarTypes.Attach(CarType);
                context.Entry(CarType).State = CarType.CarTypeId == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void RemoveCarType(int CarTypeId)
        {
            using (var context = new RentContext())
            {
                // context.CarTypes.Add(CarType);
                CarType CarTypeToDelete = context.CarTypes.Find(CarTypeId);
                if (CarTypeToDelete != null)
                {
                    context.Entry(CarTypeToDelete).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                else
                {
                    // TODO: if CarTypeToDelete is null, report it or return something

                }
            }
        }

    }
}
