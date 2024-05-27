using System.Diagnostics;
using System.Text.Json;

namespace BuyersAdvisor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShopCollection.Instance.OnListChanged += updateListBoxContent;
            ShopCollection.Instance.OnListChanged += updateInfoText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("shops.txt"))
            {
                ShopCollection.Instance.Shops = JsonSerializer.Deserialize<List<Shop>>(File.ReadAllText("shops.txt"));
            }
            else
            {
                File.WriteAllText("shops.txt", JsonSerializer.Serialize(ShopCollection.Instance));
            }
            checkedListBox.Items.AddRange(ShopCollection.Instance.GetShopList().ToArray<Shop>());
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateInfoText();
        }

        private void printInfoButton_Click(object sender, EventArgs e)
        {
            if (checkedListBox.CheckedItems.Count > 0)
            {
                ShopCollection checkedShops = new ShopCollection(checkedListBox.CheckedItems.Cast<Shop>().ToList());
                File.WriteAllText("shopsInfo.txt", checkedShops.ToString());
            }
            else
            {
                MessageBox.Show("Жодну торгівельну точку не обрано.", "Помилка");
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText("shops.txt", JsonSerializer.Serialize(ShopCollection.Instance.Shops));
        }

        private void addShopButton_Click(object sender, EventArgs e)
        {
            ShopEditor shopEditor = new ShopEditor();
            shopEditor.ShowDialog();
        }
        private void updateListBoxContent()
        {
            checkedListBox.Items.Clear();
            checkedListBox.Items.AddRange(ShopCollection.Instance.GetShopList().ToArray<Shop>());
        }
        private void updateListBoxSearhedContent()
        {
            checkedListBox.Items.Clear();
            checkedListBox.Items.AddRange(ShopCollection.Instance.SearchByTags(SearchQueryProcessor.MakeTags(searchTextBox.Text)).ToArray<Shop>());
        }
        private void updateInfoText()
        {
            if (checkedListBox.SelectedItem != null)
            {
                Shop selectedShop = (Shop)checkedListBox.SelectedItem;
                infoText.Text = selectedShop.PrintShopInfo();
            }
            else
            {
                infoText.Text = "Інформація про торгівельну точку";
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (checkedListBox.SelectedItem != null)
            {
                ShopEditor shopEditor = new ShopEditor((Shop)checkedListBox.SelectedItem);
                shopEditor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Торгівельну точку не обрано.", "Помилка");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (checkedListBox.SelectedItem != null)
            {
                Shop selectedShop = (Shop)checkedListBox.SelectedItem;
                ShopCollection.Instance.Remove(selectedShop);
            }
            else
            {
                MessageBox.Show("Торгівельну точку не обрано.", "Помилка");
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                updateListBoxContent();
            }
            else
            {
                updateListBoxSearhedContent();
            }
        }
    }
}
