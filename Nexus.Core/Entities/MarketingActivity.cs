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

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public int MarketingActivityTypeId { get; set; }
        public virtual MarketingActivityType MarketingActivityType { get; set; }


        public int ProductLinkId { get; set; }
        public virtual ProductLink ProductLink { get; set; }

        public float Discount { get; set; }

        public float MarginPercent { get; set; }

        public int PlanedSalesAmount { get; set; }

    }
}
