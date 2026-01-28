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
    public partial class frmShowClients : Form
    {

        public frmShowClients()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllClients = clsClients.GetAllClients();

        private DataTable _dtClients = _dtAllClients.DefaultView.ToTable(false, "ClientID", "PersonID", "FullName",
                                                         "Phone", "Email", "Country",
                                                         "PinCode", "Gender");

        private void _RefreshClientList()
        {
            _dtAllClients = clsClients.GetAllClients();

            _dtClients = _dtAllClients.DefaultView.ToTable(false,
                "ClientID", "PersonID", "FullName", "Phone", "Email", "Country", "PinCode", "Gender");

            dgvClients.DataSource = _dtClients;
            lblNumOfClients.Text = dgvClients.Rows.Count.ToString();

        }

        private void frmShowClients_Load(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilter.Text != "None");
            dgvClients.DataSource = _dtClients;
            lblNumOfClients.Text = dgvClients.Rows.Count.ToString();
            if (dgvClients.Rows.Count > 0)
            {
                dgvClients.Columns[0].HeaderText = "Client ID";
                dgvClients.Columns[0].Width = 100;

                dgvClients.Columns[1].HeaderText = "Person ID";
                dgvClients.Columns[1].Width = 100;

                dgvClients.Columns[2].HeaderText = "Full Name";
                dgvClients.Columns[2].Width = 150;

                dgvClients.Columns[3].HeaderText = "Phone";
                dgvClients.Columns[3].Width = 120;

                dgvClients.Columns[4].HeaderText = "Email";
                dgvClients.Columns[4].Width = 160;

                dgvClients.Columns[5].HeaderText = "Country";
                dgvClients.Columns[5].Width = 120;

                dgvClients.Columns[6].HeaderText = "Pin Code";
                dgvClients.Columns[6].Width = 100;

                dgvClients.Columns[7].HeaderText = "Gender";
                dgvClients.Columns[7].Width = 100;
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "Client ID":
                    FilterColumn = "ClientID";
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

                case "PinCode":
                    FilterColumn = "PinCode";
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
                _dtClients.DefaultView.RowFilter = "";
                lblNumOfClients.Text = dgvClients.Rows.Count.ToString(); 
                return;
            }

            if (FilterColumn == "PersonID" || FilterColumn == "ClientID")
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilter.Text.Trim());
            else
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilter.Text.Trim());

            lblNumOfClients.Text = dgvClients.Rows.Count.ToString();

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

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID" || cbFilter.Text == "Client ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete The Client [" + dgvClients.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                if (clsClients.DeleteClientByID((int)dgvClients.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshClientList();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditClient((int)dgvClients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshClientList();
        }

        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvClients.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _RefreshClientList();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditClient();
            frm.ShowDialog();
            _RefreshClientList();

        }
    }
}
