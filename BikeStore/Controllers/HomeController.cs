using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeStore.Models;

namespace BikeStore.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private Models.DatabaseShopEntities1 db = new Models.DatabaseShopEntities1();


        public ActionResult Index()
        {
            var Items = db.Bikes;
            return View(Items);
        }

        public ActionResult BikePage(int item_id)
        {
            var Items = db.Bikes.FirstOrDefault(x => x.Id == item_id);
            return View(Items);
        }
       
        public ActionResult Contact()
        {
            var Contact = db.Bikes;
            return View(Contact);
        }
        public ActionResult Catalog()
        {
            var Items = db.Bikes;
            return View(Items);
        }

        public ActionResult Mat()
        {
            string str = "1";
            var bikes = from s in db.Bikes
                        select s;
            var Items = db.Bikes.Where(q => q.ChtoEto.Contains(str));
            return View(Items);
        }


        [HttpPost]
        public ActionResult Mat(string Firm, string Type, string Soket)
        {
            var bikes = from s in db.Bikes
                        select s;
            string str = "1";
            var Items = db.Bikes.Where(q => q.Firm.Contains(Firm) && q.Type.Contains(Type) && q.Soket.Contains(Soket) && q.ChtoEto.Contains(str));
            return View(Items);
        }

        public ActionResult Oper()
        {
            string str = "2";
            var bikes = from s in db.Bikes
                        select s;
            var Items = db.Bikes.Where(q => q.ChtoEto.Contains(str));
            return View(Items);
        }

        public ActionResult Procesor()
        {
            string str = "3";
            var bikes = from s in db.Bikes
                        select s;
            var Items = db.Bikes.Where(q => q.ChtoEto.Contains(str));
            return View(Items);
        }



        [HttpPost]
        public ActionResult Catalog(string Manufacturer, string Type, string Year, string Price, string Transmission)
        {
            var bikes = from s in db.Bikes
                        select s;
            //var Items = db.Bikes.Where(q => q.Manufacturer.Contains(Manufacturer) && q.Year.Contains(Year) && q.Price.Contains(Price) && q.Type.Contains(Type));
            return View();
        }

    }


}