using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValuttaVeksling
{
    /// <summary>
    /// Receipt to be displayed of a finished transaction.
    /// </summary>
    public partial class Receipt : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="amount">Amount of base currency converted.</param>
        /// <param name="from">Base currency converted from.</param>
        /// <param name="to">Currency converted to.</param>
        /// <param name="rates">Currency exchange rates of base currency.</param>
        public Receipt(double amount, string from, string to, ExchangeRates rates)
        {
            InitializeComponent();
            dateLabel2.Text = rates.Date.ToShortDateString();
            amountLabel2.Text = Math.Round(amount, 2, MidpointRounding.AwayFromZero).ToString() + " " + from;
            commisionLabel2.Text = Math.Round(Program.CommisionRate * amount, 2, MidpointRounding.AwayFromZero).ToString() + " " + from;
            toPayLabel2.Text = Math.Round((1 - Program.CommisionRate) * amount * rates.Rates[to], 2, MidpointRounding.AwayFromZero).ToString() + " " + to;
            exchangeRateLabel.Text = "1 " + from + " = " + rates.Rates[to].ToString() + " " + to;
        }

        /// <summary>
        /// Closes the panel.
        /// </summary>
        private void AcceptButton_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
