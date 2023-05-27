namespace Pharmacy_Management_System1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEntities : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "UserEntities");
            CreateTable(
                "dbo.OrderEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        RiderId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RiderEntities", t => t.RiderId, cascadeDelete: true)
                .ForeignKey("dbo.UserEntities", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RiderId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.OrderDetailEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderEntities", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.ProductEntities", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.ProductEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Discount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RiderEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.OrderEntities", "RiderId", "dbo.RiderEntities");
            DropForeignKey("dbo.OrderDetailEntities", "ProductId", "dbo.ProductEntities");
            DropForeignKey("dbo.OrderDetailEntities", "OrderId", "dbo.OrderEntities");
            DropIndex("dbo.OrderDetailEntities", new[] { "OrderId" });
            DropIndex("dbo.OrderDetailEntities", new[] { "ProductId" });
            DropIndex("dbo.OrderEntities", new[] { "UserId" });
            DropIndex("dbo.OrderEntities", new[] { "RiderId" });
            DropTable("dbo.RiderEntities");
            DropTable("dbo.ProductEntities");
            DropTable("dbo.OrderDetailEntities");
            DropTable("dbo.OrderEntities");
            RenameTable(name: "dbo.UserEntities", newName: "Users");
        }
    }
}
