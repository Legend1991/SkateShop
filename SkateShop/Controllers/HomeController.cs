using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkateShop.Models;

namespace SkateShop.Controllers
{
    public class HomeController : Controller
    {
        SkateShopEntities storeDB = new SkateShopEntities();

        public ActionResult Index()
        {
            var items = GetTopSellingItems(5);

            return View(items);
        }

        public ActionResult About()
        {
            return View();
        }

        private List<Item> GetTopSellingItems(int count)
        {
            /*return storeDB.Items
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();*/
            return new List<Item>();
        }
    }
}
