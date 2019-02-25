using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Core.Entities
{
    public class MarketingActivityProduct
    {
        public int Id { get; set; }

        public int MarketingActivityId { get; set; }
        public virtual MarketingActivity MarketingActivity { get; set; }

        public int ProductStockKeepingUnitId { get; set; }
        public virtual ProductStockKeepingUnit ProductStockKeepingUnit { get; set; }
    }
}
