using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
    public class Program
    {
        private static string[] Bread = {"Bread", "bread"};
        private static string[] Pastries = {"Pastries", "pastries"};
       

        public static void Main()
        {
            Console.WriteLine("Welcome to your Pierre's Bakery!");
            Console.WriteLine("Bread is $5 per loaf and pastries are $2 each");
            Console.WriteLine("We also have two specials today: Buy two loaves of bread & get the third free and, buy 3 pastries for $5");
            Console.WriteLine("Would you like to buy bread or pastries?");
            // string itemName = Console.ReadLine();
            // Bread myBread = new Bread(itemName, 0, 0);
            // Pastry myPastry = new Pastry(itemName, 0, 0);
            String selection = Console.ReadLine();
            if(Array.Exists(Bread, element => element == selection)){
                Console.WriteLine("How much bread would you like: one or two loaf(s)?");
                string stringQuantity = Console.ReadLine();
                int qty = int.Parse(stringQuantity);
                if( qty == 2){
                Console.WriteLine("You purchased {0} loaves of {1}. The third one is on the house!"); 

                }
            }
        }
    } 
}
