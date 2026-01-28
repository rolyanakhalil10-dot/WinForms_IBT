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
    public partial class frmAddEditClient : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGender { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _ClientID = -1;

        clsClients _Client;

        public frmAddEditClient()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _Client = new clsClients();
        }

        public frmAddEditClient(int ClientID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _ClientID = ClientID;
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


            tbPersonID.Text = "N/A";
            tbPinCode.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPhoneNumber.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";

        }

        private void _FillCountriesCombobox()
        {
            DataTable dtCountries = clsCountries.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }

        }

        private void _LoadPersonInfo()
        {
            _Client = clsClients.Find(_ClientID);

            if (_Client == null)
            {
                MessageBox.Show("No Client with ID = " + _ClientID, "Cleint Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            tbPersonID.Text = _ClientID.ToString();
            tbPinCode.Text = _Client.PinCode;
            tbFirstName.Text = _Client.FirstName;
            tbLastName.Text = _Client.LastName;
            tbPhoneNumber.Text = _Client.Phone;
            tbEmail.Text = _Client.Email;
            tbAddress.Text = _Client.Address;
            dtpDateOfBirth.Value = _Client.DateOfBirth;
            cbCountries.SelectedIndex = cbCountries.FindString(_Client.CountryInfo.CountryName);
            if (_Client.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (_Client.ImagePath != "")
            {
                pbPersonPic.ImageLocation = _Client.ImagePath;

            }

            lblRemove.Visible = (_Client.ImagePath != "");


        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
            {
                _LoadPersonInfo();
            }

        }

        private bool _HandlePersonImage()
        {
            if (_Client.ImagePath != pbPersonPic.ImageLocation) // Error _User is nkllll
            {
                if (_Client.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Client.ImagePath);
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

        private void guna2Button1_Click(object sender, EventArgs e)
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
                _Client.CountryID = country.CountryID;
            }
            else
            {
                MessageBox.Show("Selected country is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Client.FirstName = tbFirstName.Text.Trim();
            _Client.LastName = tbLastName.Text.Trim();
            _Client.Address = tbAddress.Text.Trim();
            _Client.Phone = tbPhoneNumber.Text.Trim();
            _Client.Email = tbEmail.Text.Trim();
            _Client.DateOfBirth = dtpDateOfBirth.Value;
            _Client.PinCode = tbPinCode.Text.Trim();
            _Client.Gender = rbMale.Checked ? (short)enGender.Male : (short)enGender.Female;
            if (pbPersonPic.ImageLocation != null)
                _Client.ImagePath = pbPersonPic.ImageLocation;
            else
                _Client.ImagePath = "";

            if (_Client.Save())
            {
                tbPersonID.Text = _Client.PersonID.ToString();
                _Mode = enMode.Update;

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
