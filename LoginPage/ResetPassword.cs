using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

			string inputedUsername = UserName.Text;
			string username = SignIn.GetUsername(inputedUsername);
			string nPassword = NewPw.Text;
			string cPassword = ConfPassword.Text;




			Hide();
			loginPage.Show();
		}
	}
}
