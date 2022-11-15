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
		List<Ball> _balls = new List<Ball>();
		public BallFactory Factory; //BallFactory típusú kifejtett propery
		public Form1()
		{
			mainPanel.Width = Width;
		
			Factory = new BallFactory();
			InitializeComponent();
		}

		private void createTimer_Tick(object sender, EventArgs e)
		{
			var newBall = Factory.CreateNew();
			_balls.Add(newBall);
			newBall.Left = -newBall.Width;
			mainPanel.Controls.Add(newBall);
			
		}

		private void conveyorTimer_Tick(object sender, EventArgs e)
		{
			var maxPosition = 0;
			foreach (Ball b in _balls)
			{
				b.MoveBall();
				if (b.Left>maxPosition)
				{
					maxPosition = b.Left;
				}
			}
			
			if(maxPosition >= 1000)
			{
				var firstElement = _balls[0];
				_balls.Remove(firstElement);
				mainPanel.Controls.Remove(firstElement);
			}

		}
	}
}
