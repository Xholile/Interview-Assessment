using Assignment.Goods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Purchasing
{
    public class StoreShelf
    {
        private readonly Dictionary<string, Good> goodItems;

        public StoreShelf()
        {
            goodItems = new Dictionary<string, Good>();
            AddGoodItemsToShelf("book", new Book());
            AddGoodItemsToShelf("music cd", new VariedGood());
            AddGoodItemsToShelf("chocolate bar", new Food());
            AddGoodItemsToShelf("box of chocolates", new Food());
            AddGoodItemsToShelf("bottle of perfume", new VariedGood());
            AddGoodItemsToShelf("packet of headache pills", new Medical());
        }

        public void AddGoodItemsToShelf(string goodItem, Good goodCategory)
        {
            goodItems.Add(goodItem, goodCategory);
        }

        public Good SearchAndTakeOutItemFromShelf(string name, double price, bool imported, int quantity)
        {
            Good goodItem = goodItems[name].GetFactory().CreateGood(name, price, imported, quantity);
            return goodItem;
        }

        public int GetShelfSize()
        {
            return goodItems.Count;
        }
    }
}
