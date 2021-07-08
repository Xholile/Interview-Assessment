using Assignment.Goods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.GoodsFactory
{
    public class VariedGoodsFactory : GoodFactory
    {
        public override Goods.Good CreateGood(string name, double price, bool imported, int quantity)
        {
            return new VariedGood(name, price, imported, quantity);
        }
    }
}
