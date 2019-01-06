namespace BCPA_OTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        Comission = c.Int(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        JobRole = c.String(maxLength: 20),
                        Department = c.Int(),
                        Salary = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PersonID);
            
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
                        Agent_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.SeatID)
                .ForeignKey("dbo.People", t => t.Agent_PersonID)
                .Index(t => t.Agent_PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seats", "Agent_PersonID", "dbo.People");
            DropForeignKey("dbo.Tickets", "Purchase_PurchaseID", "dbo.Purchases");
            DropForeignKey("dbo.Tickets", "seat_SeatID", "dbo.Seats");
            DropForeignKey("dbo.Purchases", "PersonID", "dbo.People");
            DropForeignKey("dbo.PaymentCards", "PaymentCardID", "dbo.People");
            DropForeignKey("dbo.Addresses", "AddressID", "dbo.People");
            DropIndex("dbo.Seats", new[] { "Agent_PersonID" });
            DropIndex("dbo.Tickets", new[] { "Purchase_PurchaseID" });
            DropIndex("dbo.Tickets", new[] { "seat_SeatID" });
            DropIndex("dbo.Purchases", new[] { "PersonID" });
            DropIndex("dbo.PaymentCards", new[] { "PaymentCardID" });
            DropIndex("dbo.Addresses", new[] { "AddressID" });
            DropTable("dbo.Seats");
            DropTable("dbo.Tickets");
            DropTable("dbo.Purchases");
            DropTable("dbo.PaymentCards");
            DropTable("dbo.Addresses");
            DropTable("dbo.People");
        }
    }
}
