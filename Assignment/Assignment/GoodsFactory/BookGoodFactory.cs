using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.GoodsFactory
{
    public class BookGoodFactory : GoodFactory
    {
        public override Goods.Good CreateGood(string name, double price, bool imported, int quantity)
        {
            return new Goods.Book(name, price, imported, quantity);
        }
    }
}
