using System;
namespace PierresBakery.Models
{
    public class Bread
    {
        public int ItemQuantity { get; set; }
        public int CurrentTotal { get; set; }
        
        public Bread(int qty, int cost)
        {
            ItemQuantity = qty;
            CurrentTotal = cost;
        }
        
        public void OneLoaf()
        {
            AddOne();
            TotalOne();
        }
        
        private void AddOne()
        {
            ItemQuantity++;
        }

        private void TotalOne()
        {
            CurrentTotal += 5;
        }

        public void TwoLoaves()
        {
            AddTwo();
            TotalTwo();
            Discount();
        }

        private void AddTwo()
        {
            ItemQuantity += 2;
        }

        private void TotalTwo()
        {
            CurrentTotal += 10;
        }

        private void Discount()
        {
            ItemQuantity ++;
        }
    }
}
