using CarRent.DAL;
using CarRent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.BL
{
    public class CarManager
    {
         public IEnumerable<Car> GetCars()
        {
            using (var context = new RentContext())
            {
                return context.Cars.ToArray();
            }
        }
        public Car GetCarById(int CarId)
        {
            using (var context = new RentContext())
            {
                return context.Cars.Find(CarId);
            }
        }

        public void UpdateCar(Car Car)
        {
            using (var context = new RentContext())
            {
                context.Cars.Attach(Car);
                context.Entry(Car).State = Car.CarId == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void RemoveCar(int CarId)
        {
            using (var context = new RentContext())
            {
                // context.Cars.Add(Car);
                Car CarToDelete = context.Cars.Find(CarId);
                if (CarToDelete != null)
                {
                    context.Entry(CarToDelete).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                else
                {
                    // TODO: if CarToDelete is null, report it or return something

                }
            }
        }

        //public void UpdateCar(Car Car)
        //{
        //    // TODO: validate Car exist on db befor trying to update
        //    // check if needs both Add\Update methods
        //    using (var context = new RentContext())
        //    {
        //        // context.Cars.Add(Car);
        //        context.Cars.Attach(Car);
        //        context.Entry(Car).State = Car.CarId == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}

    }
}
