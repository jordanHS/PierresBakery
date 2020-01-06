using System;
namespace PierresBakery.Models
{
    public class Bread
    {
        public string ItemName {get; set; }
        public int ItemQuantity {get; set; }
         public int ItemPrice { get; set; }
        public Bread(string bread, int qty, int price)
        {
            ItemName = bread;
            ItemQuantity = qty;
            ItemPrice = price;
        }
        public void Add()
        {
            ItemQuantity += 1;
            ItemPrice += 5;
        }
        public void Discount()
        {
            ItemQuantity += 3;
            ItemPrice += 10;
        }
        // public void Total()
        // {
        //     return ItemQuantity * ItemPrice;
        // }
    }
}