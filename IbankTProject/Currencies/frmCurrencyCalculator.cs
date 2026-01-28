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
    public partial class frmCurrencyCalculator : Form
    {
        private double _ExchanedAmount;
        public frmCurrencyCalculator()
        {
            InitializeComponent();
        }

        private void frmCurrencyCalculator_Load(object sender, EventArgs e)
        {
            _FillCurrencyCodesCombobox();
        }


        private void _FillCurrencyCodesCombobox()
        {
            DataTable dtCurrencycodes = clsCurrencies.GetAllCurrencyCodes();

            foreach (DataRow row in dtCurrencycodes.Rows)
            {
                cbCodeFrom.Items.Add(row["Code"]);
            }

            foreach (DataRow row in dtCurrencycodes.Rows)
            {
                cbCodeTo.Items.Add(row["Code"]);
            }

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            _ExchanedAmount =  clsCurrencies.ExchangeMoney(Convert.ToDouble(tbAmount.Text.Trim()), cbCodeFrom.Text.ToString(), cbCodeTo.Text.ToString());
            tbExchangedAmountj.Text = _ExchanedAmount.ToString();
        }
    }
}
