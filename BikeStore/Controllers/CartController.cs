using BikeStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EquiStore.Controllers
{
   /*  public class CartController : Controller
    {

        private DatabaseShopEntities1 db = new DatabaseShopEntities1();
       public ViewResult Index()
        {
           return View(new CartIndexViewModel
            {
                Cart = GetCart(),
            });
        }

       public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        public RedirectToRouteResult AddToCart(int productId)
        {
            Bikes product = db.Bikes.FirstOrDefault(p => p.Id == productId);

            if (product != null)
            {
                GetCart().AddItem(productId, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult RemoveFromCart(int productId)
        {
            Bikes product = db.Bikes.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                GetCart().RemoveLine(product);
            }
            return RedirectToAction("Index");
        }

        public ActionResult OrderView(CartLine cartLine)
        {
            return View();
        }


        [HttpPost]
        public ActionResult Save(Orders order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }*/
}