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
            AddThree();
            Discount();
        }

        private void AddThree()
        {
            ItemQuantity += 3;
        }

        private void Discount()
        {
            CurrentTotal += 10;
        }

    }
}
