﻿namespace Catering.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Waiter_Table : DbMigration
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
            
            AddColumn("dbo.CateringOrders", "WaiterId", c => c.Int(nullable: false));
            CreateIndex("dbo.CateringOrders", "WaiterId");
            AddForeignKey("dbo.CateringOrders", "WaiterId", "dbo.Waiters", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CateringOrders", "WaiterId", "dbo.Waiters");
            DropIndex("dbo.CateringOrders", new[] { "WaiterId" });
            DropColumn("dbo.CateringOrders", "WaiterId");
            DropTable("dbo.Waiters");
        }
    }
}
