namespace BCPA_OTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InititalCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false),
                        House = c.String(),
                        Street = c.String(),
                        Town = c.String(),
                        Postcode = c.String(),
                        County = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.People", t => t.AddressID)
                .Index(t => t.AddressID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.PaymentCards",
                c => new
                    {
                        PaymentCardID = c.Int(nullable: false),
                        CardNumber = c.Int(nullable: false),
                        ExpiryMonth = c.Int(nullable: false),
                        ExpiryYear = c.Int(nullable: false),
                        SecurityNumber = c.String(),
                    })
                .PrimaryKey(t => t.PaymentCardID)
                .ForeignKey("dbo.People", t => t.PaymentCardID)
                .Index(t => t.PaymentCardID);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        PurchaseID = c.Int(nullable: false, identity: true),
                        DatePaid = c.DateTime(nullable: false),
                        DateTicketsSent = c.DateTime(nullable: false),
                        EmailSent = c.Boolean(nullable: false),
                        MinTicketsForDiscount = c.Int(nullable: false),
                        MinCostForDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VolumeDiscount = c.Int(nullable: false),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseID)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketID = c.Int(nullable: false, identity: true),
                        Event = c.Boolean(nullable: false),
                        Show = c.Boolean(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SeatID = c.String(),
                        seat_SeatID = c.Int(),
                        Purchase_PurchaseID = c.Int(),
                    })
                .PrimaryKey(t => t.TicketID)
                .ForeignKey("dbo.Seats", t => t.seat_SeatID)
                .ForeignKey("dbo.Purchases", t => t.Purchase_PurchaseID)
                .Index(t => t.seat_SeatID)
                .Index(t => t.Purchase_PurchaseID);
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        SeatID = c.Int(nullable: false, identity: true),
                        RowNo = c.Int(nullable: false),
                        SeatNo = c.Int(nullable: false),
                        SeatType = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Agent_AgentID = c.Int(),
                        Show_ShowID = c.Int(),
                    })
                .PrimaryKey(t => t.SeatID)
                .ForeignKey("dbo.Agents", t => t.Agent_AgentID)
                .ForeignKey("dbo.Shows", t => t.Show_ShowID)
                .Index(t => t.Agent_AgentID)
                .Index(t => t.Show_ShowID);
            
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        AgentID = c.Int(nullable: false),
                        Comission = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AgentID)
                .ForeignKey("dbo.People", t => t.AgentID)
                .Index(t => t.AgentID);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                        ImageURL = c.String(),
                        Event_EventID = c.Int(),
                    })
                .PrimaryKey(t => t.ArtistID)
                .ForeignKey("dbo.Events", t => t.Event_EventID)
                .Index(t => t.Event_EventID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        StartDateTime = c.DateTime(nullable: false),
                        Duration = c.DateTime(nullable: false),
                        ImageURL = c.String(nullable: false, maxLength: 100),
                        VideoURL = c.String(nullable: false, maxLength: 255),
                        Description = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        PromotionID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        AdultDiscount = c.Int(nullable: false),
                        StudentDiscount = c.Int(nullable: false),
                        ChildDiscount = c.Int(nullable: false),
                        SeniorDiscount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PromotionID);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        ShowID = c.Int(nullable: false, identity: true),
                        PerformanceDate = c.DateTime(nullable: false),
                        Promotion_PromotionID = c.Int(),
                    })
                .PrimaryKey(t => t.ShowID)
                .ForeignKey("dbo.Promotions", t => t.Promotion_PromotionID)
                .Index(t => t.Promotion_PromotionID);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffID = c.Int(nullable: false),
                        JobRole = c.String(nullable: false, maxLength: 20),
                        Department = c.Int(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.StaffID)
                .ForeignKey("dbo.People", t => t.StaffID)
                .Index(t => t.StaffID);
            
            CreateTable(
                "dbo.Venues",
                c => new
                    {
                        VenueID = c.String(nullable: false, maxLength: 128),
                        Location = c.String(),
                        OpeningTime = c.Int(nullable: false),
                        ClosingTime = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.VenueID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "StaffID", "dbo.People");
            DropForeignKey("dbo.Seats", "Show_ShowID", "dbo.Shows");
            DropForeignKey("dbo.Shows", "Promotion_PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.Artists", "Event_EventID", "dbo.Events");
            DropForeignKey("dbo.Seats", "Agent_AgentID", "dbo.Agents");
            DropForeignKey("dbo.Agents", "AgentID", "dbo.People");
            DropForeignKey("dbo.Addresses", "AddressID", "dbo.People");
            DropForeignKey("dbo.Tickets", "Purchase_PurchaseID", "dbo.Purchases");
            DropForeignKey("dbo.Tickets", "seat_SeatID", "dbo.Seats");
            DropForeignKey("dbo.Purchases", "PersonID", "dbo.People");
            DropForeignKey("dbo.PaymentCards", "PaymentCardID", "dbo.People");
            DropIndex("dbo.Staffs", new[] { "StaffID" });
            DropIndex("dbo.Shows", new[] { "Promotion_PromotionID" });
            DropIndex("dbo.Artists", new[] { "Event_EventID" });
            DropIndex("dbo.Agents", new[] { "AgentID" });
            DropIndex("dbo.Seats", new[] { "Show_ShowID" });
            DropIndex("dbo.Seats", new[] { "Agent_AgentID" });
            DropIndex("dbo.Tickets", new[] { "Purchase_PurchaseID" });
            DropIndex("dbo.Tickets", new[] { "seat_SeatID" });
            DropIndex("dbo.Purchases", new[] { "PersonID" });
            DropIndex("dbo.PaymentCards", new[] { "PaymentCardID" });
            DropIndex("dbo.Addresses", new[] { "AddressID" });
            DropTable("dbo.Venues");
            DropTable("dbo.Staffs");
            DropTable("dbo.Shows");
            DropTable("dbo.Promotions");
            DropTable("dbo.Events");
            DropTable("dbo.Artists");
            DropTable("dbo.Agents");
            DropTable("dbo.Seats");
            DropTable("dbo.Tickets");
            DropTable("dbo.Purchases");
            DropTable("dbo.PaymentCards");
            DropTable("dbo.People");
            DropTable("dbo.Addresses");
        }
    }
}
