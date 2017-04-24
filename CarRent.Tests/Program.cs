using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CarRent.BL;
using CarRent.Entities;

namespace CarRent.Tests
{
    class Program
    {
        static void Main(string[] args)
        {

            //UsersTests1();
            //CarsTests1();
            //CarsTests2();
            //CarsTests3();
            CarsTests4();

            Console.WriteLine("Press any key to Exit...");
            Console.ReadKey();

        }

        static public void UsersTests1()
        {

            var um = new UsersManager();

            um.AddUser(new User() { UserName = "Eli", FullName = "Eli Yahoo", Gender = Gender.Male });
            um.AddUser(new User() { UserName = "Avi", FullName = "Avi Kedem", Gender = Gender.Male, BirthDate = DateTime.Now });
            Console.WriteLine("Users on DB:");
            foreach (var item in um.GetUsers())
            {
                Console.WriteLine("User {0}, id {1}, BD_DOY {2}", item.FullName, item.UserId, item.BirthDate.DayOfYear);
            }

            um.RemoveUser(5);
            User chgdUserv = um.GetUserById(7);
            if (chgdUserv != null)
            {
                chgdUserv.BirthDate = chgdUserv.BirthDate.AddDays(1);
                um.UpdateUser(chgdUserv);
            }

            Console.WriteLine("Users on DB after changes:");
            foreach (var item in um.GetUsers())
            {
                Console.WriteLine("User {0}, id {1}, BD_DOY {2}", item.FullName, item.UserId, item.BirthDate.DayOfYear);
            }


        }
        //static public void CarsTests1()
        //{

        //    var cm = new CarManager();
        //    Car c = new Car();
        //    c.Branch = new Branch() { BranchId = 1 };
        //    c.CarTypeId =  = 2 };//{ Manufacture = "Hunda", Model = "Civic", ManufactionYear = 2015 };

        //    cm.AddCar(c);
        //}
        //static public void CarsTests2()
        //{

        //    var cm = new CarManager();
        //    Car c = new Car();
        //    c.Branch = new Branch() { BranchId = 1 };
        //    c.Type = new CarType() { Manufacture = "Hunda", Model = "Civic", ManufactionYear = 2015 };

        //    Console.WriteLine("Cars on DB:");
        //    foreach (var car in cm.GetCars())
        //    {
        //        Console.WriteLine("Car:  car.Branch{0}  car.CarId{1}  car.Kilometrage{2}  car.LicenceNumber{3}   car.Type{4}  car.Rents {5}", car.Branch, car.CarId, car.Kilometrage, car.LicenceNumber, car.Type, car.Rents);
        //    }


        //}
        //static public void CarsTests3()
        //{

        //    var cm = new CarManager();
        //    Car c = new Car();
        //    c.Branch = new Branch() { Name = "LOD" };
        //    c.Type = new CarType() { Manufacture = "Hunda", Model = "Civic", ManufactionYear = 2015 };
        //    //um.RemoveUser(5);
        //    //User chgdUserv = um.GetUserById(7);
        //    //if (chgdUserv != null)
        //    //{
        //    //    chgdUserv.BirthDate = chgdUserv.BirthDate.AddDays(1);
        //    //    um.UpdateUser(chgdUserv);
        //    //}

        //    //Console.WriteLine("Users on DB after changes:");
        //    //foreach (var item in um.GetUsers())
        //    //{
        //    //    Console.WriteLine("User {0}, id {1}, BD_DOY {2}", item.FullName, item.UserId, item.BirthDate.DayOfYear);
        //    //}

        //}

