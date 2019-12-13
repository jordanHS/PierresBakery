using System;
namespace PierresBakery.Models
{
    public class Bread
    {
        public string ItemNane { get; set; }
        public int ItemPrice { get; set; }
        public int Quantity { get; set; }
        public Bread(string name; int price, int qty)
        {
            ItemName = name;
            ItemPrice = price;
            Quantity = qty;
        }
        public void Add()
        {
            Quantity += 1;
        }
    }
}