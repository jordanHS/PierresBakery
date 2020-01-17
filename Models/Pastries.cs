using System;
namespace PierresBakery.Models
{
    public class Pastries
    {
        public int Cost { get; } = 2; 
        public int Quantity{ get; set; }
        
        public Pastries(int PstryQty)
        {
            Quantity = PstryQty;
        }

        public AddPastry(int PstryQty)
        {
            Quantity++;
            Cost += 2;
        }

        public PastriesTotal(int PastryQty)
        {
            Quantity * Cost
            {
                return PastriesTotal()
            }
        }
} 