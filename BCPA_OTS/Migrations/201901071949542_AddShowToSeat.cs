namespace BCPA_OTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShowToSeat : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Seats", "Show_ShowID", "dbo.Shows");
            DropIndex("dbo.Seats", new[] { "Show_ShowID" });
            RenameColumn(table: "dbo.Seats", name: "Show_ShowID", newName: "ShowID");
            AlterColumn("dbo.Seats", "ShowID", c => c.Int(nullable: false));
            CreateIndex("dbo.Seats", "ShowID");
            AddForeignKey("dbo.Seats", "ShowID", "dbo.Shows", "ShowID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seats", "ShowID", "dbo.Shows");
            DropIndex("dbo.Seats", new[] { "ShowID" });
            AlterColumn("dbo.Seats", "ShowID", c => c.Int());
            RenameColumn(table: "dbo.Seats", name: "ShowID", newName: "Show_ShowID");
            CreateIndex("dbo.Seats", "Show_ShowID");
            AddForeignKey("dbo.Seats", "Show_ShowID", "dbo.Shows", "ShowID");
        }
    }
}
