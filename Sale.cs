﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyersAdvisor
{
    public class Sale
    {
        public string productName { get;}
        public double price { get;}
        public double discountedPrice { get;}
        public Sale(string productName, double price, double discountedPrice)
        {
            this.productName = productName;
            this.price = price;
            this.discountedPrice = discountedPrice;
        }
        public override string ToString()
        {
            return $"Назва товару: {productName}, стара ціна: {price}, нова ціна: {discountedPrice}";
        }
    }
}