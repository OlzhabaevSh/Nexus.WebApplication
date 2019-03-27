namespace Nexus_WebApplication.Models
{
    using Nexus.Core.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NexusContext : DbContext
    {
        public virtual DbSet<ActivityStatus> ActivityStatus { get; set; }
        public virtual DbSet<ActivityType> ActivityTypes { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<MarketingActivity> MarketingActivities { get; set; }
        public virtual DbSet<MarketingActivityProduct> MarketingActivityProducts { get; set; }
        public virtual DbSet<MarketingActivityStore> MarketingActivityStores { get; set; }
        public virtual DbSet<MarketingActivityStorePlace> MarketingActivityStorePlaces { get; set; }
        public virtual DbSet<MarketingActivityType> MarketingActivityTypes { get; set; }
        public virtual DbSet<ProductBrand> ProductBrands { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductLine> ProductLines { get; set; }
        public virtual DbSet<ProductLink> ProductLinks { get; set; }
        public virtual DbSet<ProductStockKeepingUnit> ProductStockKeepingUnits { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StorePlace> StorePlaces { get; set; }
        
        public NexusContext()
            : base("name=NexusContext")
        {
        }
        
    }
}