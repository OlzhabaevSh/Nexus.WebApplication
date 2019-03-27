using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nexus_WebApplication.Models
{
    public static class EntityUrlHelper
    {
        public static string GetEntityUrlName(string entityName)
        {
            var types = typeof(NexusContext).GetProperties()
                .Where(x => x.PropertyType.IsGenericType
                    && x.PropertyType.GetGenericArguments().All(f => f.Name == entityName))
                .ToList();

            return types.First().Name;
        }
    }
}