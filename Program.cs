using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
    public class Program
    {
        // private static string[] Bread = {"Bread", "bread"};
        // private static string[] Pastries = {"Pastries", "pastries"};
       

        public static void Main()
        {
            Console.WriteLine("Welcome to your Pierre's Bakery!");
            Console.WriteLine("Bread is $5 per loaf and pastries are $2 each");
            Console.WriteLine("We also have two specials today: Buy two loaves of bread & get the third free and, buy 3 pastries for $5");
            Console.WriteLine("Would you like to buy bread or pastries?");            
            string selection = Console.ReadLine();           
            if( selection == "bread" || selection == "Bread"){
                Order Bread = new Order(0, 0);
                Console.WriteLine("How many loaves would you like to buy: One or two? (Please use numbers only.)");
                string stringQuantity = Console.ReadLine();
                int qty = int.Parse(stringQuantity);
                if (qty == 2){
                    Bread.TwoLoaves();
                    Console.WriteLine("You purchased {0} loaves for ${1}! The third loaf is on the house!", Bread.ItemQuantity, Bread.CurrentTotal); 
                }
                else if (qty == 1){
                    Bread.OneLoaf();
                    Console.WriteLine("One loaf of bread is ${0}", Bread.OneLoaf);
                }
                }
            }
        }
    } 

