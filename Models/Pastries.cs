using System;
namespace PierresBakery.Models
{
    public class Pastries
    {
        public int Cost { get; set; }
        public int Quantity{ get; set; }
        
        public Pastries(int qty, int total)
        {
            Quantity = qty;
            Cost = 2;
        }      
    }
} 