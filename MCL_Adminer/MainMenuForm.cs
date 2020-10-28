﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MCL_Adminer
{
	public partial class MainMenuForm : Form
	{
		public MainMenuForm()
		{
			InitializeComponent();
			User usr = new User();
			Room rm = new Room();
			Reports rpt = new Reports();
			rm.LoadAll();
			usr.LoadAll();
			rpt.LoadAll();
			button1.Click += delegate(object sender, EventArgs e)
			{
				button1_Click(sender, e);
			};
			button2.Click += delegate(object sender, EventArgs e)
			{
				button2_Click(sender, e);
			};
			button3.Click += delegate(object sender, EventArgs e)
			{
				button3_Click(sender, e);
			};
		}

		public void button1_Click(object sender, EventArgs e)
		{
			ReportSelect report = new ReportSelect();
            Hide();
			report.Show();
		}

		public void button2_Click(object sender, EventArgs e)
		{
			ManageUsers manage = new ManageUsers();
			Hide();
			manage.Show();
		}

		public void button3_Click(object sender, EventArgs e)
		{
			ManageRooms room = new ManageRooms();
			Hide();
			room.Show();
		}
	}
}
