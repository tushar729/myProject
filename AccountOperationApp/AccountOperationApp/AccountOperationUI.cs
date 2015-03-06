using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountOperationUI : Form
    {
        Account aAccount = new Account();
        public AccountOperationUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aAccount.AccountNumber = accountNumberTextBox.Text;
            aAccount.CustomerName = customerNameTextBox.Text;
            aAccount.Balance = 0.0M;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string report = aAccount.Report();
            MessageBox.Show(report);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            aAccount.Deposit(decimal.Parse(amountTextBox.Text));
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            aAccount.Withdraw(decimal.Parse(amountTextBox.Text));
        }
    }
}
