using System.Diagnostics;
using System.Text.Json;

namespace BuyersAdvisor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("shops.txt"))
            {
                ShopCollection.Instance = JsonSerializer.Deserialize<ShopCollection>(File.ReadAllText("shops.txt"));
            }
            else
            {
                File.WriteAllText("shops.txt", JsonSerializer.Serialize(ShopCollection.Instance));
            }
            checkedListBox.Items.AddRange(ShopCollection.Instance.GetShopList().ToArray<Shop>());
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkedListBox.SelectedItem != null)
            {
                Shop selectedShop = (Shop)checkedListBox.SelectedItem;
                infoText.Text = selectedShop.PrintShopInfo();
            }
        }

        private void printInfoButton_Click(object sender, EventArgs e)
        {
            ShopCollection checkedShops = new ShopCollection(checkedListBox.CheckedItems.Cast<Shop>().ToList());
            File.WriteAllText("shopsInfo.txt", checkedShops.ToString());
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText("shops.txt", JsonSerializer.Serialize(ShopCollection.Instance));
        }

        private void addShopButton_Click(object sender, EventArgs e)
        {
            ShopAddForm shopAddForm = new ShopAddForm();
            shopAddForm.ShowDialog();
        }
    }
}
