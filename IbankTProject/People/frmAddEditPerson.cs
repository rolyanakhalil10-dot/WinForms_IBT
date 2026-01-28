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
    public partial class frmAddEditPerson : Form
    {
        public enum enGender { Male = 0, Female = 1 };

        private int _PersonID = -1;

        clsPerson _Person;

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;

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
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "PErosn Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            tbPersonID.Text = _PersonID.ToString();
            tbFirstName.Text = _Person.FirstName;
            tbLastName.Text = _Person.LastName;
            tbPhoneNumber.Text = _Person.Phone;
            tbEmail.Text = _Person.Email;
            tbAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            cbCountries.SelectedIndex = cbCountries.FindString(_Person.CountryInfo.CountryName);
            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (_Person.ImagePath != "")
            {
                pbPersonPic.ImageLocation = _Person.ImagePath;

            }

            lblRemove.Visible = (_Person.ImagePath != "");


        }
        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pbPersonPic.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandlePersonImage())
            {
                return;
            }

            var country = clsCountries.Find(cbCountries.Text);

            if (country != null)
            {
                _Person.CountryID = country.CountryID;
            }
            else
            {
                MessageBox.Show("Selected country is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Person.FirstName = tbFirstName.Text.Trim();
            _Person.LastName = tbLastName.Text.Trim();
            _Person.Address = tbAddress.Text.Trim();
            _Person.Phone = tbPhoneNumber.Text.Trim();
            _Person.Email = tbEmail.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Gender = rbMale.Checked ? (short)enGender.Male : (short)enGender.Female;
            if (pbPersonPic.ImageLocation != null)
                _Person.ImagePath = pbPersonPic.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                tbPersonID.Text = _Person.PersonID.ToString();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            _LoadPersonInfo();
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
    }
}
