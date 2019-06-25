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
    /// Settings panel used to change the commision rate taken from a transaction.
    /// </summary>
    public partial class Settings : Form
    {
        /// <summary>
        /// constructor.
        /// </summary>
        public Settings()
        {
            InitializeComponent();
            percentageTextBox.Text = (Program.CommisionRate * 100).ToString();
        }

        /// <summary>
        /// Saves changes and closes the panel.
        /// </summary>
        private void SaveButton_OnClick(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(percentageTextBox.Text, out value))
            {
                Program.CommisionRate = value / 100;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vennligst sørg for at kommisjonsprosenten er et tall.");
            }
        }

        /// <summary>
        /// Closes the panel.
        /// </summary>
        private void CancelButton_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
