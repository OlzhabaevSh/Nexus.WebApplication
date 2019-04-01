namespace Nexus_WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActivityStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ActivityTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MarketingActivityStorePlaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarketingActivityId = c.Int(),
                        StorePlaceId = c.Int(),
                        ActivityTypeId = c.Int(),
                        PlanAmount = c.Int(nullable: false),
                        FactAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ActivityTypes", t => t.ActivityTypeId)
                .ForeignKey("dbo.StorePlaces", t => t.StorePlaceId)
                .ForeignKey("dbo.MarketingActivities", t => t.MarketingActivityId)
                .Index(t => t.MarketingActivityId)
                .Index(t => t.StorePlaceId)
                .Index(t => t.ActivityTypeId);
            
            CreateTable(
                "dbo.MarketingActivities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BudgetTypeId = c.Int(),
                        ClientId = c.Int(),
                        MarketingActivityTypeId = c.Int(),
                        ActivityStatusId = c.Int(),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(),
                        Name = c.String(),
                        ProductCategoryId = c.Int(),
                        ProductBrandId = c.Int(),
                        ProductLineId = c.Int(),
                        Discount = c.Single(nullable: false),
                        MarginPercent = c.Single(nullable: false),
                        PlanedSales = c.Int(nullable: false),
                        PlanedSalesAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ActivityStatus", t => t.ActivityStatusId)
                .ForeignKey("dbo.BudgetTypes", t => t.BudgetTypeId)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.ProductBrands", t => t.ProductBrandId)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategoryId)
                .ForeignKey("dbo.ProductLines", t => t.ProductLineId)
                .ForeignKey("dbo.MarketingActivityTypes", t => t.MarketingActivityTypeId)
                .Index(t => t.BudgetTypeId)
                .Index(t => t.ClientId)
                .Index(t => t.MarketingActivityTypeId)
                .Index(t => t.ActivityStatusId)
                .Index(t => t.ProductCategoryId)
                .Index(t => t.ProductBrandId)
                .Index(t => t.ProductLineId);
            
            CreateTable(
                "dbo.BudgetTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ClientId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.MarketingActivityStores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarketingActivityId = c.Int(),
                        StoreId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MarketingActivities", t => t.MarketingActivityId)
                .ForeignKey("dbo.Stores", t => t.StoreId)
                .Index(t => t.MarketingActivityId)
                .Index(t => t.StoreId);
            
            CreateTable(
                "dbo.StorePlaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StoreId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.StoreId)
                .Index(t => t.StoreId);
            
            CreateTable(
                "dbo.MarketingActivityProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarketingActivityId = c.Int(),
                        ProductStockKeepingUnitId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MarketingActivities", t => t.MarketingActivityId)
                .ForeignKey("dbo.ProductStockKeepingUnits", t => t.ProductStockKeepingUnitId)
                .Index(t => t.MarketingActivityId)
                .Index(t => t.ProductStockKeepingUnitId);
            
            CreateTable(
                "dbo.ProductStockKeepingUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductCategoryId = c.Int(),
                        ProductBrandId = c.Int(),
                        ProductLineId = c.Int(),
                        ProductStockKeepingUnitId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductBrands", t => t.ProductBrandId)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategoryId)
                .ForeignKey("dbo.ProductLines", t => t.ProductLineId)
                .ForeignKey("dbo.ProductStockKeepingUnits", t => t.ProductStockKeepingUnitId)
                .Index(t => t.ProductCategoryId)
                .Index(t => t.ProductBrandId)
                .Index(t => t.ProductLineId)
                .Index(t => t.ProductStockKeepingUnitId);
            
            CreateTable(
                "dbo.ProductBrands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MarketingActivityTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MarketingActivities", "MarketingActivityTypeId", "dbo.MarketingActivityTypes");
            DropForeignKey("dbo.MarketingActivityStorePlaces", "MarketingActivityId", "dbo.MarketingActivities");
            DropForeignKey("dbo.ProductLinks", "ProductStockKeepingUnitId", "dbo.ProductStockKeepingUnits");
            DropForeignKey("dbo.ProductLinks", "ProductLineId", "dbo.ProductLines");
            DropForeignKey("dbo.MarketingActivities", "ProductLineId", "dbo.ProductLines");
            DropForeignKey("dbo.ProductLinks", "ProductCategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.MarketingActivities", "ProductCategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.ProductLinks", "ProductBrandId", "dbo.ProductBrands");
            DropForeignKey("dbo.MarketingActivities", "ProductBrandId", "dbo.ProductBrands");
            DropForeignKey("dbo.MarketingActivityProducts", "ProductStockKeepingUnitId", "dbo.ProductStockKeepingUnits");
            DropForeignKey("dbo.MarketingActivityProducts", "MarketingActivityId", "dbo.MarketingActivities");
            DropForeignKey("dbo.StorePlaces", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.MarketingActivityStorePlaces", "StorePlaceId", "dbo.StorePlaces");
            DropForeignKey("dbo.MarketingActivityStores", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.MarketingActivityStores", "MarketingActivityId", "dbo.MarketingActivities");
            DropForeignKey("dbo.Stores", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.MarketingActivities", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.MarketingActivities", "BudgetTypeId", "dbo.BudgetTypes");
            DropForeignKey("dbo.MarketingActivities", "ActivityStatusId", "dbo.ActivityStatus");
            DropForeignKey("dbo.MarketingActivityStorePlaces", "ActivityTypeId", "dbo.ActivityTypes");
            DropIndex("dbo.ProductLinks", new[] { "ProductStockKeepingUnitId" });
            DropIndex("dbo.ProductLinks", new[] { "ProductLineId" });
            DropIndex("dbo.ProductLinks", new[] { "ProductBrandId" });
            DropIndex("dbo.ProductLinks", new[] { "ProductCategoryId" });
            DropIndex("dbo.MarketingActivityProducts", new[] { "ProductStockKeepingUnitId" });
            DropIndex("dbo.MarketingActivityProducts", new[] { "MarketingActivityId" });
            DropIndex("dbo.StorePlaces", new[] { "StoreId" });
            DropIndex("dbo.MarketingActivityStores", new[] { "StoreId" });
            DropIndex("dbo.MarketingActivityStores", new[] { "MarketingActivityId" });
            DropIndex("dbo.Stores", new[] { "ClientId" });
            DropIndex("dbo.MarketingActivities", new[] { "ProductLineId" });
            DropIndex("dbo.MarketingActivities", new[] { "ProductBrandId" });
            DropIndex("dbo.MarketingActivities", new[] { "ProductCategoryId" });
            DropIndex("dbo.MarketingActivities", new[] { "ActivityStatusId" });
            DropIndex("dbo.MarketingActivities", new[] { "MarketingActivityTypeId" });
            DropIndex("dbo.MarketingActivities", new[] { "ClientId" });
            DropIndex("dbo.MarketingActivities", new[] { "BudgetTypeId" });
            DropIndex("dbo.MarketingActivityStorePlaces", new[] { "ActivityTypeId" });
            DropIndex("dbo.MarketingActivityStorePlaces", new[] { "StorePlaceId" });
            DropIndex("dbo.MarketingActivityStorePlaces", new[] { "MarketingActivityId" });
            DropTable("dbo.MarketingActivityTypes");
            DropTable("dbo.ProductLines");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.ProductBrands");
            DropTable("dbo.ProductLinks");
            DropTable("dbo.ProductStockKeepingUnits");
            DropTable("dbo.MarketingActivityProducts");
            DropTable("dbo.StorePlaces");
            DropTable("dbo.MarketingActivityStores");
            DropTable("dbo.Stores");
            DropTable("dbo.Clients");
            DropTable("dbo.BudgetTypes");
            DropTable("dbo.MarketingActivities");
            DropTable("dbo.MarketingActivityStorePlaces");
            DropTable("dbo.ActivityTypes");
            DropTable("dbo.ActivityStatus");
        }
    }
}
