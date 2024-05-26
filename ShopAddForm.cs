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
        Shop? editedShop;

        public ShopAddForm()
        {
            InitializeComponent();
            editButton.Visible = false;
        }

        public ShopAddForm(Shop editedShop)
        {
            InitializeComponent();
            addButton.Visible = false;
            this.editedShop = new Shop(editedShop);
            nameTextBox.Text = editedShop.Name;
            addressTextBox.Text = editedShop.Address;
            specTextBox.Text = editedShop.Specialization;
            ownershipTextBox.Text = editedShop.Ownership;
            hoursTextBox.Text = editedShop.WorkTime;
            contactsBox.Lines = editedShop.Contacts.ToArray();
            salesListBox.Items.AddRange(editedShop.Sales.Select(s => new Sale(s)).ToArray());
        }

        private void ShopAddForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ShopCollection.Instance.Add(new Shop(nameTextBox.Text, addressTextBox.Text, specTextBox.Text, ownershipTextBox.Text, hoursTextBox.Text, contactsBox.Lines.ToList<string>(), salesListBox.Items.Cast<Sale>().ToList()));
            Close();
        }

        private void addSaleButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(saleOldPriceTextBox.Text, out double oldPrice) && double.TryParse(saleNewPriceTextBox.Text, out double newPrice))
            {
                salesListBox.Items.Add(new Sale(saleNameTextBox.Text, oldPrice, newPrice));
            }
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
            if (salesListBox.SelectedItem != null)
            {
                Sale selectedSale = (Sale)salesListBox.SelectedItem;
                saleNameTextBox.Text = selectedSale.ProductName;
                saleOldPriceTextBox.Text = selectedSale.Price.ToString();
                saleNewPriceTextBox.Text = selectedSale.DiscountedPrice.ToString();
            }
        }

        private void parameters_TextChanged(object sender, EventArgs e)
        {
            if (salesListBox.SelectedItem != null && double.TryParse(saleOldPriceTextBox.Text, out double oldPrice) && double.TryParse(saleNewPriceTextBox.Text, out double newPrice))
            {
                Sale sale = (Sale)salesListBox.SelectedItem;
                sale.ProductName = saleNameTextBox.Text;
                sale.Price = oldPrice;
                sale.DiscountedPrice = newPrice;
                salesListBox.Invalidate();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
