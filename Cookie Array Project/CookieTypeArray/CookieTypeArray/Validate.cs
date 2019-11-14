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




    }
}
