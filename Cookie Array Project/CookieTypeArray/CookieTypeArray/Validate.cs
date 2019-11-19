using System;
namespace CookieTypeArray
{
    public class Validate
    {



        public static string ValidateString(string UserI)
        {
            while (string.IsNullOrWhiteSpace(UserI))    
            {
                Console.WriteLine("Don't leave this blank please");
                UserI = Console.ReadLine();
            }

            UserI = UserI.Trim();

            return UserI;
        }


        public static int ValidateInt (string UserI)
        {
            int howMany;

            while (!(int.TryParse(UserI,out howMany)))
            {
                Console.WriteLine("Please only select a whole number");
                UserI = Console.ReadLine();

            }

            return howMany;

        }

        public static decimal ValidateDecimal (string UserI)
        {
            decimal howMany;
            while (!(decimal.TryParse(UserI, out howMany)))
            {

                Console.WriteLine("Please type in number values only");
                UserI = Console.ReadLine();
            }

            return howMany;
        }




        public static decimal [] PromptCookieCosts (string [] CookieList)
        {
            decimal[] cookieCostEach = new decimal [CookieList.Length];

            for (int i = 0; i < CookieList.Length; i++)
            {
                Console.WriteLine("How much for {0}?",CookieList[i]);
                cookieCostEach[i] = Validate.ValidateDecimal(Console.ReadLine());

            }


            return cookieCostEach;


        }


        public static decimal TotalCookieCost (decimal [] CookieCost )
        {
            decimal totalSum = 0;

            for (int i = 0; i < CookieCost.Length; i++)
            {
                totalSum += CookieCost[i];



            }

            return totalSum;



        }

        public static decimal AmountSoldFor (int TotalCookieTypes,int IndivCookies,decimal CostPer)
        {
            decimal totalPerPackage = IndivCookies * CostPer;



            decimal absoluteTotal = totalPerPackage * TotalCookieTypes;


            return absoluteTotal;



        }




    }
}