        static public void CarsTests4()
        {


            BranchManager bm = new BranchManager();
            Console.WriteLine("Current branchs:\n============");
            //bm.AddBranch(new Entities.Branch() { Name = "JLM", Address = "Yafo 233", GeoLocation = new GeoLocation() { Latitude = 90, Longtitude = 23 } });
            //bm.AddBranch(new Entities.Branch() { Name = "Lod", Address = "Herzl 78", GeoLocation = new GeoLocation() { Latitude = 669, Longtitude = 778 } });
            //bm.AddBranch(new Entities.Branch() { Name = "Haifa", Address = "Hazionut 7", GeoLocation = new GeoLocation() { Latitude = 123, Longtitude = 321 } });
            //bm.AddBranch(new Entities.Branch() { Name = "TLV", Address = "Herbert samuel 5", GeoLocation = new GeoLocation() { Latitude = 12, Longtitude = 45 } });
            //bm.AddBranch(new Entities.Branch() { Name = "APC", Address = "Airport city ,Lod", GeoLocation = new GeoLocation() { Latitude = 123, Longtitude = 321 } });
            foreach (Branch b in bm.GetBranchs())
            {
                Console.WriteLine("Name{0},BranchId{1},GeoLocation.Longtitude{2},GeoLocation.Longtitude{3}", b.Name, b.BranchId, b.GeoLocation.Longtitude, b.GeoLocation.Longtitude);
            }



            CarTypeManager ctm = new CarTypeManager();
            //ctm.AddCarType(new CarType() { Gear = Gear.Manual, Model = "Sedan", Manufacture = "Toyota", DailyCost = 99, LateReturnDailyCost = 110, ManufactionYear = 2012 });
            //ctm.AddCarType(new CarType() { Gear = Gear.Automatic, Model = "GLX", Manufacture = "Fiat", DailyCost = 80, LateReturnDailyCost = 120, ManufactionYear = 2015 });
            //ctm.AddCarType(new CarType() { Gear = Gear.Automatic, Model = "Turbo", Manufacture = "Mazda", DailyCost = 99, LateReturnDailyCost = 100, ManufactionYear = 2015 });
            //ctm.AddCarType(new CarType() { Gear = Gear.Automatic, Model = "Mini", Manufacture = "KIA", DailyCost = 105, LateReturnDailyCost = 110, ManufactionYear = 2013 });
            //ctm.AddCarType(new CarType() { Gear = Gear.Manual, Model = "CW", Manufacture = "Skoda", DailyCost = 78, LateReturnDailyCost = 120, ManufactionYear = 2013 });
            //ctm.AddCarType(new CarType() { Gear = Gear.Manual, Model = "MVP", Manufacture = "Ford", DailyCost = 90, LateReturnDailyCost = 112, ManufactionYear = 2016 });
            //ctm.AddCarType(new CarType() { Gear = Gear.Manual, Model = "Sedan", Manufacture = "Dacia", DailyCost = 80, LateReturnDailyCost = 100, ManufactionYear = 2011 });

            Console.WriteLine("Current Car types:\n============");

            foreach (CarType ct in ctm.GetCarTypes())
            {
                Console.WriteLine("Model={0},CarTypeId={1},Gear={2},ManufactionYear={3},Manufacture={4},", ct.Model, ct.CarTypeId, ct.Gear, ct.ManufactionYear, ct.Manufacture);
            }


            CarManager cm = new CarManager();

            Console.WriteLine("Current Cars:\n============");

            foreach (Car c in cm.GetCars())
            {
                Console.WriteLine("CarId={0},LicenceNumber={1},TypeId={2}", c.CarId, c.LicenceNumber, c.CarTypeId);
            }
            //    cm.AddCar(new Car() { BranchId = 1, CarTypeId = 2, Kilometrage = 432, LicenceNumber = "1234321" });
            //cm.AddCar(new Car() { BranchId=1, CarTypeId = 2,Kilometrage=432,LicenceNumber="1234321"});
            //cm.AddCar(new Car() { BranchId = 3, CarTypeId=5,Kilometrage=12345,LicenceNumber="767676"});


            Console.WriteLine("Enter CarId to remove (0 to skip):");
            int CarId = int.Parse(Console.ReadLine());
            if (CarId != 0)
            {
                cm.RemoveCar(CarId);
            }
            cm.UpdateCar(new Car() { CarId = 0, BranchId = 3, CarTypeId = 7, Kilometrage = 775533, LicenceNumber = "1222221" });

            Console.WriteLine("Current Cars:\n============");

            foreach (Car c in cm.GetCars())
            {
                Console.WriteLine("CarId={0},LicenceNumber={1},TypeId={2}", c.CarId, c.LicenceNumber, c.CarTypeId);
            }
            Console.WriteLine("Update car 6:\n============");

            //    cm.AddCar(new Car() { BranchId = 1, CarTypeId = 2, Kilometrage = 432, LicenceNumber = "1234321" });
            Car cc = cm.GetCarById(6);
            cc.CarTypeId = 6;
            cc.LicenceNumber += cc.CarTypeId;
            cm.UpdateCar(cc);
            Console.WriteLine("Current Cars:\n============");

            foreach (Car c in cm.GetCars())
            {
                Console.WriteLine("CarId={0},LicenceNumber={1},TypeId={2}", c.CarId, c.LicenceNumber, c.CarTypeId);
            }

        }
    }
}
