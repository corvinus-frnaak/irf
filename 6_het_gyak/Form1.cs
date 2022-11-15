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
		Toy _nextToy;
		List<Toy> _toys = new List<Toy>();
		private IToyFactory _factory;
		public IToyFactory Factory { get { return _factory; ; } set { _factory = value; DisplayNext(); } }
		public Form1()
		{
			InitializeComponent();
			Factory = new BallFactory();
		}
		public void DisplayNext()
		{
			if (_nextToy!=null)
			{
				Controls.Remove(_nextToy);
				_nextToy = Factory.CreateNew();
				_nextToy.Left = label1.Left;
				_nextToy.Top = label1.Height;
				Controls.Add(_nextToy);
			}
		}

		private void createTimer_Tick(object sender, EventArgs e)
		{
			var newToy = Factory.CreateNew();
			_toys.Add(newToy);
			newToy.Left = -newToy.Width;
			mainPanel.Controls.Add(newToy);
			
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
			var newBall = new BallFactory();

		}

		private void btBall_Click(object sender, EventArgs e)
		{
			var newCar = new CarFactory();

		}
	}
}
