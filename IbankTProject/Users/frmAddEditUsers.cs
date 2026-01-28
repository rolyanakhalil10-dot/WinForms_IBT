using IBTbusinessLogicLayer;
using IBTpresentationLayer.Properties;
using System.Data;
using System.Windows.Forms;

namespace IBTpresentationLayer
{
    public partial class frmAddEditUsers : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;


        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGender { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _UserID = -1;

        clsUsers _User;

        public frmAddEditUsers()
        {
            InitializeComponent();
            lblpw.Visible = false;
            tbCurrentPassword.Visible = false;
            _Mode = enMode.AddNew;
            _User = new clsUsers();
        }
        public frmAddEditUsers(int UserID)
        {
            InitializeComponent();
            lblpw.Visible = true;
            tbCurrentPassword.Visible = true;
            _Mode = enMode.Update;
            _UserID = UserID;
        }

        private void frmAddEditUsers_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
            {
                _LoadUserInfo();
            }

        }

        public void _ResetDefaultValues()
        {
            _FillCountriesCombobox();
            pbPersonPic.Image = Resources.RedPerson;
            cbCountries.SelectedIndex = cbCountries.FindString("Kurdistan");

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            lblRemove.Visible = (pbPersonPic.ImageLocation != null);


            tbUserID.Text = "N/A";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPhoneNumber.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
            tbUserName.Text = "";
            tbCurrentPassword.Text = "";
            tbConfirmPassword.Text = "";


        }

        private void _FillCountriesCombobox()
        {
            DataTable dtCountries = clsCountries.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }

        }

        private void _LoadUserInfo()
        {
            _User = clsUsers.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            tbUserID.Text = _UserID.ToString();
            tbUserName.Text = _User.UserName;
            //tbCurrentPassword.Text = _User.Password;
            tbFirstName.Text = _User.FirstName;
            tbLastName.Text = _User.LastName;
            tbPhoneNumber.Text = _User.Phone;
            tbEmail.Text = _User.Email;
            tbAddress.Text = _User.Address;
            tbUserName.Text = _User.UserName;
            dtpDateOfBirth.Value = _User.DateOfBirth;
            tbCurrentPassword.PlaceholderText = "Enter Password";
            cbCountries.SelectedIndex = cbCountries.FindString(_User.CountryInfo.CountryName);

            if (_User.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (_User.ImagePath != "")
            {
                pbPersonPic.ImageLocation = _User.ImagePath;

            }

            lblRemove.Visible = (_User.ImagePath != "");


        }
        private bool _HandlePersonImage()
        {
            if (_User.ImagePath != pbPersonPic.ImageLocation)
            {
                if (_User.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_User.ImagePath);
                    }
                    catch (IOException)
                    {
                    }
                }
                if (pbPersonPic.ImageLocation != null)
                {
                    string SourceImageFile = pbPersonPic.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonPic.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private void lblAddPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonPic.ImageLocation = selectedFilePath;
                pbPersonPic.Load(selectedFilePath);
                lblRemove.Visible = true;
            }

        }

        private void lblRemove_Click(object sender, EventArgs e)
        {
            pbPersonPic.ImageLocation = null;
            lblRemove.Visible = false;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandlePersonImage())
            {
                return;
            }

            var country = clsCountries.Find(cbCountries.Text);

            if (country != null)
            {
                _User.CountryID = country.CountryID;
            }
            else
            {
                MessageBox.Show("Selected country is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.FirstName = tbFirstName.Text.Trim();
            _User.LastName = tbLastName.Text.Trim();
            _User.Address = tbAddress.Text.Trim();
            _User.Phone = tbPhoneNumber.Text.Trim();
            _User.Email = tbEmail.Text.Trim();
            _User.DateOfBirth = dtpDateOfBirth.Value;
            _User.UserName = tbUserName.Text.Trim();
            _User.Password = tbNewPw.Text.Trim();
            _User.Gender = rbMale.Checked ? (short)enGender.Male : (short)enGender.Female;
            if (pbPersonPic.ImageLocation != null)
                _User.ImagePath = pbPersonPic.ImageLocation;
            else
                _User.ImagePath = "";

            if (_User.Save())
            {
                tbUserID.Text = _User.UserID.ToString();
                _Mode = enMode.Update;

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // send the data back to the caller 
                DataBack?.Invoke(this, _User.PersonID);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void tbConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tbConfirmPassword.Text.Trim() != tbNewPw.Text.Trim())
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

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "cuurent password cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(tbCurrentPassword, null);
            }
            ;

            if (_User.Password!= clsHashPassword.ComputeHash(tbCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "Current password is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(tbCurrentPassword, null);
            }
            ;


        }
    }
}
