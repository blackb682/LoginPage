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
			DialogResult result = new DialogResult();

			username = SignIn.GetUsername(inputedUserName);
			password = SignIn.GetPassword(inputedUserName);

			if (inputedUserName == "")
			{
				MessageBox.Show("I think you forgot to tell me your username.\n" +
					"Please fill the username field =)", "Error =(",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (inputedUserName != username)
				{
					MessageBox.Show("I didn't found this username.\n" +
						"Could you please tell me it again? =)", "Error =(",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					if (inputedPassword != password)
					{
						result = MessageBox.Show("This is not the password that I have registered here.\n" +
							"\nWould you like to reset your password?\n" +
	   "					Click 'OK' to reset your password.\n" +
	"						Click 'Cancel' to try again.", "Oops =(",
							MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
						if (result == DialogResult.OK)
						{
							Form resetPassword = new ResetPassword();
							resetPassword.Show();
						}
					}
					else
					{
						Hide();
						home.Show();
					}
				}
			}
		}

		private void LoginPage_Load(object sender, EventArgs e)
		{

		}

		private void SignUpBtn_Click(object sender, EventArgs e)
		{

		}
	}
}
