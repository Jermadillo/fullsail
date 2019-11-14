using System;
namespace cupcakeBusiness
{
    public class Validation
    {


        public static string Validatestring (string UserI)
        {
            

            while (string.IsNullOrWhiteSpace(UserI))
            {
                Console.WriteLine("Please Don't leave this blank");
                UserI = Console.ReadLine();

            }

            return UserI;

        }
        //validate the user is typing in a decimal
        public static decimal ValidateDecimal (string UserI)
        {
            decimal userI;

            while (!decimal.TryParse (UserI, out userI))

            {
                Console.WriteLine("Please only type in a valid number");
                UserI = Console.ReadLine();
            }


            return userI;
        }

        //function for calculating profit

        public static string Profit (decimal Cost, decimal Sells)
        {
            decimal profit = (Sells - Cost);

            return profit.ToString("C");

        }


    }
}
