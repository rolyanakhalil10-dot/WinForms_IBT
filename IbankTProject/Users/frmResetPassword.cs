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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace IBTpresentationLayer
{
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPassword.Text.Trim() != tbNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, null);
            }
            ;

        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {

        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string code = tbCode.Text.Trim();
            string newPassword = tbConfirmPassword.Text.Trim();

            if (!clsResetCodeManager.ValidateCode(email, code))
            {
                MessageBox.Show("Invalid or expired code.");
                return;
            }
            string HashedPassword = clsHashPassword.ComputeHash(newPassword);
            bool success = clsUsers.REsetPassword(tbEmail.Text.Trim(), HashedPassword);

            if (success)
                MessageBox.Show("Password reset successfully!");
            else
                MessageBox.Show("Failed to reset password.");
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();

            string code = clsResetCodeManager.GenerateAndStoreCode(email);
            clsEmailService.SendEmail(email, "Your Reset Code", $"Your code is: {code}");

            MessageBox.Show("Code sent to your email.");
        }
    }
}
