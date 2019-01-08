namespace BCPA_OTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrices : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Promotions", "OrchestraPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Promotions", "StallPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Promotions", "BackPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Promotions", "BackPrice");
            DropColumn("dbo.Promotions", "StallPrice");
            DropColumn("dbo.Promotions", "OrchestraPrice");
        }
    }
}
