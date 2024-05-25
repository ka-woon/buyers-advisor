namespace BuyersAdvisor
{
    partial class ShopAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            adressLabel = new Label();
            textBox1 = new TextBox();
            specLabel = new Label();
            textBox2 = new TextBox();
            ownershipLabel = new Label();
            textBox3 = new TextBox();
            workTimeLabel = new Label();
            textBox4 = new TextBox();
            listBox1 = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(listBox1, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.7840347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.215962F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(nameLabel);
            flowLayoutPanel1.Controls.Add(nameTextBox);
            flowLayoutPanel1.Controls.Add(adressLabel);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(specLabel);
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Controls.Add(ownershipLabel);
            flowLayoutPanel1.Controls.Add(textBox3);
            flowLayoutPanel1.Controls.Add(workTimeLabel);
            flowLayoutPanel1.Controls.Add(textBox4);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(382, 385);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.RightToLeft = RightToLeft.Yes;
            nameLabel.Size = new Size(63, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Назва";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(3, 28);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 1;
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            adressLabel.Location = new Point(3, 54);
            adressLabel.Name = "adressLabel";
            adressLabel.RightToLeft = RightToLeft.Yes;
            adressLabel.Size = new Size(74, 25);
            adressLabel.TabIndex = 2;
            adressLabel.Text = "Адреса";
            adressLabel.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // specLabel
            // 
            specLabel.AutoSize = true;
            specLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            specLabel.Location = new Point(3, 108);
            specLabel.Name = "specLabel";
            specLabel.RightToLeft = RightToLeft.Yes;
            specLabel.Size = new Size(130, 25);
            specLabel.TabIndex = 4;
            specLabel.Text = "Спеціалізація";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // ownershipLabel
            // 
            ownershipLabel.AutoSize = true;
            ownershipLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ownershipLabel.Location = new Point(3, 162);
            ownershipLabel.Name = "ownershipLabel";
            ownershipLabel.RightToLeft = RightToLeft.Yes;
            ownershipLabel.Size = new Size(159, 25);
            ownershipLabel.TabIndex = 6;
            ownershipLabel.Text = "Форма власності";
            ownershipLabel.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // workTimeLabel
            // 
            workTimeLabel.AutoSize = true;
            workTimeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            workTimeLabel.Location = new Point(3, 216);
            workTimeLabel.Name = "workTimeLabel";
            workTimeLabel.RightToLeft = RightToLeft.Yes;
            workTimeLabel.Size = new Size(124, 25);
            workTimeLabel.TabIndex = 8;
            workTimeLabel.Text = "Робочий час";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 244);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(391, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 1;
            // 
            // ShopAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ShopAddForm";
            Text = "ShopAddForm";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label adressLabel;
        private TextBox textBox1;
        private Label specLabel;
        private TextBox textBox2;
        private Label ownershipLabel;
        private TextBox textBox3;
        private Label workTimeLabel;
        private TextBox textBox4;
        private ListBox listBox1;
    }
}