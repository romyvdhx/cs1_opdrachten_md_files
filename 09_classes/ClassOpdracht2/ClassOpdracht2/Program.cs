using System;

namespace ClassOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //maak hier een variable aan met type ShopGreeter
            ShopGreeter shopGreeter = new ShopGreeter();
            //roep de function greetcustomer aan
            shopGreeter.GreetCustomer();
        }
    }
}