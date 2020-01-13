using System;
namespace PierresBakery.Models
{
    public class Order
    {
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public int CurrentTotal { get; set; }
        
        public Order(string item)
        {
            ItemName = item;
            ItemQuantity = 0;
            CurrentTotal = 0;
        }
        
        public void OneLoaf()
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
            CurrentTotal +=5;
        }

        public void TwoLoaves()
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
            CurrentTotal += 10;
        }

        }
    }
}