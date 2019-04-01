using Nexus_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nexus_WebApplication.Controllers
{
    public class DictionariesController : Controller
    {
        // GET: Dictionaries/Index
        public ActionResult Index(string entityName = "")
        {
            if (!string.IsNullOrEmpty(entityName))
            {
                return Redirect("/Dictionaries/Entities?entityName=" + entityName);
            }

            return View();
        }

        public ActionResult Entities(string entityName)
        {
            var types = typeof(NexusContext).GetProperties()
                .Where(x => x.PropertyType.IsGenericType)
                .SelectMany(x => x.PropertyType.GetGenericArguments())
                .ToList();

            var type = string.IsNullOrEmpty(entityName)
                ? types.First()
                : types.First(x => x.Name == entityName);

            return View(type);
        }

    }
    

}