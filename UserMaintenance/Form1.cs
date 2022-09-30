using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
			label1.Text = Resource1.FullName;
			button2.Text = Resource1.WriteToFile;
			button1.Text = Resource1.Add;
			listBox1.DataSource = users;
			listBox1.ValueMember = "ID";
			listBox1.DisplayMember = "FullName";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (var sfd = new SaveFileDialog())
			{
				sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
				sfd.FilterIndex = 1;

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					TextWriter tw = new StreamWriter(sfd.FileName);
					for (int i = 0; i < users.Count; i++)
					{
						tw.WriteLine(users[i].ID);
						tw.WriteLine(users[i].FullName);
					}
					
					tw.Close();
					

				}
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var u = new Entities.User()
			{
				FullName = textBox1.Text,
			};
			users.Add(u);
			textBox1.Text = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
