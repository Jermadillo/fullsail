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

            


            Console.WriteLine("Hello lets take a look at some items we have online\r\nWe have Nike Shoes an iPhone 11 and PowerBeats");
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
                Console.WriteLine("The selling price is "+nikeShoes.GetSellingPrice().ToString("C"));
                Console.WriteLine("The cost to make this item is "+nikeShoes.GetCostToMake().ToString("C"));
                Console.WriteLine("The profit for this item is "+nikeShoes.TotalProfit(1).ToString("C"));

            } else if (userInputCon == 2) {

                Console.WriteLine(iPhone.GetItemName());
                Console.WriteLine("The selling price is "+iPhone.GetSellingPrice().ToString("C"));
                Console.WriteLine("The cost to make this item is "+iPhone.GetCostToMake().ToString("C"));
                Console.WriteLine("The total profit for this item is "+iPhone.TotalProfit(1).ToString("C"));

            } else if (userInputCon == 3) {

                Console.WriteLine(powerBeatsPro.GetItemName());
                Console.WriteLine("The selling price is "+powerBeatsPro.GetSellingPrice().ToString("C"));
                Console.WriteLine("The cost to make this item is "+powerBeatsPro.GetCostToMake().ToString("C"));
                Console.WriteLine("The total profit for this item is "+powerBeatsPro.TotalProfit(1).ToString("C"));

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

			Console.WriteLine("Press enter to clear screen.");
			Console.ReadLine();
			Console.Clear();


            Console.WriteLine("Let's sell a product you want to sell!\r\nWhat is the name of your item");
            string userProduct = Product.ValidateString(Console.ReadLine());

            Console.WriteLine("\r\nHow much does this item cost to to make?");
            decimal userCost = Product.ValidateDecimal(Console.ReadLine());

            Console.WriteLine("How much are we selling this item for?");
            decimal userSellingPrice = Product.ValidateDecimal(Console.ReadLine());

            Console.WriteLine("How many items are you trying to sell?");
            decimal userHowMany = Product.ValidateDecimal(Console.ReadLine());


            decimal totalProfit = (userSellingPrice - userCost ) * userHowMany;



            Product UserProduct = new Product(userProduct,userCost,userSellingPrice);

            

            UserProduct.SetItemName(userProduct);
            UserProduct.SetCostToMake(userCost);
            UserProduct.SetSellingPrice(userSellingPrice);

            Console.WriteLine("You chose {0} as your product.",UserProduct.GetItemName());
            Console.WriteLine("You said it costs {0} to make",UserProduct.GetCostToMake().ToString("C"));
            Console.WriteLine("You said it sells for {0}",UserProduct.GetSellingPrice().ToString("C"));


            Console.WriteLine("Your profit for these items will be " + totalProfit.ToString("C"));








        }
    }
}
