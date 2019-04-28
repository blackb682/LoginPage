using System;
using System.Drawing;
using System.Windows.Forms;

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
			string inputedUserName = tUserName.Text;
			string inputedPassword = tPassword.Text;
			string username;
			string password;
			
			username = SignIn.GetUsername(inputedUserName);
			password = SignIn.GetPassword(inputedUserName);

			MessageBox.Show(password + "\n" + username);

			if (inputedUserName == "")
			{
				MessageBox.Show(")
			}

		}

		private void LoginPage_Load(object sender, EventArgs e)
		{

		}
	}
}
