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
    public partial class frmCurrencies : Form
    {
        private static DataTable _dtAllTotalBalces = clsCurrencies.GetAllCurrencies();
        private DataTable _dtBalnces = _dtAllTotalBalces.DefaultView.ToTable(false, "CountryName", "Code", "Name",
            "Rate");

        //--CountryName, Code, Name, Rate
        public frmCurrencies()
        {
            InitializeComponent();
        }

        private void frmCurrencies_Load(object sender, EventArgs e)
        {
            dgvLoigns.DataSource = _dtBalnces;
            if (dgvLoigns.Rows.Count > 0)
            {
                dgvLoigns.Columns[0].HeaderText = "CountryName";
                dgvLoigns.Columns[0].Width = 200;

                dgvLoigns.Columns[1].HeaderText = "Code";
                dgvLoigns.Columns[1].Width = 100;


                dgvLoigns.Columns[2].HeaderText = "Name";
                dgvLoigns.Columns[2].Width = 200;

                dgvLoigns.Columns[3].HeaderText = "Rate";
                dgvLoigns.Columns[3].Width = 120;

            }
        }

        private void dgvLoigns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmCurrencyCalculator frm = new frmCurrencyCalculator();
            frm.Show();
        }
    }
}
