using System;
using System.Collections.Generic;

namespace cupcakeBusiness
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is going to be the project I never finished from SDI
            //This is a cupcake business that we'll build with user input


            //first we need to tell the user what we need from them.

            Console.WriteLine("Hello, lets sell some cupcakes together.");
            Console.WriteLine("Please type in 3 flavors of cupcakes you want to sell?");

            //array that holds the 3 types of flavors

            List <string> flavors = new List<string>();

            flavors.Add(Validation.Validatestring(Console.ReadLine()));
            Console.WriteLine("Please type in 2 more flavors of cupcakes you want to sell?");

            flavors.Add(Validation.Validatestring(Console.ReadLine()));

            Console.WriteLine("Please type in 1 more flavor of cupcake you want to sell?");
            flavors.Add(Validation.Validatestring(Console.ReadLine()));


            for (int i = 0; i < flavors.Count; i++)
            {
                
                Console.WriteLine("You Chose {0} as your flavor " ,flavors[i]);
            }

            Console.WriteLine("Press enter to clear");
            Console.ReadLine();
            Console.Clear();



            Console.WriteLine("\r\nHow much would you like to sell {0} for?",flavors[0]);

            List<decimal> flavorPrice = new List<decimal>();

            flavorPrice.Add(Validation.ValidateDecimal(Console.ReadLine()));

            Console.WriteLine("\r\nHow much would you like to sell {0} for?", flavors[1]);

            flavorPrice.Add(Validation.ValidateDecimal(Console.ReadLine()));

            Console.WriteLine("\r\nHow much would you like to sell {0} for?", flavors[2]);
            flavorPrice.Add(Validation.ValidateDecimal(Console.ReadLine()));


            for (int i = 0; i < flavorPrice.Count; i++)
            {
                Console.WriteLine("Awesome you want to sell {0} for {1}",flavors[i],flavorPrice[i].ToString("C"));
            }

            List<decimal> flavorCost = new List<decimal>();

            Console.WriteLine("Press enter to clear");
            Console.ReadLine();
            Console.Clear();




            Console.WriteLine("\r\nHow much did it cost you make {0}",flavors[0]);
            flavorCost.Add(Validation.ValidateDecimal(Console.ReadLine()));

            Console.WriteLine("How much did it cost you make {0}", flavors[1]);
            flavorCost.Add(Validation.ValidateDecimal(Console.ReadLine()));

            Console.WriteLine("How much did it cost you make {0}", flavors[2]);
            flavorCost.Add(Validation.ValidateDecimal(Console.ReadLine()));

            Console.WriteLine("Your profit for selling {0} would be {1}",flavors[0],Validation.Profit(flavorCost[0],flavorPrice[0]));
            Console.WriteLine("Your profit for selling {0} would be {1}", flavors[1], Validation.Profit(flavorCost[1], flavorPrice[1]));
            Console.WriteLine("Your profit for selling {0} would be {1}", flavors[2], Validation.Profit(flavorCost[2], flavorPrice[2]));






        }
    }
}
