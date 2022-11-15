using _6_het_gyak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_het_gyak.Entities
{
	public class Car : Toy
	{
		protected override void DrawImage(Graphics e)
		{
			Image img = Image.FromFile("car.png");
			e.DrawImage(img,new Rectangle(0,0,Width,Height) );
		}
	}
}
