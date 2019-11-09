using System;
using System.Globalization;
 

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Enter a random number?");
            double randNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your name");
            string randName = Console.ReadLine();

            Console.WriteLine("Enter how much money you made in 10 hours today");

            double randMoney = Convert.ToDouble(Console.ReadLine());





            object[] input = {randNum,randName,randMoney};

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }


             Console.WriteLine ("I Made a change and now you have to use Git Pull to see it");
         
         




















            int[] favNums = new int[3];

            favNums[0] = 23;

            string[] customers = { "Bob","Sally","Sue" };


            object[] randomArray = { "Paul", 45, 1.43 };

            Console.WriteLine(randomArray[2]);

            Console.WriteLine(randomArray.Length);

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine(randomArray[i]);

            }


            string[,] custNames = new string[2, 2] { { "Bob", "Sally" }, { "Mike", "Jeremy" } };

            Console.WriteLine( custNames.GetValue(0, 1));



            for (int i = 0; i < custNames.GetLength(0); i++)
            {

                for (int j = 0; j < custNames.GetLength(1); j++)

                {
                    Console.Write("{0}",
                        custNames [i,j]);
                    
                }


                


            }


            int[] randnum = { 1, 2, 3, 4 };

            Array.Sort(randnum);
            PrintArray(randnum, "Foreach");


            randnum.SetValue(0,3);

            Console.WriteLine(randnum[0]);

            int[] sourceArray = { 1, 4, 7 };
            int[] destArray = new int[2];
            int startind = 0;
            int length = 2;

            Array.Copy(sourceArray, startind, destArray, startind, length);

            PrintArray(destArray, "Copy");


            int[] numArray = { 1, 11, 22 };

            string[] fishColors = { "Blue", "Red" ,"Green","Blue","Red","Green" };


            var blueFish = Array.FindAll(fishColors,FindBlue);

            for (int i = 0; i < blueFish.Length; i++)
            {
                Console.WriteLine(blueFish[i]);
            }

            





            static void PrintArray (int [] intArray , string meess)
            {
                foreach (int k in intArray)
                {
                    Console.WriteLine("{0} : {1}",meess,k) ;
                }

            }
            

        }

        private static bool FindBlue(string val)

        {
            return val == "Blue";
        }



    }
}
