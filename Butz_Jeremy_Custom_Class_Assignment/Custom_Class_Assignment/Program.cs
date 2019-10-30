using System;

namespace Custom_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            Product nikeShoes = new Product("Nike Shoes",14m,90m);

            Product iPhone = new Product("iPhone 11 Pro",200m,1200m);

            Product powerBeatsPro = new Product("PowerBeats",100m,250m);

            


            Console.WriteLine("Hello lets take a look at some items we have online\r\n we have Nike Shoes an iPhone 11 and PowerBeats");
            Console.WriteLine("Please select an item from the list 1-3");

            string userInput = Console.ReadLine();
            decimal userInputCon;
            while (!(decimal.TryParse(userInput, out userInputCon) && userInputCon <=3 && userInputCon >0))
            {
                Console.WriteLine("\r\n Please only choose items 1 - 3 to see more information");
                userInput = Console.ReadLine();
            }

            if (userInputCon == 1) {

                Console.WriteLine(nikeShoes.GetItemName());
                Console.WriteLine("The selling price is "+nikeShoes.GetSellingPrice());
                Console.WriteLine("The cost to make this item is "+nikeShoes.GetCostToMake());
                Console.WriteLine("The profit for this item is "+nikeShoes.TotalProfit(1));

            } else if (userInputCon == 2) {

                Console.WriteLine(iPhone.GetItemName());
                Console.WriteLine("The selling price is "+iPhone.GetSellingPrice());
                Console.WriteLine("The cost to make this item is "+iPhone.GetCostToMake());
                Console.WriteLine("The total profit for this item is "+iPhone.TotalProfit(1));

            } else if (userInputCon == 3) {

                Console.WriteLine(powerBeatsPro.GetItemName());
                Console.WriteLine("The selling price is "+powerBeatsPro.GetSellingPrice());
                Console.WriteLine("The cost to make this item is "+powerBeatsPro.GetCostToMake());
                Console.WriteLine("The total profit for this item is "+powerBeatsPro.TotalProfit(1));

            }

            Console.WriteLine("How many of this item would you like?");
            string userQuantity = Console.ReadLine();
            decimal userQuantityCon;

            while (!(decimal.TryParse(userQuantity, out userQuantityCon) && userQuantityCon >0))
            {
                Console.WriteLine("Please only select only positive numbers");
                userQuantity = Console.ReadLine();

            }


            if (userInputCon == 1) {
                Console.WriteLine("The total profit for the item would be " + nikeShoes.TotalProfit(userQuantityCon)*userQuantityCon);

            } else if (userInputCon == 2) {
                Console.WriteLine("The total profit for the item would be " + iPhone.TotalProfit(userQuantityCon)*userQuantityCon);

            } else if (userInputCon == 3) {
                Console.WriteLine("The profit for the item would be "+ powerBeatsPro.TotalProfit(userQuantityCon)*userQuantityCon);

            }
            
            


        }
    }
}
