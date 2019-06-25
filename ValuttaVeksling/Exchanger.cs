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
    /// Main interface used by the program.
    /// </summary>
    public partial class Exchanger : Form
    {
        /// <summary>
        /// Exchange rates for a base currency, has to be stored somewhere we can pass it to our receipt.
        /// </summary>
        ExchangeRates rates;

        /// <summary>
        /// Amount of a base currency to be exchanged, stored to protect the initial value.
        /// </summary>
        double amount;

        /// <summary>
        /// Base currency to exchange from, stored to protect initial value.
        /// </summary>
        string from;

        /// <summary>
        /// Currency to exchane into, stored to protect initial value.
        /// </summary>
        string to;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Exchanger()
        {
            InitializeComponent();

            List<ComboboxItem> fromCurrencyComboboxItems = new List<ComboboxItem>();
            List<ComboboxItem> toCurrencyComboboxItems = new List<ComboboxItem>();
            foreach (string acceptedCurrency in Program.AcceptedCurrencies)
            {
                fromCurrencyComboboxItems.Add(new ComboboxItem { Text = acceptedCurrency + " - " + Program.CurrencyDictionary[acceptedCurrency], Value = acceptedCurrency });
                toCurrencyComboboxItems.Add(new ComboboxItem { Text = acceptedCurrency + " - " + Program.CurrencyDictionary[acceptedCurrency], Value = acceptedCurrency });
            }
            fromCurrencyComboBox.DisplayMember = "Text";
            fromCurrencyComboBox.ValueMember = "Value";
            fromCurrencyComboBox.DataSource = fromCurrencyComboboxItems;
            toCurrencyComboBox.DisplayMember = "Text";
            toCurrencyComboBox.ValueMember = "Value";
            toCurrencyComboBox.DataSource = toCurrencyComboboxItems;

            rates = new ExchangeRates();
        }
        
        /// <summary>
        /// Opens Settings panel.
        /// </summary>
        private void SettingsButton_OnClick(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        /// <summary>
        /// Queries API for Exchange rates of a base currency.
        /// </summary>
        private void GetExchangeRateButton_OnClick(object sender, EventArgs e)
        {
            if(amountTextBox.Text == "")
            {
                MessageBox.Show("Vennligst angi et beløp.");
            }
            else if(double.TryParse(amountTextBox.Text, out amount))
            {
                from = fromCurrencyComboBox.SelectedValue.ToString();
                to = toCurrencyComboBox.SelectedValue.ToString();
                rates = Task.Run(() => Program.GetExchangeRates(from)).Result;
                toPayTextBox.Text = Math.Round(amount * (1 - Program.CommisionRate) * rates.Rates[to], 2, MidpointRounding.AwayFromZero).ToString();
                toPayCurrencyLabel.Text = to;
            }
            else
            {
                MessageBox.Show("Vennligst sørg for at beløpet som er angitt er et tall.");
            }
        }
        
        /// <summary>
        /// Completes the transaction and opens receipt panel.
        /// </summary>
        private void AcceptExchangeRateButton_OnClick(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt(amount, from, to, rates);
            receipt.Show();
        }
    }

    /// <summary>
    /// Wrapper used to hold text and values for our combo boxes.
    /// </summary>
    public class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
