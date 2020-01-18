using System;
namespace PierresBakery.Models
{
    public class Pastries
    {
        public int Cost { get; } = 2;
        public int Total { get; set; }
        public int PastryQuantity { get; set; }
        
        public Pastries(int qty)
        {
            PastryQuantity = qty;
        }

        public int GetCost()
        {
            return Cost;
        }


        public int GetTotal()
        {
           return Cost * PastryQuantity;
        }
    }
} 
       