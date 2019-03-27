using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Core.Entities
{
    public class StorePlace
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? StoreId { get; set; }
        public virtual Store Store { get; set; }

        public virtual ICollection<MarketingActivityStorePlace> MarketingActivityStorePlaces { get; set; }
    }
}
