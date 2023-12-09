using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test01.Models;

namespace test01.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ViewBag.shopName = "Coputer Shop";
            List<Itemlist> itemlist = new List<Itemlist>
            {
                new Itemlist { Id = "001", Name = "Asus", Price = 500, Category = "Laptop" },
                new Itemlist { Id = "002", Name = "Acer", Price = 600, Category = "Laptop" },
                new Itemlist { Id = "003", Name = "Mac", Price = 1000, Category = "Laptop" },
                new Itemlist { Id = "004", Name = "Dell", Price = 400, Category = "Laptop" },
                new Itemlist { Id = "005", Name = "MSI", Price = 900, Category = "Laptop" }
            };
            itemlist.Add(new Itemlist { Id = "005", Name = "MSI", Price = 900, Category = "Laptop" });
            return View(itemlist);
        }
    }
}