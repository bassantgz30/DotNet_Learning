// See https://aka.ms/new-console-template for more information
using System;
using StockClass;

class Program
{
    static void Main(string[] args)
    {
        Stock amazon = new Stock("Amazon");
        amazon.Price = 100;

        Console.WriteLine($"Stock price before changing: {amazon.Price}");
        amazon.ChangeStockPriceBy(0.05);  // cahnge by 5%
        Console.WriteLine($"Stock price after changing by 5%: {amazon.Price}");

    }
}
