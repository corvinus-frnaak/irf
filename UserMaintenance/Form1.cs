﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			label1.Text = Resource1.FullName;

			button1.Text = Resource1.Add;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SaveFileDialog s = new SaveFileDialog();
			if (s.ShowDialog()==DialogResult.OK)
			{
				
			}
			
		}
	}
}
