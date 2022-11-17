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
using zhgyak.Abstractions;
using zhgyak.Entities;

namespace zhgyak
{
	public partial class Form1 : Form
	{
		List<Product> _products = new List<Product>();
		public Form1()
		{
			InitializeComponent();
			Read("Menu.xml");
			Sorting();
		}
		public void Read (string source)
		{
			string xml = "";
			try
			{
				using (StreamReader sr = new StreamReader(source))
				{
					string line;
					while ((line = sr.ReadLine())!=null)
					{
						xml = xml + line + "\n";
					}
				}
			}
			catch (Exception e)
			{

				MessageBox.Show(e.Message);
			}
			var newXml = new XmlDocument();
			newXml.LoadXml(xml);
			
			foreach ( XmlElement x in newXml.DocumentElement)
			{
				string name = x.SelectSingleNode("name").InnerText;
				string description = x.SelectSingleNode("description").InnerText;
				int calories = int.Parse(x.SelectSingleNode("calories").InnerText);
				string type = x.SelectSingleNode("type").InnerText;
				if(type=="food")
				{
					var fod = new Food();
					fod.Title = name;
					fod.Description = description;
					fod.Calories = calories;
					_products.Add(fod);
				}
				if (type == "drink")
				{
					var dri = new Drink();
					dri.Title = name;
					dri.Description = description;
					dri.Calories = calories;
					_products.Add(dri);
				}
			}
		}
		public void Sorting()
		{
			int ny = 0;
			List<Product> sortedProduct = _products.OrderBy(o => o.Title).ToList();
			foreach (Product x in sortedProduct)
			{
				x.Left = 0;
				x.Top = ny;
				Controls.Add(x);
				ny += x.Height + 1;

			}
		}
	}
}
