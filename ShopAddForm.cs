using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyersAdvisor
{
    public partial class ShopAddForm : Form
    {
        Shop editedShop;
        public ShopAddForm()
        {
            InitializeComponent();
            editButton.Visible = false;
        }

        public ShopAddForm(Shop inputShop)
        {
            InitializeComponent();
            editedShop = inputShop;
            addButton.Visible = false;
            nameTextBox.Text = inputShop.Name;
            addressTextBox.Text = inputShop.Address;
            specTextBox.Text = inputShop.Specialization;
            ownershipTextBox.Text = inputShop.Ownership;
            hoursTextBox.Text = inputShop.WorkTime;
            contactsBox.Lines = inputShop.Contacts.ToArray();
            salesListBox.Items.AddRange(inputShop.Sales.Select(s => new Sale(s)).ToArray());
        }

        private void ShopAddForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ShopCollection.Instance.Add(new Shop(nameTextBox.Text, addressTextBox.Text, specTextBox.Text, ownershipTextBox.Text, hoursTextBox.Text, contactsBox.Lines.ToList(), salesListBox.Items.Cast<Sale>().ToList()));
            Close();
        }

        private void addSaleButton_Click(object sender, EventArgs e)
        {
            salesListBox.Items.Add(new Sale("Новий товар", 0, 0));
        }

        private void deleteSaleButton_Click(object sender, EventArgs e)
        {
            if (salesListBox.SelectedItem != null)
            {
                salesListBox.Items.Remove(salesListBox.SelectedItem);
            }
        }

        private void salesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saleNameTextBox.TextChanged -= parameters_TextChanged;
            saleOldPriceTextBox.TextChanged -= parameters_TextChanged;
            saleNewPriceTextBox.TextChanged -= parameters_TextChanged;
            if (salesListBox.SelectedItem != null)
            {
                Sale selectedSale = (Sale)salesListBox.SelectedItem;
                saleNameTextBox.Text = selectedSale.ProductName;
                saleOldPriceTextBox.Text = selectedSale.Price.ToString();
                saleNewPriceTextBox.Text = selectedSale.DiscountedPrice.ToString();
            }
            saleNameTextBox.TextChanged += parameters_TextChanged;
            saleOldPriceTextBox.TextChanged += parameters_TextChanged;
            saleNewPriceTextBox.TextChanged += parameters_TextChanged;
        }

        private void parameters_TextChanged(object sender, EventArgs e)
        {
            if (salesListBox.SelectedItem != null && double.TryParse(saleOldPriceTextBox.Text, out double oldPrice) && double.TryParse(saleNewPriceTextBox.Text, out double newPrice))
            {
                int selectedItemIndex = salesListBox.SelectedIndex;
                Sale sale = (Sale)salesListBox.SelectedItem;
                sale.ProductName = saleNameTextBox.Text;
                sale.Price = oldPrice;
                sale.DiscountedPrice = newPrice;
                var tempArray = new List<object>();
                foreach (var item in salesListBox.Items)
                {
                    tempArray.Add(item);
                }
                salesListBox.Items.Clear();
                salesListBox.Items.AddRange(tempArray.ToArray());
                salesListBox.SelectedIndex = selectedItemIndex;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ShopCollection.Instance.Replace(editedShop, new Shop(nameTextBox.Text, addressTextBox.Text, specTextBox.Text, ownershipTextBox.Text, hoursTextBox.Text, contactsBox.Lines.ToList(), salesListBox.Items.Cast<Sale>().ToList()));
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
