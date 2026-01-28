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
using System.Xml.Linq;

namespace IBTpresentationLayer
{
    public partial class frmLoginHistory : Form
    {
        private static DataTable _dtAllLoginHistory = clsUserLogins.GetAllLoginHistory();

        private DataTable _dtLogins = _dtAllLoginHistory.DefaultView.ToTable(false, "UserID", "PersonID", "LoginDateTime",
            "FullName", "Country", "Gender");

        public frmLoginHistory()
        {
            InitializeComponent();
        }
        private void _RefreshLoginList()
        {
            _dtAllLoginHistory = clsUserLogins.GetAllLoginHistory();

            _dtLogins = _dtAllLoginHistory.DefaultView.ToTable(false, "UserID", "PersonID", "LoginDateTime",
            "FullName", "Country", "Gender");

            dgvLoigns.DataSource = _dtLogins;
            lblNumOfClients.Text = dgvLoigns.Rows.Count.ToString();

        }

        private void frmLoginHistory_Load(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilter.Text != "None");
            dtpLogin.Visible = false;
            dgvLoigns.DataSource = _dtLogins;
            lblNumOfClients.Text = dgvLoigns.Rows.Count.ToString();
            if (dgvLoigns.Rows.Count > 0)
            {
                dgvLoigns.Columns[0].HeaderText = "User ID";
                dgvLoigns.Columns[0].Width = 100;

                dgvLoigns.Columns[1].HeaderText = "Person ID";
                dgvLoigns.Columns[1].Width = 100;

                dgvLoigns.Columns[2].HeaderText = "Login Date/Time";
                dgvLoigns.Columns[2].Width = 120;

                dgvLoigns.Columns[3].HeaderText = "Full Name";
                dgvLoigns.Columns[3].Width = 150;

                dgvLoigns.Columns[4].HeaderText = "Country";
                dgvLoigns.Columns[4].Width = 120;

                dgvLoigns.Columns[5].HeaderText = "Gender";
                dgvLoigns.Columns[5].Width = 100;
            }


        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "Login Date/Time")
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

        private void tbFilter_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID" || cbFilter.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void dgvLoigns_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvLoigns.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _RefreshLoginList();

        }

        private void lblNumOfClients_Click(object sender, EventArgs e)
        {

        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Login Date/Time":
                    FilterColumn = "LoginDateTime";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Country":
                    FilterColumn = "Country";
                    break;

                case "Gender":
                    FilterColumn = "Gender";
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

            if (FilterColumn == "PersonID" || FilterColumn == "UserID")
                _dtLogins.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilter.Text.Trim());
            else
                _dtLogins.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilter.Text.Trim());

            lblNumOfClients.Text = dgvLoigns.Rows.Count.ToString();


        }

        private void dtpLogin_ValueChanged(object sender, EventArgs e)
        {
            string FilterColumn = "LoginDateTime";
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
