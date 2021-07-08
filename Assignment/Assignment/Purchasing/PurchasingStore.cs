using Assignment.Bill;
using Assignment.Goods;
using Assignment.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Purchasing
{
    public class PurchasingStore
    {
        private PurchasingCart purchasingCart;
        private StoreShelf storeShelf;
        private PaymentCalculator paymentCalculator;
        private string country;

        public PurchasingStore()
        {
            country = "Local";
            purchasingCart = new PurchasingCart();
            paymentCalculator = new PaymentCalculator(country);
            storeShelf = new StoreShelf();
        }

        public void TakeOrderAndPlaceInCart(String name, double price, bool imported, int quantity)
        {
            Good good = storeShelf.SearchAndTakeOutItemFromShelf(name, price, imported, quantity);
            purchasingCart.AddItemToPurchasingCart(good);
        }

        public void GetSalesOrder()
        {
            do
            {
                string name = GetGoodName();
                double price = GetGoodPrice();
                bool imported = IsGoodImported();
                int quantity = GetQuantity();
                TakeOrderAndPlaceInCart(name, price, imported, quantity);
            }
            while (IsAddAnotherGood());
        }

        public void CheckOut()
        {
            paymentCalculator.billItemsInCart(purchasingCart);
            Receipt receipt = paymentCalculator.GetReceipt();
            paymentCalculator.PrintReceipt(receipt);
        }

        public String GetGoodName()
        {
            Console.WriteLine("Enter the good's name:\n");
            return Console.ReadLine();
        }

        public double GetGoodPrice()
        {
            Console.WriteLine("Enter the good's price:\n");
            var input = Console.ReadLine();
            double val;
            while (!(double.TryParse(input, out val)))
            {
                Console.WriteLine("Invalid price. Enter a number");
            }

            return val;
        }

        public bool IsGoodImported()
        {
            Console.WriteLine("Is good imported or not?(Y/N)\n");
            var input = Console.ReadLine();
            bool isValid = false;
            while (!isValid)
            {
                if (input == "Y")
                    isValid = true;
                else if (input == "N")
                    isValid = true;
                else
                    Console.WriteLine("Invalid input. Enter (Y/N)");
            }

            if (input == "Y")
                return true;
            else
                return false;
        }

        public int GetQuantity()
        {
            Console.WriteLine("Enter the quantity:\n");
            var input = Console.ReadLine();
            int intVal;
            while (!(int.TryParse(input, out intVal)))
            {
                Console.WriteLine("Invalid input. Enter a integer");
            }
            return intVal;
        }

        public bool IsAddAnotherGood()
        {
            Console.WriteLine("Do you want to add another Good?(Y/N)");

            var input = Console.ReadLine();
            while (!(input == "Y" || input == "N"))
            {
                Console.WriteLine("Invalid input. Enter (Y/N)");
            }

            bool addAnotherGood = TaxUtilities.BooleanParser(Convert.ToChar(input));
            return addAnotherGood;
        }
    }
}
