using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Core.Entities
{
    public class MarketingActivity
    {
        public int Id { get; set; }

        public int? BudgetTypeId { get; set; }
        public virtual BudgetType BudgetType { get; set; }

        public int? ClientId { get; set; }
        public virtual Client Client { get; set; }

        public int? MarketingActivityTypeId { get; set; }
        public virtual MarketingActivityType MarketingActivityType { get; set; }

        public int? ActivityStatusId { get; set; }
        public virtual ActivityStatus ActivityStatus { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public string Name { get; set; }
        
        public int? ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }

        public int? ProductBrandId { get; set; }
        public virtual ProductBrand ProductBrand { get; set; }

        public int? ProductLineId { get; set; }
        public virtual ProductLine ProductLine { get; set; }

        public float Discount { get; set; }

        public float MarginPercent { get; set; }

        public int PlanedSales { get; set; }

        public int PlanedSalesAmount { get; set; }
        
        public virtual ICollection<MarketingActivityStorePlace> MarketingActivityStorePlaces { get; set; }

        public virtual ICollection<MarketingActivityStore> MarketingActivityStores { get; set; }

        public virtual ICollection<MarketingActivityProduct> MarketingActivityProducts { get; set; }
    }
}
