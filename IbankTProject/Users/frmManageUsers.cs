using IBTbusinessLogicLayer;
using IBTdataAcessLayer;
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
    public partial class frmManageUsers : Form
    {
        private static DataTable _dtAllUsers = clsUsers.GetAllUsers();

        private DataTable _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID", "UserName", "FullName",
                                                         "Phone", "Email", "Country", "Gender");

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void _RefreshClientList()
        {
            _dtAllUsers = clsUsers.GetAllUsers();

            _dtUsers = _dtAllUsers.DefaultView.ToTable(false,
               "UserID", "PersonID", "UserName", "FullName",
                                "Phone", "Email", "Country", "Gender");

            dgvUsers.DataSource = _dtUsers;
            lblNumOfClients.Text = dgvUsers.Rows.Count.ToString();

        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilter.Text != "None");
            
            dgvUsers.DataSource = _dtUsers;
            lblNumOfClients.Text = dgvUsers.Rows.Count.ToString();
            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 100;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 100;

                dgvUsers.Columns[2].HeaderText = "User Name";
                dgvUsers.Columns[2].Width = 100;

                dgvUsers.Columns[3].HeaderText = "Full Name";
                dgvUsers.Columns[3].Width = 150;

                dgvUsers.Columns[4].HeaderText = "Phone";
                dgvUsers.Columns[4].Width = 120;

                dgvUsers.Columns[5].HeaderText = "Email";
                dgvUsers.Columns[5].Width = 160;

                dgvUsers.Columns[6].HeaderText = "Country";
                dgvUsers.Columns[6].Width = 120;

                dgvUsers.Columns[7].HeaderText = "Gender";
                dgvUsers.Columns[7].Width = 100;
            }

        }

        private void tbFilter_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilter.Text != "None");

            if (tbFilter.Visible)
            {
                tbFilter.Text = "";
                tbFilter.Focus();
            }

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

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                case "Country":
                    FilterColumn = "Country";
                    break;

                case "User Name":
                    FilterColumn = "UserName";
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
                _dtUsers.DefaultView.RowFilter = "";
                lblNumOfClients.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID" || FilterColumn == "UserID")
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilter.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilter.Text.Trim());

            lblNumOfClients.Text = dgvUsers.Rows.Count.ToString();

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID" || cbFilter.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete The Client [" + dgvUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                if (clsUsers.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshClientList();
                }

                else
                    MessageBox.Show("User was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvUsers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _RefreshClientList();
        }

        private void btnAddUSre_Click(object sender, EventArgs e)
        {
            frmAddEditUsers frm = new frmAddEditUsers();
            frm.ShowDialog();
            _RefreshClientList();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditUsers((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshClientList();

        }
    }
}
