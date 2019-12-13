using System;
namespace PierresBakery.Models
{
    public class Pastry
    {
        public string ItemNane { get; set; }
        public int ItemPrice { get; set; }
        public int Quantity { get; set; }
        public Pastry(string name; int price, int qty)
        {
            ItemName = name;
            ItemPrice = price;
            Quantity = qty;
        }
        public void AddToCart()
        {
            Quantity += 1;
        }
    }
}