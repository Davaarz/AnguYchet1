using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnguYchet.Page
{
	public partial class Заказы : Form
	{
		public Заказы()
		{
			InitializeComponent();
		}

		private void Заказы_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "angu_ushetDataSet.Заказы". При необходимости она может быть перемещена или удалена.
			this.заказыTableAdapter.Fill(this.angu_ushetDataSet.Заказы);

		}
	}
}
