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
            Console.WriteLine("We also have two specials today: Buy two loaves of bread & get the third free and, buy 3 pastries for $5");
            Console.WriteLine("Would you like to buy bread or pastries?");            
            string selection = Console.ReadLine();           
            if (selection == "bread" || selection == "Bread"){
                Bread myBread = new Bread(0, 0);
                Console.WriteLine("How many loaves would you like to buy: One or two? (Please use numbers only.)");
                string stringQuantity = Console.ReadLine();
                int qty = int.Parse(stringQuantity);
                if (qty == 2){
                    myBread.TwoLoaves();
                    Console.WriteLine("You purchased {0} loaves for ${1}! The third loaf is on the house!", myBread.ItemQuantity, myBread.CurrentTotal); 
                }
                else {
                    myBread.OneLoaf();
                    Console.WriteLine("{0} loaf of bread is ${1}!", myBread.ItemQuantity, myBread.CurrentTotal);
                }
                } 
            else if (selection == "pastries" || selection == "Pastries"){
                Pastries myPastries = new Pastries(0, 0);
                Console.WriteLine("How many pastries would you like: One, two or three? (Please use numbers only.)");
                string stringQuantity2 = Console.ReadLine();
                int qty2 = int.Parse(stringQuantity2);
                if (qty2 == 3){
                    myPastries.ThreePastries();
                    Console.WriteLine("You bought {0} pastries for ${1} and got a dollar off the last one!", myPastries.ItemQuantity, myPastries.CurrentTotal);
                }
                else if(qty2 == 2){
                    myPastries.TwoPastries();
                    Console.WriteLine("You bought {0} pastries for ${1}!", myPastries.ItemQuantity, myPastries.CurrentTotal);
                }
                else {
                    myPastries.OnePastry();
                    Console.WriteLine("You bought {0} pastry for ${1}!", myPastries.ItemQuantity, myPastries.CurrentTotal);
                }
            Console.WriteLine("Thank you for shopping at Pierre's Bakery! Have a lovely day!");
            }
        }
    }
} 

