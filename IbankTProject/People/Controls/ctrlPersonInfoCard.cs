using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBTbusinessLogicLayer;
using IBTpresentationLayer.Properties;

namespace IBTpresentationLayer
{
    public partial class ctrlPersonInfoCard : UserControl
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        private clsPerson _Person;
        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }


        public ctrlPersonInfoCard()
        {
            InitializeComponent();
        }

        private void ctrlPersonInfoCard_Load(object sender, EventArgs e)
        {

        }
        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PErson iD = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblID.Text = "[????]";
            lblFullName.Text = "[????]";
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhoneNumber.Text = "[????]";
            lblBirthDate.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonPic.Image = Resources.RedPerson;

        }
        private void _FillPersonInfo()
        {
            lblEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lblID.Text = _Person.PersonID.ToString();
            lblFullName.Text = _Person.FullName;
            lblGender.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhoneNumber.Text = _Person.Phone;
            lblBirthDate.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = clsCountries.Find(_Person.CountryID).CountryName;
            lblAddress.Text = _Person.Address;
            _LoadPersonImage();
        }
        
        private void _LoadPersonImage()
        {
            pbPersonPic.ImageLocation = null; 
            pbPersonPic.Image = Resources.RedPerson;

            string imagePath = _Person.ImagePath;

            if (!string.IsNullOrWhiteSpace(imagePath))
            {
                if (File.Exists(imagePath))
                {
                    pbPersonPic.ImageLocation = imagePath;
                }
                else
                {
                    MessageBox.Show("Could not find this image: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblEditPersonInfo_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.Show();
            LoadPersonInfo(_PersonID);

        }
    }
}
