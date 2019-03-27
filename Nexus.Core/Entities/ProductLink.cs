using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Core.Entities
{
    public class ProductLink
    {
        public int Id { get; set; }

        public int? ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }

        public int? ProductBrandId { get; set; }
        public virtual ProductBrand ProductBrand { get; set; }

        public int? ProductLineId { get; set; }
        public virtual ProductLine ProductLine { get; set; }

        public int? ProductStockKeepingUnitId { get; set; }
        public virtual ProductStockKeepingUnit ProductStockKeepingUnit { get; set; }

        public virtual ICollection<MarketingActivity> MarketingActivities { get; set; }
    }
}
