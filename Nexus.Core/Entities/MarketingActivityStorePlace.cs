using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Core.Entities
{
    public class MarketingActivityStorePlace
    {
        public int Id { get; set; }

        public int? MarketingActivityId { get; set; }
        public virtual MarketingActivity MarketingActivity { get; set; }

        public int? StorePlaceId { get; set; }
        public virtual StorePlace StorePlace { get; set; }

        public int? ActivityTypeId { get; set; }
        public virtual ActivityType ActivityType { get; set; }

        public int PlanAmount { get; set; }

        public int FactAmount { get; set; }
    }
}
