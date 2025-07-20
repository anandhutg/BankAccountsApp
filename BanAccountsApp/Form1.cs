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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void OwnerTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            bankAccounts.Add(bankAccount);
            BankAccountsGrid.DataSource=bankAccounts;
            MessageBox.Show("New User Added...");
        }
    }
}
