using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BuyersAdvisor
{
    public class Shop
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Specialization { get; set; } = "";
        public string Ownership { get; set; } = "";
        public WorkTime ShopWorkTime { get; set; } = new WorkTime();
        public List<string> Contacts { get; set; } = new List<string>();
        public List<Sale> Sales { get; set; } = new List<Sale>();
        public Shop() { }
        public Shop(string name, string address, string specialization, string ownership, WorkTime workTime, List<string> contacts, List<Sale> sales)
        {
            Name = name;
            Address = address;
            Specialization = specialization;
            Ownership = ownership;
            ShopWorkTime = workTime;
            Contacts = contacts;
            Sales = sales;
        }
        public Shop(Shop originalShop)
        {
            Name = originalShop.Name;
            Address = originalShop.Address;
            Specialization = originalShop.Specialization;
            Ownership = originalShop.Ownership;
            ShopWorkTime = originalShop.ShopWorkTime;
            Contacts = new List<string>(originalShop.Contacts);
            Sales = new List<Sale>(originalShop.Sales);
        }
        public string PrintShopInfo()
        {
            string info = $"Назва: {Name}\nАдреса: {Address}\nСпеціалізація: {Specialization}\nФорма власності: {Ownership}\nРобочий час: {ShopWorkTime}\n";
            info += "Контакти:\n";
            foreach (string contact in Contacts)
            {
                info += $"{contact}\n";
            }
            info += "Акційні товари:\n";
            foreach(Sale sale in Sales)
            {
                info += $"{sale}\n";
            }
            return info;
        }
        public string PrintRawInfo()
        {
            string contacts = "";
            foreach (string contact in Contacts)
            {
                contacts += $"{contact} ";
            }
            string sales = "";
            foreach (Sale sale in Sales)
            {
                sales += $"{sale.PrintRawInfo()} ";
            }
            return $"{Name} {Address} {Specialization} {Ownership} {ShopWorkTime.PrintRawInfo()} {contacts.Trim()} {sales.Trim()}";
        }
        public static bool CheckContactsCorrectivity(List<string> contacts, out string incorrectContact)
        {
            string phonePattern = @"^\+?(\d+)?(\(\d+\))?[\d-]*\d$";
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            incorrectContact = "";
            foreach (string contact in contacts)
            {
                if (!Regex.IsMatch(contact, phonePattern) && !Regex.IsMatch(contact, emailPattern))
                {
                    incorrectContact = contact;
                    return false;
                }
            }
            return true;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}