using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinCalculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void getRadesBTN_Click(object sender, EventArgs e)
        {
            if (currencyMenu.SelectedItem.ToString() == "EUR")
            {
                label.Visible = true;
                result.Visible = true;

                BitcoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBtc.Text); //teh amount of user's bitcoins

                float currentRate = resultRates.bpi.EUR.rate_float; //current bitcoin rate in EUR
                float btcResult = userCoins * currentRate;
                result.Text = $"{btcResult} {resultRates.bpi.EUR.code}";
            }
            else if (currencyMenu.SelectedItem.ToString() == "USD")
            {
                label.Visible = true;
                result.Visible = true;

                BitcoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBtc.Text);

                float currentRate = resultRates.bpi.USD.rate_float;
                float btcResult = userCoins * currentRate;
                result.Text = $"{btcResult} {resultRates.bpi.USD.code}";
            }
            else if (currencyMenu.SelectedItem.ToString() == "GPB")
            {
                label.Visible = true;
                result.Visible = true;

                BitcoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBtc.Text);

                float currentRate = resultRates.bpi.GPB.rate_float;
                float btcResult = userCoins * currentRate;
                result.Text = $"{btcResult} {resultRates.bpi.GPB.code}";
            }

        }


        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            BitcoinRates bitcoin;

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(response);
            }

            return bitcoin;

            
        }
    
    }
}
