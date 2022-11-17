using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zhgyak2.Abstractions
{
	public abstract class Rating:Button
	{
		public Rating()
		{
			Height = 50;
			Width = 200;
			Click += Rating_Click;
		}

		private void Rating_Click(object sender, EventArgs e)
		{
			MessageBox.Show(GetDisplayText());
		}

		private string _title;
		private string _rtype;
		public virtual string Title { get => _title; set { _title = value; Text = _title; } }
		public virtual string RatingType
		{
			get => _rtype;
			set
			{
				_rtype = value;
				switch (_rtype)
				{
					case "G":
						BackColor = Color.Green;
						break;
					case "PG":
						BackColor = Color.Azure;
						break;
					case "PG-13":
						BackColor = Color.IndianRed;
						break;
					case "R":
						BackColor = Color.Orange;
						break;
					default:
						BackColor = DefaultBackColor;
						break;
				}
			}
		}
		public abstract string GetDisplayText();
	}
}
