using Assignment.Goods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Purchasing
{
    public class PurchasingCart
    {
        private List<Good> goodList { get; set; }

        public PurchasingCart()
        {
            goodList = new List<Good>();
        }

        public void AddItemToPurchasingCart(Good good)
        {
            goodList.Add(good);
        }

        public List<Good> GetItemsFromPurchasingCart()
        {
            return goodList;
        }

        public int GetCartSize()
        {
            return goodList.Count;
        }
    }
}
