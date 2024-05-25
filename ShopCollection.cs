﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyersAdvisor
{
    public class ShopCollection
    {
        public List<Shop>? shops { get;} = new List<Shop>();
        public static ShopCollection Instance { get; set; } = new ShopCollection();
        public ShopCollection()
        {

        }
        public ShopCollection(List<Shop> shopList)
        {
            shops = shopList;
        }
        public override string ToString()
        {
            string text = "";
            foreach (Shop shop in shops)
            {
                text += "***\n";
                text += shop.PrintShopInfo();
            }
            return text;
        }
        public void Add(Shop shop)
        {
            if (shop != null)
            {
                shops.Add(shop);
            }
        }
        public List<Shop> GetShopList()
        {
            return shops;
        }
    }
}
