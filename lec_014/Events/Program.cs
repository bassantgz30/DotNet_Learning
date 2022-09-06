// See https://aka.ms/new-console-template for more information
using System;
using StockClass;

class Program
{
    static void Main(string[] args)
    {
        Stock amazon = new Stock("Amazon");
        amazon.Price = 100;
        amazon.OnPriceCahnged += Stock_OnPriceCahnged; 

        Console.WriteLine($"Stock price before changing: {amazon.Price}");
        amazon.ChangeStockPriceBy(0.05);  // cahnge by 5%
        amazon.ChangeStockPriceBy(-0.02);  // cahnge by -2%
        amazon.ChangeStockPriceBy(0.0);  // no cahnge
    }

    static void Stock_OnPriceCahnged(Stock stock, double oldPrice)
    {
        if(stock.Price > oldPrice)
        {
            // Print text with green
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if(stock.Price < oldPrice)
        {
            // Print text with red
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            // Print text with gray
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        Console.WriteLine($"New stock price after change is: {stock.Price}");
    }
}
