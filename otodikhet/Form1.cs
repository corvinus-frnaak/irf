using otodikhet.Entities;
using otodikhet.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace otodikhet
{
	public partial class Form1 : Form
	{
		MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();
		BindingList<RateData> Rates = new BindingList<RateData>();
		public string WebServiceCall()
		{
			var request = new GetExchangeRatesRequestBody()
			{
				currencyNames = "EUR",
				startDate = "2020-01-01",
				endDate = "2020-06-30"
			};
			var response = mnbService.GetExchangeRates(request);
			var result = response.GetExchangeRatesResult;
			return result;
		}
		public void XmlProcess(string result)
		{
			XmlDocument xml = new XmlDocument();
			xml.LoadXml(result);
			foreach (XmlElement x in xml.DocumentElement)
			{
			}
		}
		public Form1()
		{
			InitializeComponent();
			string result = WebServiceCall();
			dgwRates.DataSource = Rates;
			XmlProcess(result);
		}
	}
}
