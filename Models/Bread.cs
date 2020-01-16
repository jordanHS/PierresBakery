using System;
namespace PierresBakery.Models
{
    public class Bread
    {
        public int Cost { get; set; }
        public int Quantity { get; set; }

        public Bread(int qty)
        {
            Quantity = qty;
            Cost = 5;            
        }
    }
}
