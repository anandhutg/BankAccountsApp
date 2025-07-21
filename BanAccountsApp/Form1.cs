using System.Drawing.Text;

namespace BanAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount SelectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = SelectedBankAccount.Deposit(AmountNum.Value);


                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Pease select a row and enter valid amount..!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount SelectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = SelectedBankAccount.Withdraw(AmountNum.Value);

                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);

            }
            else
            {
                MessageBox.Show("Please select a row and enter valid amount ...!");
            }
        }

        private void OwnerTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;
            if (InterestNum.Value>0)
            {
                SavingsAccount savingsAccount = new SavingsAccount(OwnerTxt.Text,InterestNum.Value);
                bankAccounts.Add(savingsAccount);
            }
            else
            {
                BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
                bankAccounts.Add(bankAccount);
            }
            BankAccountsGrid.DataSource = bankAccounts;
            RefreshGrid();
            OwnerTxt.Text = string.Empty;
            InterestNum.Value = 0;
            MessageBox.Show("New User Added...");
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = bankAccounts;
        }

        private void AmountNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
