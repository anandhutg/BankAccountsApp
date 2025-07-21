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
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value>0)
            {
                BankAccount SelectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = SelectedBankAccount.Deposit(AmountNum.Value);

                MessageBox.Show(message);
                RefreshGrid();
                AmountNum.Value = 0;
            }
            else
            {
                MessageBox.Show("Pease select a row and enter amount..!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count==1 && AmountNum.Value>0)
            {
                BankAccount SelectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = SelectedBankAccount.Withdraw(AmountNum.Value);

                MessageBox.Show(message);
                RefreshGrid() ;
                AmountNum.Value = 0;

            }
            else
            {
                MessageBox.Show("Please select a row and enter amount ...!");
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
            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            bankAccounts.Add(bankAccount);
            BankAccountsGrid.DataSource = bankAccounts;

            MessageBox.Show("New User Added...");
            RefreshGrid();
            OwnerTxt.Text = string.Empty;
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = bankAccounts;
        }

        private void AmountNum_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
