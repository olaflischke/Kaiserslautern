namespace HistoricalRatesDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Symbol = c.String(),
                        EuroValue = c.Double(nullable: false),
                        Day_TradingDayId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TradingDays", t => t.Day_TradingDayId)
                .Index(t => t.Day_TradingDayId);
            
            CreateTable(
                "dbo.TradingDays",
                c => new
                    {
                        TradingDayId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TradingDayId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Currencies", "Day_TradingDayId", "dbo.TradingDays");
            DropIndex("dbo.Currencies", new[] { "Day_TradingDayId" });
            DropTable("dbo.TradingDays");
            DropTable("dbo.Currencies");
        }
    }
}
