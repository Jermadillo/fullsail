using System;
using System.Collections.Generic;

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
            

            for (int i = 0; i < cookieTypeArray.Length; i++)
            {
                
                Console.WriteLine(cookieTypeArray[i]);
            }






        }
    }
}
