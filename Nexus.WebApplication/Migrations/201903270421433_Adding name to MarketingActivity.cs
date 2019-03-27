namespace Nexus_WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingnametoMarketingActivity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MarketingActivities", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MarketingActivities", "Name");
        }
    }
}
