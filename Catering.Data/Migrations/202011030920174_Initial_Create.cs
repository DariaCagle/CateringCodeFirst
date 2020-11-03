namespace Catering.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CateringOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ChefId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        NumberOfPeople = c.Int(nullable: false),
                        Outdoors = c.Boolean(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chefs", t => t.ChefId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ChefId);
            
            CreateTable(
                "dbo.Chefs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        ChefType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CateringOrders", "UserId", "dbo.Users");
            DropForeignKey("dbo.CateringOrders", "ChefId", "dbo.Chefs");
            DropIndex("dbo.CateringOrders", new[] { "ChefId" });
            DropIndex("dbo.CateringOrders", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Chefs");
            DropTable("dbo.CateringOrders");
        }
    }
}
