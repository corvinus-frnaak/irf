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
			get
			{
				return Title;
			}
			set
			{
				Text = value;
			}
		}
		//{ Display(); }
		public virtual int Calories { get; set; }
		public abstract void Display();

	}
}
