using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zhgyak.Abstractions;

namespace zhgyak.Entities
{
	internal class Drink : Product
	{
		public override void Display()
		{
			BackColor = Color.LightBlue;
		}
	}
}
