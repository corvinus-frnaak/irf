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
		BindingList<Entities.User> users = new BindingList<Entities.User>();
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var u = new Entities.User()
			{
				FullName = textBox1.Text,
			};
			users.Add(u);
		}
	}
}
