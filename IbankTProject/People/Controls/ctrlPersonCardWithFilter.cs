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

namespace IBTpresentationLayer
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {

        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID);
            }
        }


        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAddPerson.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }
        public int PersonID
        {
            get { return ctrlPersonInfoCard1.PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonInfoCard1.SelectedPersonInfo; }
        }

        private void ctrlPersonInfoCard1_Load(object sender, EventArgs e)
        {

        }

        private void _FindNow()
        {
            ctrlPersonInfoCard1.LoadPersonInfo(int.Parse(tbFilter.Text));

            if (OnPersonSelected != null && FilterEnabled)
                OnPersonSelected(ctrlPersonInfoCard1.PersonID);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _FindNow();
        }

        private void tbFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFilter, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(tbFilter, null);
            }

        }

        public void FilterFocus()
        {
            tbFilter.Focus();
        }

        private void DataBackEvent(object sender, int PersonID)
        {
            tbFilter.Text = PersonID.ToString();
            ctrlPersonInfoCard1.LoadPersonInfo(PersonID);
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            tbFilter.Focus();
        }

        private void btnAddPerson_Click_1(object sender, EventArgs e)
        {
            frmAddEditUsers frm = new frmAddEditUsers();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();

        }

        public void LoadPersonInfo(int PersonID)
        {
            tbFilter.Text = PersonID.ToString();
            _FindNow();

        }


    }
}
