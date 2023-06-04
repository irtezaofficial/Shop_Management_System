namespace Pharmacy_Management_System1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TotalProductAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderEntities", "TotalAmount", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderEntities", "TotalAmount");
        }
    }
}
