using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Core.Entities
{
    public class ProductStockKeepingUnit
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ProductLink> ProductLinks { get; set; }

        public virtual ICollection<MarketingActivityProduct> MarketingActivityProducts { get; set; }
    }
}
