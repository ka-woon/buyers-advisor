using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyersAdvisor
{
    public class Shop
    {
        string name;
        string adress;
        string specialization;
        string ownership;
        string workTime;
        public List<string> phoneNumbers { get; set; }
        public List<Sale> sales { get; set; }
        public Shop(string name, string adress, string specialization, string ownership, string workTime, List<string> phoneNumbers, List<Sale> sales)
        {
            this.name = name;
            this.adress = adress;
            this.specialization = specialization;
            this.ownership = ownership;
            this.workTime = workTime;
            this.phoneNumbers = phoneNumbers;
            this.sales = sales;
        }
        public string PrintShopInfo()
        {
            string info = $"Назва: {name}\nАдреса: {adress}\nСпеціалізація: {specialization}\nФорма власності: {ownership}\n Робочий час: {workTime}\n";
            info += "Контакти:\n";
            foreach (string phoneNumber in phoneNumbers)
            {
                info += $"{phoneNumber}\n";
            }
            info += "Акційні товари: \n";
            foreach(Sale sale in sales)
            {
                info += $"{sale}\n";
            }
            return info;
        }
        public override string ToString()
        {
            return name;
        }
    }
}