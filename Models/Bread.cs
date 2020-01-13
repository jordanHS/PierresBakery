using System;
namespace PierresBakery.Models
{
    public class Bread
    {
        public int ItemQuantity { get; set; }
        public int CurrentTotal { get; set; }
        
        public Order()
        {
            ItemQuantity = 0;
            CurrentTotal = 0;
        }
        
        public void OneLoaf()
        {
            AddItem();
            Total();
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
            AddItem();
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
