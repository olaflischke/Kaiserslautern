namespace HistoricalRatesDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TradingDays", "TradingLocation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TradingDays", "TradingLocation");
        }
    }
}
