namespace Airlines.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyRelations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "FlightID", "dbo.Flights");
            AddForeignKey("dbo.Cities", "FlightID", "dbo.Flights", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "FlightID", "dbo.Flights");
            AddForeignKey("dbo.Cities", "FlightID", "dbo.Flights", "Id");
        }
    }
}
