using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_het_gyak.Entities
{
	public class Ball: Label
	{
		public Ball()
		{
			AutoSize = false;
			Width = 50;
			Height = 50;
			Paint += Ball_Paint;
		}
		protected void DrawImage(Graphics e)
		{
			e.FillEllipse(new SolidBrush(Color.Blue) , 0, 0, Width, Height);
		}

		private void Ball_Paint(object sender, PaintEventArgs e)
		{
			DrawImage(e.Graphics);
			throw new NotImplementedException();
		}
		public void MoveBall()
		{
			Left++;
		}
	}
}
