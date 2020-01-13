using System;
namespace PierresBakery.Models
{
    public class Pastries
    {
        private int Item { get; }
        public int ItemQuantity { get; set; }
        public int CurrentTotal{ get; set; }
        
        public Pastries(int item)
        {

            ItemQuantity = 0;
            CurrentTotal = 0;
        }
        
        public void OnePastry()
        {
          AddOne();
          Total();
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
            TotalOne();
        }

        private void AddTwo()
        {
            ItemQuantity += 2;
        }

        private void TotalTwo()
        {
            CurrenTotal += 4;
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
