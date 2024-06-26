﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyersAdvisor
{
    public class ShopCollection
    {
        public event Action? OnListChanged;
        public List<Shop> Shops { get; set; } = new List<Shop>();
        public static ShopCollection Instance { get; set; } = new ShopCollection();
        public ShopCollection(){}
        public ShopCollection(List<Shop> shopList)
        {
            Shops = shopList;
        }
        public override string ToString()
        {
            string text = "";
            foreach (Shop shop in Shops)
            {
                text += shop.PrintShopInfo();
                text += "***\n";
            }
            return text;
        }
        public void Add(Shop shop)
        {
            if (shop != null)
            {
                Shops.Add(shop);
            }
            OnListChanged?.Invoke();
        }
        public void Remove(Shop shop)
        {
            if (shop != null)
            {
                Shops.Remove(shop);
            }
            OnListChanged?.Invoke();
        }
        public void Replace(Shop shop, Shop newShop)
        {
            if (shop != null)
            {
                Shops[Shops.IndexOf(shop)] = newShop;
            }
            OnListChanged?.Invoke();
        }
        public List<Shop> GetShopList()
        {
            return Shops;
        }
        public List<Shop> SearchByTags(List<string> tags)
        {
            List<Shop> result = new List<Shop>(Shops);

            foreach (Shop shop in Shops)
            {
                foreach (string tag in tags)
                {
                    if (!shop.PrintRawInfo().ToLower().Contains(tag, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Remove(shop);
                        break;
                    }
                }
            }
            return result;
        }

        public static void Load()
        {
            if (File.Exists("shops.json"))
            {
                ShopCollection.Instance.Shops = JsonSerializer.Deserialize<List<Shop>>(File.ReadAllText("shops.json"));
            }
            else
            {
                File.WriteAllText("shops.json", JsonSerializer.Serialize(ShopCollection.Instance));
            }
        }

        public static void Save()
        {
            File.WriteAllText("shops.json", JsonSerializer.Serialize(ShopCollection.Instance.Shops));
        }
    }
}
