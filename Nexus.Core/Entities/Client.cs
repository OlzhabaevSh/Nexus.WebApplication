using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Core.Entities
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Store> Stores { get; set; }

        public virtual ICollection<MarketingActivity> MarketingActivities { get; set; }
    }
}
