using System;
namespace StringObjectsProject
{
    public class Validate
    {
        public static string ValidateString( string UserI)
        {

            while (string.IsNullOrEmpty(UserI) && UserI.Length == 12 && UserI.Length <= 16) 
            {
                Console.WriteLine("Please don't leave this blank\r\n Make sure it is between 12 and 16 long");
                UserI = Console.ReadLine();
            }

            return UserI;
        }







    }
}
