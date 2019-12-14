using System;
namespace PierresBakery.Models
{
    public class Pastry
    {
        public int ItemPrice { get; set; }
        public Pastry(string name; int price, int qty)
        {
            ItemPrice = price;
        }
    }
}