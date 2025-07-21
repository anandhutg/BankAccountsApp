namespace BanAccountsApp
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
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositBtn = new Button();
            button2 = new Button();
            CreateAccountBtn = new Button();
            IntrestLabel = new Label();
            InterestNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 0;
            label1.Text = "Owner :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 461);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 1;
            label2.Text = "Amount :";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(159, 60);
            OwnerTxt.Margin = new Padding(2, 3, 2, 3);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(292, 39);
            OwnerTxt.TabIndex = 3;
            OwnerTxt.TextChanged += OwnerTxt_TextChanged;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(159, 461);
            AmountNum.Margin = new Padding(2, 3, 2, 3);
            AmountNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(226, 39);
            AmountNum.TabIndex = 4;
            AmountNum.ValueChanged += AmountNum_ValueChanged;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(481, 60);
            BankAccountsGrid.Margin = new Padding(2, 3, 2, 3);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 62;
            BankAccountsGrid.Size = new Size(515, 343);
            BankAccountsGrid.TabIndex = 5;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(620, 464);
            DepositBtn.Margin = new Padding(2, 3, 2, 3);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(150, 38);
            DepositBtn.TabIndex = 6;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(846, 464);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(150, 36);
            button2.TabIndex = 7;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(133, 193);
            CreateAccountBtn.Margin = new Padding(2, 3, 2, 3);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(318, 38);
            CreateAccountBtn.TabIndex = 8;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // IntrestLabel
            // 
            IntrestLabel.AutoSize = true;
            IntrestLabel.Location = new Point(34, 129);
            IntrestLabel.Name = "IntrestLabel";
            IntrestLabel.Size = new Size(194, 32);
            IntrestLabel.TabIndex = 9;
            IntrestLabel.Text = "Interest Rate (%):";
            IntrestLabel.Click += label3_Click;
            // 
            // InterestNum
            // 
            InterestNum.Location = new Point(269, 129);
            InterestNum.Name = "InterestNum";
            InterestNum.Size = new Size(131, 39);
            InterestNum.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(InterestNum);
            Controls.Add(IntrestLabel);
            Controls.Add(CreateAccountBtn);
            Controls.Add(button2);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositBtn;
        private Button button2;
        private Button CreateAccountBtn;
        private Label IntrestLabel;
        private NumericUpDown InterestNum;
    }
}
