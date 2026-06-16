using System;
using System.Configuration;
using System.Data.SqlClient;

namespace B2
{
    public partial class _Default : System.Web.UI.Page
    {
        string cs = ConfigurationManager
            .ConnectionStrings["BankDB"]
            .ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblBalance.Text = "0";
            }
        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal amount =
                Convert.ToDecimal(txtAmount.Text);

            decimal balance =
                Convert.ToDecimal(Session["Balance"] ?? 0);

            BankAccount account =
                new BankAccount(
                    txtAccountNumber.Text,
                    balance);

            if (account.Deposit(amount))
            {
                Session["Balance"] =
                    account.ShowBalance();

                lblBalance.Text =
                    account.ShowBalance().ToString();

                lblStatus.Text =
                    "Deposit Successful";
            }
            else
            {
                lblStatus.Text =
                    "Deposit limit is 1000";
            }
        }

        protected void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal amount =
                Convert.ToDecimal(txtAmount.Text);

            decimal balance =
                Convert.ToDecimal(Session["Balance"] ?? 0);

            BankAccount account =
                new BankAccount(
                    txtAccountNumber.Text,
                    balance);

            if (account.Withdraw(amount))
            {
                Session["Balance"] =
                    account.ShowBalance();

                lblBalance.Text =
                    account.ShowBalance().ToString();

                lblStatus.Text =
                    "Withdraw Successful";
            }
            else
            {
                lblStatus.Text =
                    "Insufficient Balance";
            }
        }
    }
}
