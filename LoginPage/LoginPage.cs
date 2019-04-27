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
	public partial class LoginPage : Form
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		private void ResetPassword_Click(object sender, EventArgs e)
		{
			Form resetPassword = new ResetPassword();

			Hide();
			resetPassword.Show();
		}

		private void ResetPassword_MouseHover(object sender, EventArgs e)
		{
			ResetPassword.ForeColor = Color.DarkBlue;
			ResetPassword.Font = new Font(ResetPassword.Font.Name, ResetPassword.Font.SizeInPoints, FontStyle.Underline);
		}

		private void ResetPassword_MouseLeave(object sender, EventArgs e)
		{
			ResetPassword.ForeColor = Color.Black;
			ResetPassword.Font = new Font(ResetPassword.Font.Name, ResetPassword.Font.SizeInPoints, FontStyle.Regular);
		}

		public void LoginButton_Click(object sender, EventArgs e)
		{
			Form home = new Home();
			DBConnection.OpenSqlConnection();
			
			
			
			Hide();
			home.Show();
			
			
		}
	}
}
