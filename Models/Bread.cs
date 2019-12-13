using System;
namespace PierresBakery.Models
{
    public class Bread
    {
        public string ItemNane { get; set; }
        public int ItemPrice { get; set; }
        public Bread(string name; int price)
        {
            ItemName = name;
            ItemPrice = price;
        }
    }
}