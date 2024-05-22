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
            shops.Add(new Shop("������", "�. �����, ���. �������, 11", "������� ����", "��������", "��������-�'������ 9:00-22:00", new List<string>() { "+380991234567", "+380991231212" }, new List<string>() { "���� �������� ������" }));
            shops.Add(new Shop("���", "�. �����, ���. ��������, 14", "����������� �������", "��������", "��������-������ ����������", new List<string>() { "+380994445566" }, new List<string>() { "������ \"������\"(-10%, ������ ����: 29 ���/��)" }));
            shops.Add(new Shop("������ 822", "�. ���, ����. ��������, 28", "������", "����������", "��� �������� 10:00-19:00", new List<string>() { "+380992556565" }, new List<string>() { "\"ѳ�����\" 200�� (-30%, ������ ����: 475 ���)", "\"����������-�����\" 100�� (-10%, ������ ����: 280 ���)" }));
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
