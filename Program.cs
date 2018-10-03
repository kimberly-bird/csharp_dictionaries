using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple dictionary with ticker symbols and company names
            Dictionary<string, string> stocks = new Dictionary<string, string>();

            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AAPL", "Apple");
            stocks.Add("GOOG", "Google");
            stocks.Add("AMZN", "Amazon");

            // Create list of ValueTuples that represents stock purchases. Properties will be ticker, shares, price.
            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 23, price: 2.21));
            purchases.Add((ticker: "CAT", shares: 32, price: 34.87));
            purchases.Add((ticker: "CAT", shares: 64, price: 19.02));
            purchases.Add((ticker: "AAPL", shares: 124, price: 21.21));
            purchases.Add((ticker: "AAPL", shares: 53, price: 16.87));
            purchases.Add((ticker: "AAPL", shares: 56, price: 59.02));
            purchases.Add((ticker: "GOOG", shares: 21, price: 9.02));
            purchases.Add((ticker: "GOOG", shares: 15, price: 2.21));
            purchases.Add((ticker: "GOOG", shares: 24, price: 12.87));
            purchases.Add((ticker: "AMZN", shares: 55, price: 69.02));
            purchases.Add((ticker: "AMZN", shares: 10, price: 25.21));
            purchases.Add((ticker: "AMZN", shares: 62, price: 14.87));

            // Create a total ownership report that computes the total value of each stock that you have purchased.
            Dictionary<string, double> stockDetails = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // companyName will be the key, stockValue will be the value in the dictionary
                string companyName = stocks[purchase.ticker];
                double stockValue = purchase.shares * purchase.price;

                // Does the company name key already exist in the report dictionary?
                // returns boolean for whether companyName key exists in stockDetails 
                if (!stockDetails.ContainsKey(companyName))
                {
                    // If it doesn't exist, add and set its value
                    stockDetails.Add(companyName, stockValue);

                } else {
                    // If company name already exists, update the total valuation
                    stockDetails[companyName] += stockValue;
                }
            }
            // iterate over dictionary to display company and total stock value
            foreach(KeyValuePair<string, double> companyDetails in stockDetails)
            {
            Console.WriteLine($"{companyDetails.Key}: {companyDetails.Value}");
            }
        }
    }
}
