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
    public partial class frmTransferLogg : Form
    {
        private static DataTable _dtAllLoginHistory = clsTransaction.GetAllTransferLogs();
        private DataTable _dtLogins = _dtAllLoginHistory.DefaultView.ToTable(false, "TransferID", "SenderFullName", "ReceiverFullName",
            "Amount", "TransferDate");

        public frmTransferLogg()
        {
            InitializeComponent();
        }
        private void _RefreshLoginList()
        {
            _dtAllLoginHistory = clsTransaction.GetAllTransferLogs();

            _dtLogins = _dtAllLoginHistory.DefaultView.ToTable(false, "TransferID", "SenderFullName", "ReceiverFullName",
            "Amount", "TransferDate");

            dgvLoigns.DataSource = _dtLogins;
            lblNumOfClients.Text = dgvLoigns.Rows.Count.ToString();

        }

        private void frmTransferLogg_Load(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilter.Text != "None");
            dtpLogin.Visible = false;
            dgvLoigns.DataSource = _dtLogins;
            lblNumOfClients.Text = dgvLoigns.Rows.Count.ToString();
            if (dgvLoigns.Rows.Count > 0)
            {
                dgvLoigns.Columns[0].HeaderText = "Transfer ID";
                dgvLoigns.Columns[0].Width = 100;

                dgvLoigns.Columns[1].HeaderText = "Sender FullName";
                dgvLoigns.Columns[1].Width = 100;

                dgvLoigns.Columns[2].HeaderText = "Receiver FullName";
                dgvLoigns.Columns[2].Width = 120;

                dgvLoigns.Columns[3].HeaderText = "Amount";
                dgvLoigns.Columns[3].Width = 100;

                dgvLoigns.Columns[4].HeaderText = "Transfer Date";
                dgvLoigns.Columns[4].Width = 150;

            }


        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "Transfer Date")
            {
                tbFilter.Visible = false;
                dtpLogin.Visible = true;
                dtpLogin.Focus();
            }
            else
            {
                tbFilter.Visible = (cbFilter.Text != "None");
                dtpLogin.Visible = false;
                if (tbFilter.Visible)
                {
                    tbFilter.Text = "";
                    tbFilter.Focus();
                }

            }

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Transfer ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void tbFilter_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "Transfer ID":
                    FilterColumn = "TransferID";
                    break;

                case "Sender FullName":
                    FilterColumn = "SenderFullName";
                    break;

                case "Receiver FullName":
                    FilterColumn = "ReceiverFullName";
                    break;

                case "Amount":
                    FilterColumn = "Amount";
                    break;

                case "Transfer Date":
                    FilterColumn = "TransferDate";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (tbFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtLogins.DefaultView.RowFilter = "";
                lblNumOfClients.Text = dgvLoigns.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "TransferID")
                _dtLogins.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilter.Text.Trim());
            else
                _dtLogins.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilter.Text.Trim());

            lblNumOfClients.Text = dgvLoigns.Rows.Count.ToString();

        }

        private void dtpLogin_ValueChanged(object sender, EventArgs e)
        {
            string FilterColumn = "TransferDate";
            DateTime selectedDate = dtpLogin.Value.Date;

            DateTime start = selectedDate;
            DateTime end = selectedDate.AddDays(1);

            string filter = string.Format("{0} >= #{1:MM/dd/yyyy}# AND {0} < #{2:MM/dd/yyyy}#",
                                          FilterColumn, start, end);

            _dtLogins.DefaultView.RowFilter = filter;

            lblNumOfClients.Text = dgvLoigns.Rows.Count.ToString();

        }
    }
}
