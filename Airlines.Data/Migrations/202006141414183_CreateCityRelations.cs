namespace Airlines.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCityRelations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FlightID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flights", t => t.FlightID)
                .Index(t => t.FlightID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "FlightID", "dbo.Flights");
            DropIndex("dbo.Cities", new[] { "FlightID" });
            DropTable("dbo.Cities");
        }
    }
}
