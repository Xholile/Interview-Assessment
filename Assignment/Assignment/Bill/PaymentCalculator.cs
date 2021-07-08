using Assignment.Goods;
using Assignment.Purchasing;
using Assignment.TaxCalculations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Bill
{
    public class PaymentCalculator
    {
        private Biller biller;
        private Receipt receipt;
        private List<Good> goodList;
        private string country;

        public PaymentCalculator(string country)
        {
            this.country = country;
        }

        public void billItemsInCart(PurchasingCart cart)
        {
            goodList = cart.GetItemsFromPurchasingCart();

            foreach (Good p in goodList)
            {
                biller = GetBiller(country);
                double productTax = biller.CalculateTax(p.Price, p.GetTaxValue(country), p.Imported);
                double taxedCost = biller.CalcTotalGoodCost(p.Price, productTax);
                p.TaxedCost = taxedCost;
            }
        }

        public Receipt GetReceipt()
        {
            double totalTax = biller.CalcTotalTax(goodList);
            double totalAmount = biller.CalcTotalAmount(goodList);
            receipt = biller.CreateNewReceipt(goodList, totalTax, totalAmount);
            return receipt;
        }

        public void PrintReceipt(Receipt receipt)
        {
            biller.GenerateReceipt(receipt);
        }

        public Biller GetBiller(String strategy)
        {
            TaxCalculationFactory factory = new TaxCalculationFactory();
            ITaxCalculation taxCal = factory.GetTaxCalculation(strategy);
            return new Biller(taxCal);
        }
    }
}
