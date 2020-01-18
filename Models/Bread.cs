using System;
namespace PierresBakery.Models
{
    public class Bread
    {
        public int Cost { get; } = 5;
        public int BreadQuantity { get; set; }

        public Bread(int qty)
        {
            BreadQuantity = qty;
        }

        public int GetCost()
        {
            return Cost;
        }

        public int GetTotal()
        {
            return Cost * BreadQuantity;
        }
    }
}
