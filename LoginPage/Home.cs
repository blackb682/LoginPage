using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialApp
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			menuStrip1.Width = toolStripTextBox1.Width;
			toolStripTextBox1.Visible = true;
		}
	}
}
