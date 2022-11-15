using _6_het_gyak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_het_gyak.Entities
{
	public class Ball: Toy
	{
		
		protected override void DrawImage(Graphics e)
		{
			e.FillEllipse(new SolidBrush(Color.Blue) , 0, 0, Width, Height);
		}

		
	}
}
