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
        public Sale() { }
        public Sale(string productName, double price, double discountedPrice)
        {
            ProductName = productName;
            Price = price;
            DiscountedPrice = discountedPrice;
        }
        public Sale(Sale sale) : this(sale.ProductName, sale.Price, sale.DiscountedPrice) { }

        public override string ToString()
        {
            return $"Назва товару: {ProductName}. Стара ціна: {Price} грн. Нова ціна: {DiscountedPrice} грн.";
        }
        public string PrintRawInfo()
        {
            return $"{ProductName} стара ціна: {Price} нова ціна: {DiscountedPrice}";
        }
    }
}