using IBTbusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBTpresentationLayer
{
    public partial class frmWithdrawDeposite : Form
    {
        private int _SelectedPersonID = -1;
        private bool _isWithdraw;
        private clsClients _Client;

        public frmWithdrawDeposite(bool isWithdraw)
        {
            InitializeComponent();
            _isWithdraw = isWithdraw;
        }

        private void lblDW_Click(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
            clsClients _Client = clsClients.FindByPersonID(_SelectedPersonID);
            if (_Client == null)
            {
                lblBalance.Text = "!!";
                btnWD.Enabled = false;
                if (_SelectedPersonID != -1)
                {
                    MessageBox.Show("Hey The Person is not a client!!", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                lblBalance.Text = _Client.Balance.ToString();
                btnWD.Enabled = true;
            }
        }

        private void _ResetDefaultValues()
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void frmWithdrawDeposite_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_isWithdraw)
            {
                lblDW.Text = "Withdraw Money";
                btnWD.Text = "Withdraw";
            }
            else
            {
                lblDW.Text = "Deposite Money";
                btnWD.Text = "deposite";
            }
        }

        private void frmWithdrawDeposite_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void btnWD_Click(object sender, EventArgs e)
        {
            _Client = clsClients.FindByPersonID(_SelectedPersonID);
            if (_isWithdraw==false)
            {
                decimal amount;
                if (decimal.TryParse(tbAmount.Text, out amount))
                {
                    if (clsTransaction.DepositByPersonID(_SelectedPersonID, amount))
                    {
                        MessageBox.Show("Deposit successful!");
                        clsClients Client = clsClients.FindByPersonID(_SelectedPersonID);
                        lblBalance.Text = Client.Balance.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Deposit failed.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid decimal amount.");
                }

            }
            else
            {
                decimal amount;
                if (decimal.TryParse(tbAmount.Text, out amount))
                {
                    if (amount >= _Client.Balance)
                    {
                        MessageBox.Show("The amount to withdraw is greater than your balance ", "Attention", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (clsTransaction.WithdrawByPersonID(_SelectedPersonID, amount))
                        {
                            MessageBox.Show("withdraw successful!");
                            clsClients Client = clsClients.FindByPersonID(_SelectedPersonID);
                            lblBalance.Text = Client.Balance.ToString();
                        }
                        else
                        {
                            MessageBox.Show("withdraw failed.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid decimal amount.");
                }

            }
        }
    }
}
