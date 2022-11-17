using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zhgyak.Abstractions
{
	public abstract class Product:Button
	{
		public Product()
		{
			Width = 150;
			Height = 50;
		}
		public virtual string Title
		{
			set
			{
				Text = value;
			}
		}
		public virtual int Calories { set { Display(); } }
		public abstract void Display();

	}
}
