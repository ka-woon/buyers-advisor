namespace BuyersAdvisor
{
    partial class Form1
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
            printInfoButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox
            // 
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(3, 35);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(382, 346);
            checkedListBox.TabIndex = 1;
            checkedListBox.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // listLabel
            // 
            listLabel.AutoSize = true;
            listLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listLabel.Location = new Point(3, 0);
            listLabel.Name = "listLabel";
            listLabel.Size = new Size(63, 25);
            listLabel.TabIndex = 2;
            listLabel.Text = "Shops";
            listLabel.Click += label1_Click;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            infoLabel.Location = new Point(391, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(45, 25);
            infoLabel.TabIndex = 3;
            infoLabel.Text = "Info";
            // 
            // infoText
            // 
            infoText.AutoSize = true;
            infoText.Location = new Point(391, 32);
            infoText.Name = "infoText";
            infoText.Size = new Size(54, 15);
            infoText.TabIndex = 4;
            infoText.Text = "shopinfo";
            infoText.Click += infoText_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(printInfoButton, 0, 2);
            tableLayoutPanel1.Controls.Add(infoText, 1, 1);
            tableLayoutPanel1.Controls.Add(checkedListBox, 0, 1);
            tableLayoutPanel1.Controls.Add(listLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(infoLabel, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.215962F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.7840347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // printInfoButton
            // 
            printInfoButton.Location = new Point(3, 399);
            printInfoButton.Name = "printInfoButton";
            printInfoButton.Size = new Size(81, 23);
            printInfoButton.TabIndex = 6;
            printInfoButton.Text = "Print All Info";
            printInfoButton.UseVisualStyleBackColor = true;
            printInfoButton.Click += printInfoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 451);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(815, 490);
            MinimumSize = new Size(815, 490);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox;
        private Label listLabel;
        private Label infoLabel;
        private Label infoText;
        private TableLayoutPanel tableLayoutPanel1;
        private Button printInfoButton;
    }
}
