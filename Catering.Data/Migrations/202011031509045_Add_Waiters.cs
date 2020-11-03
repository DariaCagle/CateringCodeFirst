namespace Catering.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Waiters : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Waiters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CateringOrderWaiters",
                c => new
                    {
                        CateringOrder_Id = c.Int(nullable: false),
                        Waiter_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CateringOrder_Id, t.Waiter_Id })
                .ForeignKey("dbo.CateringOrders", t => t.CateringOrder_Id, cascadeDelete: true)
                .ForeignKey("dbo.Waiters", t => t.Waiter_Id, cascadeDelete: true)
                .Index(t => t.CateringOrder_Id)
                .Index(t => t.Waiter_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CateringOrderWaiters", "Waiter_Id", "dbo.Waiters");
            DropForeignKey("dbo.CateringOrderWaiters", "CateringOrder_Id", "dbo.CateringOrders");
            DropIndex("dbo.CateringOrderWaiters", new[] { "Waiter_Id" });
            DropIndex("dbo.CateringOrderWaiters", new[] { "CateringOrder_Id" });
            DropTable("dbo.CateringOrderWaiters");
            DropTable("dbo.Waiters");
        }
    }
}
