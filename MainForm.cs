using System.Diagnostics;
using System.Text.Json;

namespace BuyersAdvisor
{
    public partial class MainForm : Form
    {
        List<Shop> shops = new List<Shop>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists("shops.txt"))
            {
                shops = JsonSerializer.Deserialize<List<Shop>>(File.ReadAllText("shops.txt"));
            }
            else
            {
                File.WriteAllText("shops.txt", JsonSerializer.Serialize(new List<Shop>()));
            }
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

        private void printInfoButton_Click(object sender, EventArgs e)
        {
            List<Shop> selectedShops = checkedListBox.CheckedItems.Cast<Shop>().ToList();
            string text = "";
            foreach (Shop shop in selectedShops)
            {
                text += "=====================================\n";
                text += shop.PrintShopInfo();
            }
            File.WriteAllText("shopsInfo.txt", text);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText("shops.txt", JsonSerializer.Serialize(shops));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void infoText_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
