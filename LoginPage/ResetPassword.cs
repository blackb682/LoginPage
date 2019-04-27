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
	public partial class ResetPassword : Form
	{
		public ResetPassword()
		{
			InitializeComponent();
		}

		private void ResetPassword_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void NewPassword_Click(object sender, EventArgs e)
		{
			Form loginPage = new LoginPage();

			Hide();
			loginPage.Show();
		}
	}
}
