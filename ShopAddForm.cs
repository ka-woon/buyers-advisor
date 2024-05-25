using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyersAdvisor
{
    public partial class ShopAddForm : Form
    {
        public ShopAddForm()
        {
            InitializeComponent();
        }

        private void ShopAddForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ShopCollection.Instance.Add(new Shop(nameTextBox.Text, adressTextBox.Text, specTextBox.Text, ownershipTextBox.Text, hoursTextBox.Text, contactsBox.Lines.ToList<string>(), salesListBox.Items.Cast<Sale>().ToList()));
            Close();
        }

        private void addSaleButton_Click(object sender, EventArgs e)
        {
            salesListBox.Items.Add(new Sale(saleNameTextBox.Text, double.Parse(saleOldPriceTextBox.Text), double.Parse(saleNewPriceTextBox.Text)));
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
            if(salesListBox.SelectedItem != null)
            {
                Sale selectedSale = (Sale)salesListBox.SelectedItem;
                saleNameTextBox.Text = selectedSale.productName;
                saleOldPriceTextBox.Text = selectedSale.price.ToString();
                saleNewPriceTextBox.Text = selectedSale.discountedPrice.ToString();
            }
        }
        private void parameters_TextChanged(object sender, EventArgs e)
        {
            if (salesListBox.SelectedItem != null)
            {
                salesListBox.SelectedItem = new Sale(saleNameTextBox.Text, double.Parse(saleOldPriceTextBox.Text), double.Parse(saleNewPriceTextBox.Text));
            }
        }
    }
}
