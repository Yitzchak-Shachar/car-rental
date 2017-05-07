namespace CarRent.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        GeoLocation_Longtitude = c.Double(nullable: false),
                        GeoLocation_Latitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BranchId);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        CarTypeId = c.Int(nullable: false),
                        Kilometrage = c.Int(nullable: false),
                        Image = c.Binary(),
                        RentalValid = c.Boolean(nullable: false),
                        RentalVacant = c.Boolean(nullable: false),
                        LicenceNumber = c.String(),
                        BranchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.CarTypes", t => t.CarTypeId, cascadeDelete: true)
                .Index(t => t.CarTypeId)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        CarTypeId = c.Int(nullable: false, identity: true),
                        Manufacture = c.String(),
                        Model = c.String(),
                        DailyCost = c.Double(nullable: false),
                        LateReturnDailyCost = c.Double(nullable: false),
                        ManufactionYear = c.Int(nullable: false),
                        Gear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarTypeId);
            
            CreateTable(
                "dbo.RentDetails",
                c => new
                    {
                        RentDetailsId = c.Int(nullable: false, identity: true),
                        RentStartTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        RentReturnTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        RentActualReturnTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UserId = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RentDetailsId)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.CarId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        IDNumber = c.String(),
                        UserName = c.String(),
                        BirthDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Gender = c.Int(nullable: false),
                        EmailAddress = c.String(),
                        Password = c.String(),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentDetails", "UserId", "dbo.Users");
            DropForeignKey("dbo.RentDetails", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Cars", "CarTypeId", "dbo.CarTypes");
            DropForeignKey("dbo.Cars", "BranchId", "dbo.Branches");
            DropIndex("dbo.RentDetails", new[] { "CarId" });
            DropIndex("dbo.RentDetails", new[] { "UserId" });
            DropIndex("dbo.Cars", new[] { "BranchId" });
            DropIndex("dbo.Cars", new[] { "CarTypeId" });
            DropTable("dbo.Users");
            DropTable("dbo.RentDetails");
            DropTable("dbo.CarTypes");
            DropTable("dbo.Cars");
            DropTable("dbo.Branches");
        }
    }
}
