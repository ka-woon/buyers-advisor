using System.Diagnostics;

namespace BuyersAdvisor
{
    public partial class Form1 : Form
    {
        List<Shop> shops = new List<Shop>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shops.Add(new Shop("Аврора", "м. Харків, вул. Сонячна, 11", "Побутові речі", "Приватна", "Понеділок-П'ятниця 9:00-22:00", new List<string>() { "+380991234567", "+380991231212" }, new List<string>() { "Немає акційних товарів" }));
            shops.Add(new Shop("АТБ", "м. Харків, вул. Вигадана, 14", "Продуктовий магазин", "Приватна", "Понеділок-Субота цілободово", new List<string>() { "+380994445566" }, new List<string>() { "Яблука \"Чемпіон\"(-10%, аційна ціна: 29 грн/кг)" }));
            shops.Add(new Shop("Аптека 822", "м. Київ, пров. Київський, 28", "Аптека", "Колективна", "Без вихідних 10:00-19:00", new List<string>() { "+380992556565" }, new List<string>() { "\"Сішарпін\" 200мг (-30%, аційна ціна: 475 грн)", "\"Джаваскріпт-Форте\" 100мг (-10%, аційна ціна: 280 грн)" }));
            foreach (Shop shop in shops)
            {
                checkedListBox.Items.Add(shop);
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shop selectedShop = (Shop)checkedListBox.SelectedItem;
            infoText.Text = selectedShop.PrintShopInfo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void infoText_Click(object sender, EventArgs e)
        {

        }

        private void printInfoButton_Click(object sender, EventArgs e)
        {
            List<Shop> selectedShops = checkedListBox.CheckedItems.Cast<Shop>().ToList();
            string text = "";
            foreach(Shop shop in selectedShops)
            {
                text += "=====================================\n";
                text += shop.PrintShopInfo();
            }
            File.WriteAllText("shopsInfo.txt", text);
        }
    }
}
