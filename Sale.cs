using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyersAdvisor
{
    public class Sale
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        public Sale(string productName, double price, double discountedPrice)
        {
            ProductName = productName;
            Price = price;
            DiscountedPrice = discountedPrice;
        }
        public override string ToString()
        {
            return $"Назва товару: {ProductName}. Стара ціна: {Price}. Нова ціна: {DiscountedPrice}";
        }
        public string PrintRawInfo()
        {
            return $"{ProductName} {Price} {DiscountedPrice}";
        }
    }
}