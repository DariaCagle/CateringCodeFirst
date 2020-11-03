namespace Catering.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Add_ChefType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CateringOrders", "ChefId", "dbo.Chefs");
            DropIndex("dbo.CateringOrders", new[] { "ChefId" });
            CreateTable(
                "dbo.ChefTypes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.CateringOrders", "ChefTypeId", c => c.Int(nullable: false, defaultValue: 1));
            CreateIndex("dbo.CateringOrders", "ChefTypeId");
            Sql("Insert into dbo.Waiters(Name) values (\'Not selected\')");
            AddForeignKey("dbo.CateringOrders", "ChefTypeId", "dbo.ChefTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.CateringOrders", "ChefId");
            DropTable("dbo.Chefs");
        }

        public override void Down()
        {
            CreateTable(
                "dbo.Chefs",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FullName = c.String(),
                    ChefType = c.String(),
                })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.CateringOrders", "ChefId", c => c.Int(nullable: false));
            DropForeignKey("dbo.CateringOrders", "ChefTypeId", "dbo.ChefTypes");
            DropIndex("dbo.CateringOrders", new[] { "ChefTypeId" });
            DropColumn("dbo.CateringOrders", "ChefTypeId");
            DropTable("dbo.ChefTypes");
            CreateIndex("dbo.CateringOrders", "ChefId");
            AddForeignKey("dbo.CateringOrders", "ChefId", "dbo.Chefs", "Id", cascadeDelete: true);
        }
    }
}
