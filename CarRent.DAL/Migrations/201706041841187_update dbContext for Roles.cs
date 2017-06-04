namespace CarRent.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedbContextforRoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
            AddColumn("dbo.Users", "Role_RoleID", c => c.Int());
            CreateIndex("dbo.Users", "Role_RoleID");
            AddForeignKey("dbo.Users", "Role_RoleID", "dbo.Roles", "RoleID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Role_RoleID", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "Role_RoleID" });
            DropColumn("dbo.Users", "Role_RoleID");
            DropTable("dbo.Roles");
        }
    }
}
