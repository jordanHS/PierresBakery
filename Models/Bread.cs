using System;
namespace PierresBakery.Models
{
    public class Bread
    {
        public int ItemPrice { get; set; }
        public Bread(int price)
        {
            ItemPrice = price;
        }
    }
}