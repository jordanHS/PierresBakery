using System;
namespace PierresBakery.Models
{
    public class Pastry
    {
        public string ItemName {get; set; }
        public int ItemQuantity {get; set; }
         public int ItemPrice { get; set; }
        public Pastry(string pastry, int qty, int price)
        {
            ItemName = pastry;
            ItemQuantity = qty;
            ItemPrice = price;
        }
        public void Add()
        {
            ItemQuantity += 1;
            ItemPrice += 2;
        }
        public void Discount()
        {
            ItemQuantity += 3;
            ItemPrice += 5;
        }
        // public void Total()
        // {
        //     return ItemQuantity * ItemPrice;
        // }
    }
}