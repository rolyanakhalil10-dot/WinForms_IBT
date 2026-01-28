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
    public partial class frmTotalBalances : Form
    {
        private static DataTable _dtAllTotalBalces = clsTransaction.GetAllTotalBalnces();
        private DataTable _dtBalnces = _dtAllTotalBalces.DefaultView.ToTable(false, "ClientID", "PersonID", "FullName",
            "Balance");

        public frmTotalBalances()
        {
            InitializeComponent();
        }

        private void frmTotalBalances_Load(object sender, EventArgs e)
        {
            dgvLoigns.DataSource = _dtBalnces;
            if (dgvLoigns.Rows.Count > 0)
            {
                dgvLoigns.Columns[0].HeaderText = "Client ID";
                dgvLoigns.Columns[0].Width = 200;

                dgvLoigns.Columns[1].HeaderText = "Person ID";
                dgvLoigns.Columns[1].Width = 200;


                dgvLoigns.Columns[2].HeaderText = "FullName";
                dgvLoigns.Columns[2].Width = 300;

                dgvLoigns.Columns[3].HeaderText = "Balance";
                dgvLoigns.Columns[3].Width = 120;

            }
            lblBalance.Text = clsTransaction.CalcTotalBalances().ToString();
        }

        private void dgvLoigns_DoubleClick(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dgvLoigns.CurrentRow.Cells[1].Value);
            frm.Show();
        }
    }
}
