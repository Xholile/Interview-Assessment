using Assignment.Purchasing;
using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchasingStore store = new PurchasingStore();
            store.GetSalesOrder();
            store.CheckOut();

            Console.ReadKey();

        }
    }
}
