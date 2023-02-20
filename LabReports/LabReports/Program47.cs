// an example of a C# program that uses delegates to track changes in the price
// of a stock named "Nabil", with an initial price of 1569 includes the
// information on whether the stock price has gained or lost value, and by how much
using System;

delegate void StockPriceChange(double price);

class Stocks
{
    private double price;
    public Stocks(double price)
    {
        this.price = price;
    }

    public void OnPriceChanged(double newPrice)
    {
        double difference = newPrice - price;
        if (difference > 0)
        {
            Console.WriteLine("The price of Nabil stock has increased by $" + difference);
            Console.WriteLine("You have gained $" + difference);
        }
        else if (difference < 0)
        {
            Console.WriteLine("The price of Nabil stock has decreased by $" + Math.Abs(difference));
            Console.WriteLine("You have lost $" + Math.Abs(difference));
        }
        else
        {
            Console.WriteLine("The price of Nabil stock has not changed.");
        }
        price = newPrice;
    }
}

class Program47
{
    static void Main(string[] args)
    {
        Stocks nabil = new Stocks(1569);
        StockPriceChange stockPriceDelegate = new StockPriceChange(nabil.OnPriceChanged);

        Console.WriteLine("Enter the new price of the Nabil stock: ");
        double newPrice = Convert.ToDouble(Console.ReadLine());

        stockPriceDelegate(newPrice);
    }
}
