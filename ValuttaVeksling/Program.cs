using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValuttaVeksling
{
    /// <summary>
    /// Wrapper to hold translated JSON responses of currency exchange rates.
    /// </summary>
    public class ExchangeRates
    {
        public string Base { get; set; }
        public Dictionary<string, double> Rates { get; set; }
        public DateTime Date { get; set; }
    }

    static class Program
    {
        /// <summary>
        /// List of Accepted Currencies.
        /// </summary>
        public static List<string> AcceptedCurrencies;

        /// <summary>
        /// Commision rate to be collected from transactions.
        /// </summary>
        public static double CommisionRate;

        /// <summary>
        /// Dictionary of Currencies.
        /// </summary>
        public static Dictionary<string, string> CurrencyDictionary;

        /// <summary>
        /// HttpClient we use to query the exchange rate API.
        /// </summary>
        private static HttpClient client;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CommisionRate = 0.01;

            AcceptedCurrencies = new List<string>();
            CurrencyDictionary = new Dictionary<string, string>();
            AcceptedCurrencies.Add("NOK");
            CurrencyDictionary["NOK"] = "Norske Kroner";
            AcceptedCurrencies.Add("SEK");
            CurrencyDictionary["SEK"] = "Svenske Kroner";
            AcceptedCurrencies.Add("GBP");
            CurrencyDictionary["GBP"] = "Britiske Pund";
            AcceptedCurrencies.Add("USD");
            CurrencyDictionary["USD"] = "Amerikanske Dollar";
            AcceptedCurrencies.Add("CNY");
            CurrencyDictionary["CNY"] = "Kinesiske Yuan";

            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Exchanger());
        }

        /// <summary>
        /// Queries https://api.exchangeratesapi.io for the latest rates of a base currency.
        /// </summary>
        /// <param name="baseCurrency">The base currency we wish to know exchange rates for.</param>
        /// <returns>Returns Task for the exchange rates, use '.Result' to get the actual Value.</returns>
        public static async Task<ExchangeRates> GetExchangeRates(string baseCurrency)
        {
            ExchangeRates rates = new ExchangeRates();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api.exchangeratesapi.io/latest?base=" + baseCurrency);
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    rates.Base = data.Substring(data.IndexOf("base") + 7, data.IndexOf(',', data.IndexOf("base")) - data.IndexOf("base") - 8);
                    rates.Date = DateTime.Parse(data.Substring(data.IndexOf("date") + 7, data.IndexOf(',', data.IndexOf("date")) - data.IndexOf("date") - 8));
                    string[] ratePairs = data.Substring(data.IndexOf("rates") + 8).Split(',');
                    rates.Rates = new Dictionary<string, double>();
                    foreach (string ratePair in ratePairs)
                    {
                        string[] pair = ratePair.Split(':');
                        double n = new double();
                        if (double.TryParse(pair[1], NumberStyles.Any, CultureInfo.InvariantCulture, out n))
                        {
                            rates.Rates.Add(pair[0].Trim('"'), n);
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Klarte ikke å få kontakt med WebAPI.");
            }
            return rates;
            
        }
    }
}
