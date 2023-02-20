//Program to know the price changes to stock we purchased
using System;

class Stock
{
    public string Symbol { get; set; }
    public double Price { get; set; }

    public Stock(string symbol, double price)
    {
        Symbol = symbol;
        Price = price;
    }

    public void PrintStockInfo()
    {
        Console.WriteLine("Symbol: " + Symbol);
        Console.WriteLine("Price: " + Price);
    }

    public double GetPriceChange(double newPrice)
    {
        return newPrice - Price;
    }
}

class Program46
{
    static void Main(string[] args)
    {
        Stock stock = new Stock("GOOG", 1000);
        stock.PrintStockInfo();

        Console.WriteLine("Enter new price: ");
        double newPrice = double.Parse(Console.ReadLine());

        double priceChange = stock.GetPriceChange(newPrice);
        Console.WriteLine("Price change: " + priceChange);
    }
}
