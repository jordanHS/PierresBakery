using System;
namespace PierresBakery.Models
{
    public class Bread
    {
        public int Cost { get; } = 5;
        public int Total { get; set; }
        public int BreadQuantity { get; set; }

        public Bread(int qty, int total)
        {
            BreadQuantity = qty;
            Total = total;    
        }

        public int GetCost()
        {
            return Cost;
        }
    
        public int SetTotal()
        {
            return BreadQuantity * Cost;
            
        }
    }
}
