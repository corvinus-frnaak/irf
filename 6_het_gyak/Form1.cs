using _6_het_gyak.Abstractions;
using _6_het_gyak.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_het_gyak
{
	public partial class Form1 : Form
	{
		List<Ball> _toys = new List<Ball>();
		public IToyFactory Factory; 
		public Form1()
		{
			InitializeComponent();
			Factory = new BallFactory();
		}

		private void createTimer_Tick(object sender, EventArgs e)
		{
			var newBall = Factory.CreateNew();
			_toys.Add(newBall);
			newBall.Left = -newBall.Width;
			mainPanel.Controls.Add(newBall);
			
		}

		private void conveyorTimer_Tick(object sender, EventArgs e)
		{
			var maxPosition = 0;
			foreach (Ball b in _toys)
			{
				b.MoveToy();
				if (b.Left>maxPosition)
				{
					maxPosition = b.Left;
				}
			}
			
			if(maxPosition >= 1000)
			{
				var firstElement = _toys[0];
				_toys.Remove(firstElement);
				mainPanel.Controls.Remove(firstElement);
			}

		}

		private void btCar_Click(object sender, EventArgs e)
		{

		}

		private void btBall_Click(object sender, EventArgs e)
		{

		}
	}
}
