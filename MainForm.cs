using System.Diagnostics;
using System.Text.Json;

namespace BuyersAdvisor
{
    public partial class MainForm : Form
    {
        ShopCollection shops = new ShopCollection();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("shops.txt"))
            {
                shops = JsonSerializer.Deserialize<ShopCollection>(File.ReadAllText("shops.txt"));
            }
            else
            {
                File.WriteAllText("shops.txt", JsonSerializer.Serialize(shops));
            }
            List<Shop> shopsList = shops.GetShopList();
            foreach (Shop shop in shopsList)
            {
                checkedListBox.Items.Add(shop);
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shop selectedShop = (Shop)checkedListBox.SelectedItem;
            infoText.Text = selectedShop.PrintShopInfo();
        }

        private void printInfoButton_Click(object sender, EventArgs e)
        {
            ShopCollection selectedShops = new ShopCollection(checkedListBox.CheckedItems.Cast<Shop>().ToList());
            File.WriteAllText("shopsInfo.txt", selectedShops.ToString());
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText("shops.txt", JsonSerializer.Serialize(shops));
        }
    }
}
