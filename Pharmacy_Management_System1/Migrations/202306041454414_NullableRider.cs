namespace Pharmacy_Management_System1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableRider : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderEntities", "RiderId", "dbo.RiderEntities");
            DropIndex("dbo.OrderEntities", new[] { "RiderId" });
            AlterColumn("dbo.OrderEntities", "RiderId", c => c.Int());
            CreateIndex("dbo.OrderEntities", "RiderId");
            AddForeignKey("dbo.OrderEntities", "RiderId", "dbo.RiderEntities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderEntities", "RiderId", "dbo.RiderEntities");
            DropIndex("dbo.OrderEntities", new[] { "RiderId" });
            AlterColumn("dbo.OrderEntities", "RiderId", c => c.Int(nullable: false));
            CreateIndex("dbo.OrderEntities", "RiderId");
            AddForeignKey("dbo.OrderEntities", "RiderId", "dbo.RiderEntities", "Id", cascadeDelete: true);
        }
    }
}
