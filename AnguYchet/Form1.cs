using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnguYchet
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Page.Заказы Form1 = new Page.Заказы();
			Form1.Show();
		}
	}
}
