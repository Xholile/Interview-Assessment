using Assignment.Goods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Bill
{
    public class Receipt
    {
        private List<Good> GoodList { get; set; }
        private double TotalSalesTax { get; set; }
        private double TotalAmount { get; set; }

        public Receipt(List<Good> prod, double tax, double amount)
        {
            GoodList = prod;
            TotalSalesTax = tax;
            TotalAmount = amount;
        }

        public int GetTotalNumberOfItems()
        {
            return GoodList.Count;
        }

        public override string ToString()
        {
            String receipt = "";
            Console.WriteLine("***************");
            foreach (var p in GoodList)
            {
                receipt += (p.ToString() + "\n");
            }

            receipt += "Total sales tax = " + TotalSalesTax + "\n";
            receipt += "Total amount = " + TotalAmount + "\n";

            return receipt;
        }
    }
}
