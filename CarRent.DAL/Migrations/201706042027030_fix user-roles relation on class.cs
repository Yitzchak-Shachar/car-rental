namespace CarRent.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixuserrolesrelationonclass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RentDetails", "User_UserId1", "dbo.Users");
            DropForeignKey("dbo.Users", "Role_RoleID", "dbo.Roles");
            DropForeignKey("dbo.RentDetails", "User_UserId2", "dbo.Users");
            DropForeignKey("dbo.RentDetails", "User_UserId", "dbo.Users");
            DropIndex("dbo.RentDetails", new[] { "User_UserId" });
            DropIndex("dbo.RentDetails", new[] { "User_UserId1" });
            DropIndex("dbo.RentDetails", new[] { "User_UserId2" });
            DropIndex("dbo.Users", new[] { "Role_RoleID" });
            DropColumn("dbo.RentDetails", "UserId");
            DropColumn("dbo.RentDetails", "UserId");
            RenameColumn(table: "dbo.RentDetails", name: "User_UserId2", newName: "UserId");
            RenameColumn(table: "dbo.RentDetails", name: "User_UserId", newName: "UserId");
            CreateTable(
                "dbo.RoleUsers",
                c => new
                    {
                        Role_RoleID = c.Int(nullable: false),
                        User_UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_RoleID, t.User_UserId })
                .ForeignKey("dbo.Roles", t => t.Role_RoleID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .Index(t => t.Role_RoleID)
                .Index(t => t.User_UserId);
            
            AlterColumn("dbo.RentDetails", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.RentDetails", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.RentDetails", "UserId");
            AddForeignKey("dbo.RentDetails", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
            DropColumn("dbo.RentDetails", "User_UserId1");
            DropColumn("dbo.Users", "Role_RoleID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Role_RoleID", c => c.Int());
            AddColumn("dbo.RentDetails", "User_UserId1", c => c.Int());
            DropForeignKey("dbo.RentDetails", "UserId", "dbo.Users");
            DropForeignKey("dbo.RoleUsers", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.RoleUsers", "Role_RoleID", "dbo.Roles");
            DropIndex("dbo.RoleUsers", new[] { "User_UserId" });
            DropIndex("dbo.RoleUsers", new[] { "Role_RoleID" });
            DropIndex("dbo.RentDetails", new[] { "UserId" });
            AlterColumn("dbo.RentDetails", "UserId", c => c.Int());
            AlterColumn("dbo.RentDetails", "UserId", c => c.Int());
            DropTable("dbo.RoleUsers");
            RenameColumn(table: "dbo.RentDetails", name: "UserId", newName: "User_UserId");
            RenameColumn(table: "dbo.RentDetails", name: "UserId", newName: "User_UserId2");
            AddColumn("dbo.RentDetails", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.RentDetails", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "Role_RoleID");
            CreateIndex("dbo.RentDetails", "User_UserId2");
            CreateIndex("dbo.RentDetails", "User_UserId1");
            CreateIndex("dbo.RentDetails", "User_UserId");
            AddForeignKey("dbo.RentDetails", "User_UserId", "dbo.Users", "UserId");
            AddForeignKey("dbo.RentDetails", "User_UserId2", "dbo.Users", "UserId");
            AddForeignKey("dbo.Users", "Role_RoleID", "dbo.Roles", "RoleID");
            AddForeignKey("dbo.RentDetails", "User_UserId1", "dbo.Users", "UserId");
        }
    }
}
