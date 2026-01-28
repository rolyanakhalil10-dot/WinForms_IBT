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
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            frmWithdrawDeposite frm = new frmWithdrawDeposite(false);
            frm.ShowDialog();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            frmWithdrawDeposite frm = new frmWithdrawDeposite(true);
            frm.ShowDialog();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmTotalBalances frm = new frmTotalBalances();
            frm.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmTransfer frm = new frmTransfer();
            frm.Show();
        }

        private void btnTransferLog_Click(object sender, EventArgs e)
        {
            frmTransferLogg frm = new frmTransferLogg();
            frm.Show();
        }
    }
}
