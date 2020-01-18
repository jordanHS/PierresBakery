using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to your Pierre's Bakery!");
            Console.WriteLine("Bread is $5 per loaf and pastries are $2 each");  
            Bread myBread = new Bread(0);
            Console.WriteLine("How many loaves would you like? (Please use numbers only)");
            myBread.BreadQuantity = int.Parse(Console.ReadLine());
            int breadTotal = myBread.BreadQuantity * myBread.Cost;
            Pastries myPastries = new Pastries(0);
            Console.WriteLine("How many pastries would you like?");
            myPastries.PastryQuantity=int.Parse(Console.ReadLine());
            int pastryTotal = myPastries.PastryQuantity * myPastries.Cost;
            Console.WriteLine("You bought {0} loaves of bread and {1} pastries.", myBread.BreadQuantity, myPastries.PastryQuantity);
            int orderTotal = myBread.GetTotal() + myPastries.GetTotal();
            string stringTotal = orderTotal.ToString();            
            Console.WriteLine("Your total is $" + stringTotal + "! Have a great day!");
        }
    }
}
