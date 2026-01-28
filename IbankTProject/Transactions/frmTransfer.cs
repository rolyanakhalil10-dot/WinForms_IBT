using IBTbusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBTpresentationLayer
{
    public partial class frmTransfer : Form
    {
        private int _SelectedPersonIDFrom = -1;
        private int _SelectedPersonIDTo = -1;
        private clsClients _ClientFrom;
        private clsClients _ClientTo;


        public frmTransfer()
        {
            InitializeComponent();
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _SelectedPersonIDFrom = obj;
            clsClients ClientFrom = clsClients.FindByPersonID(_SelectedPersonIDFrom);
            if (ClientFrom == null)
            {
                lblFromBalance.Text = "!!";
                btnTransfer.Enabled = false;
                if (_SelectedPersonIDFrom != -1)
                {
                    MessageBox.Show("Hey The Person is not a client!!", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                lblFromBalance.Text = ClientFrom.Balance.ToString();
                btnTransfer.Enabled = true;
            }

        }

        private void ctrlPersonCardWithFilter2_OnPersonSelected(int obj)
        {
            _SelectedPersonIDTo = obj;
            if (_SelectedPersonIDFrom == _SelectedPersonIDTo)
            {
                MessageBox.Show("You can not transfer to yourself! choose another account", "Hey", MessageBoxButtons.OK);
                btnTransfer.Enabled = false;
            }
            else
            {
                btnTransfer.Enabled = true;
                clsClients ClientTo = clsClients.FindByPersonID(_SelectedPersonIDTo);
                if (ClientTo == null)
                {
                    lblToBalance.Text = "!!";
                    btnTransfer.Enabled = false;
                    if (_SelectedPersonIDTo != -1)
                    {
                        MessageBox.Show("Hey The Person is not a client!!", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    lblToBalance.Text = ClientTo.Balance.ToString();
                    btnTransfer.Enabled = true;
                }

            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            _ClientFrom = clsClients.FindByPersonID(_SelectedPersonIDFrom); 
            _ClientTo = clsClients.FindByPersonID(_SelectedPersonIDTo);

            decimal amount;
            if (decimal.TryParse(tbAmount.Text, out amount))
            {
                try
                {
                    if (clsTransaction.Transfer(_SelectedPersonIDFrom, _SelectedPersonIDTo, amount))
                    {
                        clsTransaction.SaveTransferLog(_ClientFrom.ClientID, _ClientTo.ClientID, amount, _ClientFrom.Balance, _ClientTo.Balance, clsGlobal.CurrentUser.UserID);
                        MessageBox.Show("Transfer successful!", "Hey", MessageBoxButtons.OK);
                        clsClients CleintFrom = clsClients.FindByPersonID(_SelectedPersonIDFrom);
                        clsClients CleintTo = clsClients.FindByPersonID(_SelectedPersonIDTo);
                        lblFromBalance.Text = CleintFrom.Balance.ToString();
                        lblToBalance.Text = CleintTo.Balance.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Transfer failed.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }

        }


    }
}
