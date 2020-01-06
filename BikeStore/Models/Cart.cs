using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeStore.Models
{
   /* public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public IEnumerable<CartLine> Lines { get { return lineCollection; } }
        private DatabaseShopEntities1 db = new Models.DatabaseShopEntities1();
        public void AddItem(int productId, int quantity)
        {
            CartLine line = new CartLine();
            line.Product = db.Bikes.FirstOrDefault(x => x.Id == productId);
            if (line.Quantity == 1)
            {
                line.Quantity += quantity;
            }
            else
            {
                line.Quantity = quantity;
            }
            lineCollection.Add(line);
        }

        public void RemoveLine(Bikes product)
        {
            lineCollection.RemoveAll(l => l.Product.Id == product.Id);
        }
        public void Clear()
        {
            lineCollection.Clear();
        }

    }

    public class CartLine
    {
        public Bikes Product { get; set; }
        public int Quantity { get; set; }
    }*/
}
