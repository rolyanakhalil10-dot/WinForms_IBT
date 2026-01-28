using IBTbusinessLogicLayer;
using IBTpresentationLayer.Properties;
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
    public partial class frmMain : Form
    {
        private frmLogin _frmLogin;
        private clsUsers _User;

        public frmMain(frmLogin frm, clsUsers User)
        {
            InitializeComponent();
            _frmLogin = frm;
            _User = User;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            clsUsers User2 = clsUsers.Find(_User.UserID);
            lblUserName.Text = User2.FullName;
            container(new frmDashboard());

            if (User2.ImagePath == null)
            {
                pbUserPic.Image = Resources.RedPerson;
            }
            else
            {
                pbUserPic.ImageLocation = User2.ImagePath;
            }

        }

        private void container(object _form)
        {

            if (PanelContianer.Controls.Count > 0) PanelContianer.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            PanelContianer.Controls.Add(fm);
            PanelContianer.Tag = fm;
            fm.Show();

        }


        private void btnClients_Click(object sender, EventArgs e)
        {
            //label_val.Text = "Patients List";
            //guna2PictureBox_val.Image = Properties.Resources.person__1_;
            clsPermissions Permission = new clsPermissions();
            clsUsers User2 = clsUsers.Find(_User.UserID);

            if (Permission._CheckAccessPermission((int)User2.AccessLevel))
            {
                container(new frmShowClients());
            }
            else
            {
                MessageBox.Show("You are not allowed to Manage Clients.", "Access Denied", MessageBoxButtons.OK);
            }

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            clsPermissions Permission = new clsPermissions();
            clsUsers User2 = clsUsers.Find(_User.UserID);

            if (Permission._CheckAccessPermission((int)User2.AccessLevel))
            {
                container(new frmManageUsers());
            }
            else
            {
                MessageBox.Show("You are not allowed to Manage Users.", "Access Denied", MessageBoxButtons.OK);
            }

        }

        private void btnPermissions_Click(object sender, EventArgs e)
        {
            clsPermissions Permission = new clsPermissions();
            clsUsers User2 = clsUsers.Find(_User.UserID);

            if (Permission._CheckAccessPermission((int)User2.AccessLevel))
            {
                container(new frmPermissions());
            }
            else
            {
                MessageBox.Show("You are not allowed to Manage Permissions.", "Access Denied", MessageBoxButtons.OK);
            }

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            clsUsers User2 = clsUsers.Find(_User.UserID);
            Form frm = new frmShowPersonInfo(User2.PersonID);
            frm.ShowDialog();
            frmMain_Load(null, null);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            clsPermissions Permission = new clsPermissions();
            clsUsers User2 = clsUsers.Find(_User.UserID);

            if (Permission._CheckAccessPermission(User2.AccessLevel))
            {
                container(new frmTransactions());
            }
            else
            {
                MessageBox.Show("You are not allowed to Access Transactions .", "Access Denied", MessageBoxButtons.OK);
            }


        }

        private void btnLoginRegistry_Click(object sender, EventArgs e)
        {
            clsPermissions Permission = new clsPermissions();
            clsUsers User2 = clsUsers.Find(_User.UserID);

            if (Permission._CheckAccessPermission(User2.AccessLevel))
            {
                container(new frmLoginHistory());
            }
            else
            {
                MessageBox.Show("You do not have access to Login History  يا معوددد.", "Access Denied", MessageBoxButtons.OK);
            }


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.Show();
        }

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            clsPermissions Permission = new clsPermissions();
            clsUsers User2 = clsUsers.Find(_User.UserID);

            if (Permission._CheckAccessPermission(User2.AccessLevel))
            {
                container(new frmCurrencies());
            }
            else
            {
                MessageBox.Show("You do not have access to Currenciess..", "Access Denied", MessageBoxButtons.OK);
            }

        }
    }
}
