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

		private string _title;
		private int _calories;
		public virtual string Title
		{
			get
			{
				return _title;
			}
			set
			{
				Text = value;
				_title = value;
			}
		}
		public virtual int Calories { get => _calories; set { _calories = value; Display();  } }
		public abstract void Display();

	}
}
