using IBTbusinessLogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public clsUsers GetUserObj()
        {
            clsUsers User = clsUsers.GetUserByNameandPassword(tbUserName.Text.Trim(), tbPassword.Text.Trim());

            return User;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUsers User = GetUserObj();

            if (User != null)
            {
                if (cbRememberME.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(tbUserName.Text.Trim(), tbPassword.Text.Trim());
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                clsGlobal.CurrentUser = User;
                this.Hide();
                frmMain frm = new frmMain(this, User);
                _SaveLoginHistory();
                frm.ShowDialog();

            }
            else
            {
                tbUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //contorls for UI
            guna2ShadowForm1.SetShadowForm(this);
            guna2DragControl1.TargetControl = guna2Panel1;
            //NO
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                tbUserName.Text = UserName;
                tbPassword.Text = Password;
                cbRememberME.Checked = true;
            }
            else
                cbRememberME.Checked = false;
        }

        private void _SaveLoginHistory()
        {
            clsUsers User = GetUserObj();

            clsUsers User2 = clsUsers.Find(User.UserID);
            clsUserLogins.SaveLoginHistory(User.UserID, DateTime.Now);
        }

        private void lblForgotpw_Click(object sender, EventArgs e)
        {
            frmResetPassword frm = new frmResetPassword();
            frm.Show();
        }
    }
}
