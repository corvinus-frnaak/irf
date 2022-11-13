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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace otodikhet
{
	public partial class Form1 : Form
	{
		MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();
		BindingList<RateData> Rates = new BindingList<RateData>();
		BindingList<string> Currencies = new BindingList<string>();
		public string WebServiceCall()
		{
			var request = new GetExchangeRatesRequestBody()
			{
				currencyNames = comboBox1.SelectedItem.ToString(),	
				startDate = dateTimePicker1.Value.ToString(),
				endDate = dateTimePicker2.Value.ToString()
			};
			var response = mnbService.GetExchangeRates(request);
			var result = response.GetExchangeRatesResult;
			return result;
		}
		public void ShowData()
		{
			chartRateDAta.DataSource = Rates;
			var series = chartRateDAta.Series[0];
			series.ChartType = SeriesChartType.Line;
			series.XValueMember = "Date";
			series.YValueMembers = "Value";
			series.BorderWidth = 3;
			var legends = chartRateDAta.Legends[0];
			legends.Enabled = false;
			var chartarea = chartRateDAta.ChartAreas[0];
			chartarea.AxisX.MajorGrid.Enabled = false;
			chartarea.AxisY.MajorGrid.Enabled = false;
			chartarea.AxisY.IsStartedFromZero = false;	
		}
		public void XmlProcess(string result)
		{
			XmlDocument xml = new XmlDocument();
			xml.LoadXml(result);
			foreach (XmlElement x in xml.DocumentElement)
			{
				var rate = new RateData();
				Rates.Add(rate);
				rate.Date = DateTime.Parse(x.GetAttribute("date"));
				var childElement = (XmlElement)x.ChildNodes[0];
				rate.Currency = childElement.GetAttribute("curr");
				var hanyados = decimal.Parse(childElement.InnerText) / decimal.Parse(childElement.GetAttribute("unit"));
				rate.Value = hanyados==0? 0:hanyados;	
			}
		}
		public void RefreshData()
		{
			Rates.Clear();
			string result = WebServiceCall();
			dgwRates.DataSource = Rates;
			comboBox1.DataSource = Currencies;
			XmlProcess(result);
			ShowData();
		}
		public Form1()
		{
			InitializeComponent();
			GetCurrencies();
			RefreshData();
		}
		public void GetCurrencies()
		{
			var requestC = new GetCurrenciesRequestBody();
			var responseC = mnbService.GetCurrencies(requestC);
			var resultC = responseC.GetCurrenciesResult;
			CurrencyProcess(resultC);
		}
		public void CurrencyProcess(string result)
		{
			var Xml = new XmlDocument();
			Xml.LoadXml(result);
			foreach (XmlElement x in Xml.DocumentElement.FirstChild)
			{
				if (x == null)	continue;
				var currency = x.InnerText;
				 Currencies.Add(currency.ToString());
			}
		}
		private void dgwRates_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshData();
		}
	}
}
