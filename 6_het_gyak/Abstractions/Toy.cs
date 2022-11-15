using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_het_gyak.Abstractions
{
	public abstract class Toy: Label
	{
		public Toy()
		{
			AutoSize = false;
			Width = 50;
			Height = 50;
			Paint += Toy_Paint;
		}
		protected abstract void DrawImage(Graphics e);
		private void Toy_Paint(object sender, PaintEventArgs e)
		{
			DrawImage(e.Graphics);
		}

		public virtual void MoveToy()
		{
			Left++;
		}
	}
}
