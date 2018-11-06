namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Airplanes",
                c => new
                    {
                        AirplaneId = c.String(nullable: false, maxLength: 7),
                        Model = c.String(nullable: false, maxLength: 255),
                        PlaneType = c.String(nullable: false, maxLength: 255),
                        CruiseSpeed = c.Double(),
                        EmptyWeight = c.Double(),
                        MaxTakeoffWeight = c.Double(),
                        MinNeededRunwaySize = c.Double(),
                        AirportId = c.String(maxLength: 7),
                    })
                .PrimaryKey(t => t.AirplaneId)
                .ForeignKey("dbo.Airports", t => t.AirportId)
                .Index(t => t.AirportId);
            
            CreateTable(
                "dbo.Airports",
                c => new
                    {
                        AirportId = c.String(nullable: false, maxLength: 7),
                        AirportName = c.String(nullable: false, maxLength: 255),
                        RunwaySize = c.Double(),
                        MaxFWParkingPlace = c.Double(),
                    })
                .PrimaryKey(t => t.AirportId);
            
            CreateTable(
                "dbo.Helicopters",
                c => new
                    {
                        HelicopterId = c.String(nullable: false, maxLength: 7),
                        Model = c.String(nullable: false, maxLength: 255),
                        CruiseSpeed = c.Double(),
                        EmptyWeight = c.Double(),
                        MaxTakeoffWeight = c.Double(),
                        Range = c.Double(),
                        AirportId = c.String(maxLength: 7),
                    })
                .PrimaryKey(t => t.HelicopterId)
                .ForeignKey("dbo.Airports", t => t.AirportId)
                .Index(t => t.AirportId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Airplanes", "AirportId", "dbo.Airports");
            DropForeignKey("dbo.Helicopters", "AirportId", "dbo.Airports");
            DropIndex("dbo.Helicopters", new[] { "AirportId" });
            DropIndex("dbo.Airplanes", new[] { "AirportId" });
            DropTable("dbo.Helicopters");
            DropTable("dbo.Airports");
            DropTable("dbo.Airplanes");
        }
    }
}
