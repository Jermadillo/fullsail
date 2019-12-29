using System;

namespace StringObjectsProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //this is a program called credti card observer
            //the code is supposed to return back a number
            //the person types in so that all but the last 4 numbers are X's
            //The program needs to count how long it is and replace all but 4 numbers with X's


            Console.WriteLine("Enter in a number from 12 - 16 characters long");

            string userNum = Validate.ValidateString(Console.ReadLine());

            Console.WriteLine("You chose this {0} as your number",userNum);

            char[] arrayNum = new char[userNum.Length];



            userNum.ToCharArray(0,arrayNum.Length);


            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.WriteLine(arrayNum[i]);
            }

        }
    }
}
