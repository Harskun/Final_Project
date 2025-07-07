using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace uang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FromCurrencyBox.SelectedItem = "USD";
            ToCurrencyBox.SelectedItem = "IDR";
        }

        private double GetExchangeRate(string fromcurrency, string tocurrency)
        {
            string json;

            using (var client = new WebClient())
            {
                json = client.DownloadString($"https://api.exchangerate-api.com/v4/latest/{fromcurrency}");
            }

            var data = JObject.Parse(json);
            var rate = (double)data["rates"][tocurrency];

            return rate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fromcurrency = FromCurrencyBox.SelectedItem.ToString();
            string tocurrency = ToCurrencyBox.SelectedItem.ToString();
            
            double amount;
            if (!double.TryParse(AmountToConvertBox.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Error" , MessageBoxButtons.OK);
                return;
            }

            double exchangeRate;
            try
            {
                exchangeRate = GetExchangeRate(fromcurrency, tocurrency);
            }
            catch
            {
                MessageBox.Show("an error occurred while retrieving the exchange rate!", "Error - API error", MessageBoxButtons.OK);
                return;
            }

            double convertedAmount = amount * exchangeRate;
            ConvertedAmountDisplay.Text = " Converted amount" + tocurrency + convertedAmount.ToString("F2");
            RateDisplay.Text = $" counversion rate: 1 {fromcurrency} = {1 * exchangeRate}{tocurrency}";
        }

    }
}
