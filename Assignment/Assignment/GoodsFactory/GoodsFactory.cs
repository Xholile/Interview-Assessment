using Assignment.Goods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.GoodsFactory
{
    public abstract class GoodFactory
    {
        public abstract Good CreateGood(string name, double price, bool imported, int quantity);
    }
}
