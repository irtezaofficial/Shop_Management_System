namespace Pharmacy_Management_System1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDeleteddOn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.String(),
                        OrderId = c.Int(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderEntities", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            AddColumn("dbo.UserEntities", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserEntities", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.OrderEntities", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.OrderDetailEntities", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.ProductEntities", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.RiderEntities", "DeletedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentDetails", "OrderId", "dbo.OrderEntities");
            DropIndex("dbo.PaymentDetails", new[] { "OrderId" });
            DropColumn("dbo.RiderEntities", "DeletedOn");
            DropColumn("dbo.ProductEntities", "DeletedOn");
            DropColumn("dbo.OrderDetailEntities", "DeletedOn");
            DropColumn("dbo.OrderEntities", "DeletedOn");
            DropColumn("dbo.UserEntities", "DeletedOn");
            DropColumn("dbo.UserEntities", "IsActive");
            DropTable("dbo.PaymentDetails");
        }
    }
}
