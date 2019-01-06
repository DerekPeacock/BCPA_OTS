namespace BCPA_OTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEventToShow : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EndTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Shows", "EventID", c => c.Int(nullable: false));
            CreateIndex("dbo.Shows", "EventID");
            AddForeignKey("dbo.Shows", "EventID", "dbo.Events", "EventID", cascadeDelete: true);
            DropColumn("dbo.Events", "Duration");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "Duration", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Shows", "EventID", "dbo.Events");
            DropIndex("dbo.Shows", new[] { "EventID" });
            DropColumn("dbo.Shows", "EventID");
            DropColumn("dbo.Events", "EndTime");
        }
    }
}
