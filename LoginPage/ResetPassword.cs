using System;
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

			string inputedUsername = UserName.Text;
			string username = SignIn.GetUsername(inputedUsername);
			string nPassword = NewPw.Text;
			string cPassword = ConfPassword.Text;

			if (inputedUsername == "")
			{
				MessageBox.Show("I think you forgot to tell me your username.\n" +
					"Please fill the username field =)", "Error =(",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (inputedUsername != username)
			{
				MessageBox.Show("I didn't found this username.\n" +
					"Could you please tell me it again? =)", "Error =(",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (nPassword == "")
				{
					MessageBox.Show("You must fill the new password field.\n" +
						"Could you please tell me it again? =)", "Error =(",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (nPassword != cPassword)
				{
					MessageBox.Show("The 'New Password' and 'Confirm Password' fields don't match."
						, "Error =(",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					RestorePassword.InsertNewPassword(username, nPassword);

					MessageBox.Show("Your password were reseted! =D\nPlease sign in again!"
						, "YAY =)",
						MessageBoxButtons.OK, MessageBoxIcon.Information);

					Hide();
					loginPage.Show();
				}
			}
		}
	}
}
