using _6_het_gyak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_het_gyak.Entities
{
	public class Present : Toy
	{
		public Present(Color ribbon, Color box)
		{
			ribbonBrush = new SolidBrush(ribbon);
			boxBrush = new SolidBrush(box);
		}
		public SolidBrush ribbonBrush { get; set; }
		public SolidBrush boxBrush { get; set; }
		protected override void DrawImage(Graphics e)
		{
			e.FillRectangle(boxBrush, 0, 0, Width, Height);
			e.FillRectangle(ribbonBrush, Width*2/5, 0, Width*1/5, Height);
			e.FillRectangle(ribbonBrush, 0, Height * 2 / 5, Width, Height*1/5);
		}

		public override string ToyType()
		{
			return "Present";
		}
	}
}
