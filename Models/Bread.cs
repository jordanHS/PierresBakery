using System;
namespace PierresBakery.Models
{
    public class Bread
    {
        public string ItemName {get; set; }
        public int ItemQuantity {get; set; }
         public int OrderCost { get; set; }
        public Bread(string item, int qty, int cost)
        {
            ItemName = item;
            ItemQuantity = qty;
            OrderCost = cost;
        }
        public void Add()
        {
            ItemQuantity += 1;
            OrderCost += 5;
        }
        public void Discount()
        {
            ItemQuantity += 3;
            OrderCost += 10;
        }
        public void Total()
        {
            return qty * cost;
        }
    }
}