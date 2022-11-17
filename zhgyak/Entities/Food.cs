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
	internal class Food : Product
	{
		public Food()
		{
			Click += Food_Click;
		}

		private void Food_Click(object sender, EventArgs e)
		{
			MessageBox.Show(Title + "\n" + Description + "\n" + Calories);
		}

		public override void Display()
		{
			if (Calories < 750) { BackColor = Color.LightGreen; return; }
			if (Calories >= 750 && Calories <= 1001) { BackColor = Color.LightYellow; return; }
			if (Calories >= 1000) { BackColor = Color.Salmon; return; }
		}
		public string Description { get; set; }
	}
}
