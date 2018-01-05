using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AAPL", "Apple");
            stocks.Add("GOOG", "Google");
            stocks.Add("AMZN", "Amazon");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 23, price: 2.21));
            purchases.Add((ticker: "CAT", shares: 32, price: 34.87));
            purchases.Add((ticker: "CAT", shares: 64, price: 19.02));
            purchases.Add((ticker: "APPL", shares: 124, price: 21.21));
            purchases.Add((ticker: "APPL", shares: 53, price: 16.87));
            purchases.Add((ticker: "APPL", shares: 56, price: 59.02));
            purchases.Add((ticker: "GOOG", shares: 21, price: 9.02));
            purchases.Add((ticker: "GOOG", shares: 15, price: 2.21));
            purchases.Add((ticker: "GOOG", shares: 24, price: 12.87));
            purchases.Add((ticker: "AMZN", shares: 55, price: 69.02));
            purchases.Add((ticker: "AMZN", shares: 10, price: 25.21));
            purchases.Add((ticker: "AMZN", shares: 62, price: 14.87));


            // Store total share values
            double gmShares = 0;
            double catShares = 0;
            double applShares = 0;
            double googShares = 0;
            double amznShares = 0;

            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?
                // If it does, update the total valuation
                if (purchase.Item1.Equals("GM")) 
                {
                    double gmTotal = purchase.shares * purchase.price;
                    gmShares += gmTotal;
                }
                if (purchase.Item1.Equals("CAT"))
                {
                    double catTotal = purchase.shares * purchase.price;
                    catShares += catTotal;
                }
                if (purchase.Item1.Equals("APPL"))
                {
                    double applTotal = purchase.shares * purchase.price;
                    applShares += applTotal;
                }
                if (purchase.Item1.Equals("GOOG"))
                {
                    double googTotal = purchase.shares * purchase.price;
                    googShares += googTotal;
                }
                if (purchase.Item1.Equals("AMZN"))
                {
                    double amznTotal = purchase.shares * purchase.price;
                    amznShares += amznTotal;
                }
                // If not, add the new key and set its value
            }
            Console.WriteLine(gmShares);
            Console.WriteLine(catShares);
            Console.WriteLine(applShares);
            Console.WriteLine(googShares);
            Console.WriteLine(amznShares);

            // Define a new Dictionary to hold the aggregated purchase information.
            // - The key should be a string that is the full company name.
            // - The value will be the valuation of each stock (price*amount)
            
            Dictionary<string, int> stockDetails = new Dictionary<string, int>();

         
            // {
            //     "General Electric": 35900,
            //     "AAPL": 8445,
            //     ...
            // }
        }
    }
}
