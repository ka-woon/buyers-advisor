﻿namespace BuyersAdvisor
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
            panel1 = new Panel();
            editButton = new Button();
            addButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            adressLabel = new Label();
            addressTextBox = new TextBox();
            specLabel = new Label();
            specTextBox = new TextBox();
            ownershipLabel = new Label();
            ownershipTextBox = new TextBox();
            workTimeLabel = new Label();
            hoursTextBox = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            contactsLabel = new Label();
            contactsBox = new RichTextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            salesLabel = new Label();
            salesListBox = new ListBox();
            label1 = new Label();
            saleNameTextBox = new TextBox();
            label2 = new Label();
            saleOldPriceTextBox = new TextBox();
            label3 = new Label();
            saleNewPriceTextBox = new TextBox();
            deleteSaleButton = new Button();
            addSaleButton = new Button();
            panel2 = new Panel();
            cancelButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.9090919F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.0909081F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 332F));
            tableLayoutPanel1.Controls.Add(panel1, 2, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.7840347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.215962F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(addButton);
            panel1.Location = new Point(446, 394);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 29);
            panel1.TabIndex = 1;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.Location = new Point(249, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 14;
            editButton.Text = "Ок";
            editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.Location = new Point(249, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 12;
            addButton.Text = "Ок";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(nameLabel);
            flowLayoutPanel1.Controls.Add(nameTextBox);
            flowLayoutPanel1.Controls.Add(adressLabel);
            flowLayoutPanel1.Controls.Add(addressTextBox);
            flowLayoutPanel1.Controls.Add(specLabel);
            flowLayoutPanel1.Controls.Add(specTextBox);
            flowLayoutPanel1.Controls.Add(ownershipLabel);
            flowLayoutPanel1.Controls.Add(ownershipTextBox);
            flowLayoutPanel1.Controls.Add(workTimeLabel);
            flowLayoutPanel1.Controls.Add(hoursTextBox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(175, 385);
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
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(3, 82);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(100, 23);
            addressTextBox.TabIndex = 3;
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
            // specTextBox
            // 
            specTextBox.Location = new Point(3, 136);
            specTextBox.Name = "specTextBox";
            specTextBox.Size = new Size(100, 23);
            specTextBox.TabIndex = 5;
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
            // 
            // ownershipTextBox
            // 
            ownershipTextBox.Location = new Point(3, 190);
            ownershipTextBox.Name = "ownershipTextBox";
            ownershipTextBox.Size = new Size(100, 23);
            ownershipTextBox.TabIndex = 7;
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
            // hoursTextBox
            // 
            hoursTextBox.Location = new Point(3, 244);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(100, 23);
            hoursTextBox.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(contactsLabel);
            flowLayoutPanel2.Controls.Add(contactsBox);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(184, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(256, 385);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // contactsLabel
            // 
            contactsLabel.AutoSize = true;
            contactsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contactsLabel.Location = new Point(3, 0);
            contactsLabel.Name = "contactsLabel";
            contactsLabel.RightToLeft = RightToLeft.Yes;
            contactsLabel.Size = new Size(239, 25);
            contactsLabel.TabIndex = 2;
            contactsLabel.Text = "Контакти (один на строку)";
            // 
            // contactsBox
            // 
            contactsBox.Location = new Point(3, 28);
            contactsBox.Name = "contactsBox";
            contactsBox.Size = new Size(253, 348);
            contactsBox.TabIndex = 3;
            contactsBox.Text = "";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(salesLabel);
            flowLayoutPanel3.Controls.Add(salesListBox);
            flowLayoutPanel3.Controls.Add(label1);
            flowLayoutPanel3.Controls.Add(saleNameTextBox);
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(saleOldPriceTextBox);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(saleNewPriceTextBox);
            flowLayoutPanel3.Controls.Add(deleteSaleButton);
            flowLayoutPanel3.Controls.Add(addSaleButton);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(446, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(327, 385);
            flowLayoutPanel3.TabIndex = 11;
            // 
            // salesLabel
            // 
            salesLabel.AutoSize = true;
            salesLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            salesLabel.Location = new Point(3, 0);
            salesLabel.Name = "salesLabel";
            salesLabel.RightToLeft = RightToLeft.Yes;
            salesLabel.Size = new Size(142, 25);
            salesLabel.TabIndex = 2;
            salesLabel.Text = "Акційні товари";
            // 
            // salesListBox
            // 
            salesListBox.FormattingEnabled = true;
            salesListBox.ItemHeight = 15;
            salesListBox.Location = new Point(3, 28);
            salesListBox.Name = "salesListBox";
            salesListBox.Size = new Size(327, 124);
            salesListBox.TabIndex = 3;
            salesListBox.SelectedIndexChanged += salesListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 155);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(127, 25);
            label1.TabIndex = 4;
            label1.Text = "Назва товару";
            // 
            // saleNameTextBox
            // 
            saleNameTextBox.Location = new Point(3, 183);
            saleNameTextBox.Name = "saleNameTextBox";
            saleNameTextBox.Size = new Size(100, 23);
            saleNameTextBox.TabIndex = 5;
            saleNameTextBox.TextChanged += parameters_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 209);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(151, 25);
            label2.TabIndex = 6;
            label2.Text = "Стара ціна (грн)";
            // 
            // saleOldPriceTextBox
            // 
            saleOldPriceTextBox.Location = new Point(3, 237);
            saleOldPriceTextBox.Name = "saleOldPriceTextBox";
            saleOldPriceTextBox.Size = new Size(100, 23);
            saleOldPriceTextBox.TabIndex = 7;
            saleOldPriceTextBox.TextChanged += parameters_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 263);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(144, 25);
            label3.TabIndex = 8;
            label3.Text = "Нова ціна (грн)";
            // 
            // saleNewPriceTextBox
            // 
            saleNewPriceTextBox.Location = new Point(3, 291);
            saleNewPriceTextBox.Name = "saleNewPriceTextBox";
            saleNewPriceTextBox.Size = new Size(100, 23);
            saleNewPriceTextBox.TabIndex = 9;
            saleNewPriceTextBox.TextChanged += parameters_TextChanged;
            // 
            // deleteSaleButton
            // 
            deleteSaleButton.Location = new Point(3, 320);
            deleteSaleButton.Name = "deleteSaleButton";
            deleteSaleButton.Size = new Size(112, 23);
            deleteSaleButton.TabIndex = 11;
            deleteSaleButton.Text = "Видалити товар";
            deleteSaleButton.UseVisualStyleBackColor = true;
            deleteSaleButton.Click += deleteSaleButton_Click;
            // 
            // addSaleButton
            // 
            addSaleButton.Location = new Point(3, 349);
            addSaleButton.Name = "addSaleButton";
            addSaleButton.Size = new Size(112, 23);
            addSaleButton.TabIndex = 12;
            addSaleButton.Text = "Додати товар";
            addSaleButton.UseVisualStyleBackColor = true;
            addSaleButton.Click += addSaleButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cancelButton);
            panel2.Location = new Point(3, 394);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 29);
            panel2.TabIndex = 14;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancelButton.Location = new Point(3, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Відміна";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // ShopAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ShopAddForm";
            Text = "ShopAddForm";
            Load += ShopAddForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label adressLabel;
        private TextBox addressTextBox;
        private Label specLabel;
        private TextBox specTextBox;
        private Label ownershipLabel;
        private TextBox ownershipTextBox;
        private Label workTimeLabel;
        private TextBox hoursTextBox;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label contactsLabel;
        private RichTextBox contactsBox;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label salesLabel;
        private ListBox salesListBox;
        private Label label1;
        private TextBox saleNameTextBox;
        private Label label2;
        private TextBox saleOldPriceTextBox;
        private Label label3;
        private TextBox saleNewPriceTextBox;
        private Button deleteSaleButton;
        private Button addSaleButton;
        private Button addButton;
        private Button cancelButton;
        private Panel panel1;
        private Button editButton;
        private Panel panel2;
    }
}