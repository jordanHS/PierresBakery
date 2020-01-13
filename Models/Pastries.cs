using System;
namespace PierresBakery.Models
{
    public class Order
    {
        public string ItemName {get; set; }
        public int ItemQuantity {get; set; }
        public int CurrenTotal{ get; set; }
        
        public Order(string item)
        {
            ItemName = item;
            ItemQuantity = 0;
            ItemPrice = 0;
        }
        
        public void OnePastry()
        {
          AddItem();
          Total();
        }
        
        private void AddItem()
        {
            ItemQuantity++;
        }
        
        private void Total()
        {
            CurrentTotal +=2;
        }

        public void TwoPastries()
        {
            AddItem();
            Total();
        }

        private void AddItem()
        {
            ItemQuantity +=2;
        }

        private void Total()
        {
            CurrenTotal +=4;
        }


        public void ThreePastries()
        {
            AddItem();
            Discount();
        }

        private void AddItem()
        {
            ItemQuantity +=3;
        }

        private void Discount()
        {
            Total +=5;
        }
          
        }
    }
}