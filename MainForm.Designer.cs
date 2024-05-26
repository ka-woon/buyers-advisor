namespace BuyersAdvisor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkedListBox = new CheckedListBox();
            listLabel = new Label();
            infoLabel = new Label();
            infoText = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            addShopButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            removeButton = new Button();
            editButton = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox
            // 
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(3, 3);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(379, 292);
            checkedListBox.TabIndex = 1;
            checkedListBox.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // listLabel
            // 
            listLabel.AutoSize = true;
            listLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listLabel.Location = new Point(3, 0);
            listLabel.Name = "listLabel";
            listLabel.Size = new Size(167, 25);
            listLabel.TabIndex = 2;
            listLabel.Text = "Торгівельні точки";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            infoLabel.Location = new Point(391, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(112, 25);
            infoLabel.TabIndex = 3;
            infoLabel.Text = "Інформація";
            // 
            // infoText
            // 
            infoText.AutoSize = true;
            infoText.Location = new Point(391, 32);
            infoText.Name = "infoText";
            infoText.Size = new Size(197, 15);
            infoText.TabIndex = 4;
            infoText.Text = "Інформація про торгівельну точку";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(infoText, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(listLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(infoLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.215962F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.7840347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(addShopButton);
            flowLayoutPanel2.Location = new Point(3, 397);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(382, 26);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 22);
            button1.TabIndex = 7;
            button1.Text = "Роздрукувати обрані";
            button1.UseVisualStyleBackColor = true;
            // 
            // addShopButton
            // 
            addShopButton.Location = new Point(138, 3);
            addShopButton.Name = "addShopButton";
            addShopButton.Size = new Size(162, 22);
            addShopButton.TabIndex = 6;
            addShopButton.Text = "Дотати торгівельну точку";
            addShopButton.UseVisualStyleBackColor = true;
            addShopButton.Click += addShopButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(removeButton);
            flowLayoutPanel1.Controls.Add(editButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(391, 397);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(382, 26);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeButton.Location = new Point(291, 3);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(88, 22);
            removeButton.TabIndex = 9;
            removeButton.Text = "Видалити";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editButton.Location = new Point(197, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(88, 22);
            editButton.TabIndex = 10;
            editButton.Text = "Редагувати";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(checkedListBox);
            flowLayoutPanel3.Controls.Add(searchLabel);
            flowLayoutPanel3.Controls.Add(searchTextBox);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 35);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(382, 356);
            flowLayoutPanel3.TabIndex = 11;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(3, 298);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(177, 15);
            searchLabel.TabIndex = 11;
            searchLabel.Text = "Пошук за тегами (через кому) ";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(3, 316);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(379, 23);
            searchTextBox.TabIndex = 12;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 451);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(815, 490);
            MinimumSize = new Size(815, 490);
            Name = "MainForm";
            Text = " ";
            FormClosed += MainForm_FormClosed;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox;
        private Label listLabel;
        private Label infoLabel;
        private Label infoText;
        private TableLayoutPanel tableLayoutPanel1;
        private Button addShopButton;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button removeButton;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label searchLabel;
        private TextBox searchTextBox;
        private Button editButton;
    }
}
