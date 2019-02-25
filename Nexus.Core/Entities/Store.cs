using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Core.Entities
{
    public class Store
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
