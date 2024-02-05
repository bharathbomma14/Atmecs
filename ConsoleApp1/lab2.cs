
using System;

namespace consoleApp1
{
    internal class Stock
    {
        string? name;
        double price;
        int shares;
        static void Main(string[] args)
        {
            Stock ibm = new Stock();
            ibm.Initialize("Ibm", 1200, 100);
            Console.WriteLine(ibm.Value());
        }
        void Initialize(string name, double price, int shares)
        {
            this.name = name;
            this.price = price;
            this.shares = shares;
        }
        void Buy(int shares)
        {
            this.shares += shares;
        }
        void Sell(int shares)
        {
            this.shares -= shares;
        }
        void SetPrice(double Price)
        {
            this.price += Price;
        }
        double Value()
        {
            return price * shares;
        }
    }

}

