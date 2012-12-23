using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkateShop.Models;

namespace SkateShop.Controllers
{
    public class StoreController: Controller
    {
        SkateShopEntities storeDB = new SkateShopEntities();

        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = storeDB.Categories.ToList();

            return View(genres);
        }

        //
        // GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string category)
        {
            // Retrieve Genre and its Associated Albums from database
            var categoryModel = storeDB.Categories.Include("Items")
                .Single(c => c.Name == category);

            return View(categoryModel);
        }

        //
        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            var item = storeDB.Items.Find(id);

            return View(item);
        }

        //
        // GET: /Store/GenreMenu

        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var categories = storeDB.Categories.ToList();

            return PartialView(categories);
        }
    }
}