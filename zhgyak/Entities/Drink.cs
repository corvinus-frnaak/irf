using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zhgyak.Abstractions;

namespace zhgyak.Entities
{
	internal class Drink : Product
	{
		public Drink()
		{
			Click += Drink_Click;
		}

		private void Drink_Click(object sender, EventArgs e)
		{
			MessageBox.Show(Title + "\n" + Description+"\n"+Calories);
		}

		public override void Display()
		{
			BackColor = Color.LightBlue;
		}
		public string Description { get; set; }
	}
}
