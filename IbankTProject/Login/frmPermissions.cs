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
    public partial class frmPermissions : Form
    {
        private int _SelectedPersonID = -1;

        public enum enPermissions
        {
            eAll = -1, pManageClients = 1, pTransactions = 2, pManageUsers = 4,
            pCurrency = 8, pManagePermissions = 16, pAccountSettings = 32
        };

        private int _UserPermission = 0;

        public enPermissions UserPermissions { get; set; } = enPermissions.eAll;

        public frmPermissions()
        {
            InitializeComponent();
        }


        private void _ResetDefaultValues()
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }
        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
        }

        private void frmPermissions_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
        }

        private void frmPermissions_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!clsUsers.DoesUserExistByPersonID(ctrlPersonCardWithFilter1.PersonID))
            {
                MessageBox.Show("The Person is not a User please Add A New User.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                tcUsers.SelectedTab = tcUsers.TabPages["tpPermissions"];

            }
        }

        private void cbFullPermission_Click(object sender, EventArgs e)
        {
            if (cbFullPermission.Checked)
            {
                cbManageClients.Checked = true;
                cbManageUsers.Checked = true;
                cbShowLoginRegistry.Checked = true;
                cbManagePermissions.Checked = true;
                cbAccountSettings.Checked = true;
                cbCurrency.Checked = true;
                cbTransactions.Checked = true;
            }
            if (cbFullPermission.Checked == false)
            {
                cbManageClients.Checked = false;
                cbManageUsers.Checked = false;
                cbShowLoginRegistry.Checked = false;
                cbManagePermissions.Checked = false;
                cbAccountSettings.Checked = false;
                cbCurrency.Checked = false;
                cbTransactions.Checked = false;
            }
        }

        private int _CalculatePermission()
        {
            enPermissions permissions = 0;

            if (cbManageClients.Checked)
                permissions |= enPermissions.pManageClients;

            if (cbTransactions.Checked)
                permissions |= enPermissions.pTransactions;

            if (cbManageUsers.Checked)
                permissions = permissions| enPermissions.pManageUsers;

            if (cbCurrency.Checked)
                permissions |= enPermissions.pCurrency;

            if (cbManagePermissions.Checked)
                permissions |= enPermissions.pManagePermissions;

            if (cbAccountSettings.Checked)
                permissions |= enPermissions.pAccountSettings;

            if (cbFullPermission.Checked)
                permissions = enPermissions.eAll;

            UserPermissions = permissions;
            return (int)UserPermissions;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsUsers.UpdateUserPermissions(ctrlPersonCardWithFilter1.PersonID, _CalculatePermission()))
            {
                MessageBox.Show("The Permissions is saved.", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Failed", "Success", MessageBoxButtons.OK);
            }
        }
    }
}
