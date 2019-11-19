using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookieTypeArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is my cookie array project to help me get better at validating and dealing with arrays

            Console.WriteLine("We are going to make some money today with a cookie business.");
            Console.WriteLine("First we need to know how many cookie types you want to sell");

            int howMany = Validate.ValidateInt(Console.ReadLine());

            Console.WriteLine("So you want to sell {0} different types of cookies",howMany);

            Console.WriteLine("please type in the names of the different cookie types seperated by commas");
            string cookieTypeString = Validate.ValidateString(Console.ReadLine());



            
            string [] cookieTypeArray = cookieTypeString.Split(",");

            foreach (string i in cookieTypeArray)
            {
                i.Trim(' ');
            }



            for (int i = 0; i < cookieTypeArray.Length; i++)
            {
                
                Console.WriteLine(cookieTypeArray[i]);
            }

            Console.WriteLine("\r\nNow we need to find out how much you want to sell each package for");

            decimal[] cookieCostEach = Validate.PromptCookieCosts(cookieTypeArray);

            for (int i = 0; i < cookieCostEach.Length; i++)
            {
                

                Console.WriteLine("You chose {0} at the cost of {1}",cookieCostEach[i].ToString("C"),cookieTypeArray[i]);

            }

            


            decimal totalCookieCost = Validate.TotalCookieCost(cookieCostEach);

            Console.WriteLine("The total for all those cookie types is "+totalCookieCost.ToString("C"));




            Console.WriteLine("How many cookies are in each package?");

            int amountPer = Validate.ValidateInt(Console.ReadLine());


            Console.WriteLine("What is the cost of each individual cookie");

            decimal costPer = Validate.ValidateDecimal(Console.ReadLine());

            


            decimal totalProfit = Validate.AmountSoldFor(cookieTypeArray.Length, amountPer, costPer);


            Console.WriteLine("You will make {0} if you sell all {1} cookie types\r\n If each package contains {2} sold for {3} per cookie",totalProfit.ToString("C"),cookieTypeArray.Length,amountPer,costPer.ToString("C"));
            


        }
    }
}
