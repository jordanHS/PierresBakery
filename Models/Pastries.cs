using System;
namespace PierresBakery.Models
{
    public class Pastries
    {
        public int ItemQuantity { get; set; }
        public int CurrentTotal{ get; set; }
        
        public Pastries(int qty, int cost)
        {

            ItemQuantity = qty;
            CurrentTotal = cost;
        }
        
        public void OnePastry()
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
            CurrentTotal += 2;
        }

        public void TwoPastries()
        {
            AddTwo();
            TotalTwo();
        }

        private void AddTwo()
        {
            ItemQuantity += 2;
        }

        private void TotalTwo()
        {
            CurrentTotal += 4;
        }


        public void ThreePastries()
        {
            AddThree();
            Discount();
        }

        private void AddThree()
        {
            ItemQuantity +=3;
        }

        private void Discount()
        {
           CurrentTotal +=5;
        }          
    }
}
