// Module 3 Discussion
// I used the Stock class from Classes.txt and added an enum from Enums.txt

using System;

namespace Module3Discussion
{
    // Enum for how risky a stock is
    enum RiskLevel
    {
        Low,
        Medium,
        High
    }

    class Stock
    {
        public string Name { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal SharesOwned { get; set; }
        public RiskLevel Risk { get; set; }

        // Worth is calculated from the price and the number of shares
        public decimal Worth
        {
            get { return CurrentPrice * SharesOwned; }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Stock: " + Name);
            Console.WriteLine("Price: $" + CurrentPrice);
            Console.WriteLine("Shares: " + SharesOwned);
            Console.WriteLine("Worth: $" + Worth);
            Console.WriteLine("Risk: " + Risk);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create two stocks using object initializers
            Stock stock1 = new Stock { Name = "Apple", CurrentPrice = 50, SharesOwned = 100, Risk = RiskLevel.Low };
            Stock stock2 = new Stock { Name = "Tesla", CurrentPrice = 200, SharesOwned = 10, Risk = RiskLevel.High };

            stock1.PrintInfo();
            stock2.PrintInfo();

            decimal total = stock1.Worth + stock2.Worth;
            Console.WriteLine("Total worth: $" + total);

            if (stock2.Risk == RiskLevel.High)
            {
                Console.WriteLine(stock2.Name + " is a high risk stock.");
            }
        }
    }
}