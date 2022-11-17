using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using zhgyak2.Abstractions;
using zhgyak2.Entities;
using zhgyak2.ServiceReference1;

namespace zhgyak2
{
	public partial class Form1 : Form
	{
		List<Rating> _ratings = new List<Rating>();
		public Form1()
		{
			InitializeComponent();
			Call();
			ShowData();
		}
		public string LoadData()
		{
			var FilmRatings = new ServiceSoapClient();
			var request = FilmRatings.GetExportWithTitle("Halloween");
			return request;
		}
		public void Call()
		{
			var xmlS = LoadData();
			var xml = new XmlDocument();
			xml.LoadXml(xmlS);
			foreach (XmlElement x in xml.DocumentElement)
			{
				string name = x.SelectSingleNode("name").InnerText;
				string rating = x.SelectSingleNode("rating").InnerText;
				string ratingReason = x.SelectSingleNode("ratingReason").InnerText;
				if(ratingReason!="")
				{
					var newRating = new DetailedRanking();
					newRating.Title = name;
					newRating.RatingReason = ratingReason;
					newRating.RatingType = rating;
					_ratings.Add(newRating);
				}
				if (ratingReason == "")
				{
					var newRating = new StandardRating();
					newRating.Title = name;
					newRating.RatingType = rating;
					_ratings.Add(newRating);
				}
			}
		}
		public void ShowData()
		{
			int i = 0;
			List<Rating> sortedRating = _ratings.OrderBy(o => o.Title).ToList();
			foreach (Rating x in sortedRating)
			{
				x.Top = i;
				Controls.Add(x);
				i+=50;
			}
		}
	}
}
