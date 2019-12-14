using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
    public class Program
    {
        private static string[] Bread = {"Bread", "bread"};
        private static string[] Pastries = {"Pastries", "pastries"};
        private static int One = 1;
        private static int Two = 2;
        private static int Three = 3;

        public static void Main()
        {
            Console.WriteLine("Welcome to your Pierre's Bakery!");
            Console.WriteLine("Bread is $5 per loaf and pastries are 2 each");
            Console.WriteLine("We also have two specials today: Buy two loaves of bread & get the third free and, buy 3 pastries for $5");
            Console.WriteLine("Would you like to buy bread or pastries?");
            String selection = Console.ReadLine();
            if(Array.Exists(Bread, element => element == selection)){
                Console.WriteLine("How many loaves would you like: one, two or three?");
                string stringQuantity = Console.ReadLine();
                int quantity = int.Parse(stringQuantity);
                if(Array.Exists(Quantity, element => element == quantity));

            }
        }
    } 
}
