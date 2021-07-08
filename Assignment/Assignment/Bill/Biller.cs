using Assignment.Goods;
using Assignment.TaxCalculations;
using Assignment.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Bill
{
    public class Biller
    {
        ITaxCalculation taxCalculator;

        public Biller(ITaxCalculation taxCalculation)
        {
            taxCalculator = taxCalculation;
        }

        // Use decimal for financial calculations
        public double CalculateTax(double price, double tax, bool imported)
        {

            double totalGoodTax = taxCalculator.CalculateTax(price, tax, imported);
            return totalGoodTax;
        }

        public double CalcTotalGoodCost(double price, double tax)
        {
            return TaxUtilities.Truncate(price + tax);
        }

        public double CalcTotalTax(List<Good> goodList)
        {
            double totalTax = 0.0;

            foreach (Good p in goodList)
            {
                totalTax += (p.TaxedCost - p.Price);
            }

            return TaxUtilities.Truncate(totalTax);
        }

        public double CalcTotalAmount(List<Good> goodList)
        {
            double totalAmount = 0.0;

            foreach (Good p in goodList)
            {
                totalAmount += p.TaxedCost;
            }

            return TaxUtilities.Truncate(totalAmount);
        }

        public Receipt CreateNewReceipt(List<Good> goodList, double totalTax, double totalAmount)
        {
            return new Receipt(goodList, totalTax, totalAmount);
        }

        public void GenerateReceipt(Receipt r)
        {
            String receipt = r.ToString();
            Console.WriteLine(receipt);
        }

    }
}
