using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency
{
    public partial class convertCurrency : Form
    {
        public convertCurrency()
        {
            InitializeComponent();
        }

     

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(txtAmount.Text);
            double eurToBgn = 1.9558;
            double usdToBgn = 1.55;
            double gpdToBgn = 2.1;

            double amountBgn = 0;
            switch (cbCurrency.SelectedItem)
            {
                case "BGN":
                    amountBgn = amount;
                    break;
                case "EUR":
                    amountBgn = amount * eurToBgn;
                    break;
                case "USD":
                    amountBgn = amount * usdToBgn;
                    break;
                case "GBP":
                    amountBgn = amount * gpdToBgn;
                    break;
            }
            txtBGN.Text = amountBgn.ToString();
            txtEUR.Text = (amountBgn / eurToBgn).ToString();
            txtUSD.Text = (amountBgn / usdToBgn).ToString();
            txtGBP.Text = (amountBgn / gpdToBgn).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtBGN.Clear();
            txtEUR.Clear();
            txtUSD.Clear();
            txtGBP.Clear();
            cbCurrency.SelectedIndex= -1;
        }
    }
}
