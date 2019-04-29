namespace FinancialApp
{
	partial class LoginPage
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tUserName = new System.Windows.Forms.TextBox();
			this.tPassword = new System.Windows.Forms.TextBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.ResetPassword = new System.Windows.Forms.Label();
			this.SignUpBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(229, 196);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(229, 243);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Password:";
			// 
			// tUserName
			// 
			this.tUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tUserName.Location = new System.Drawing.Point(232, 212);
			this.tUserName.Name = "tUserName";
			this.tUserName.Size = new System.Drawing.Size(336, 20);
			this.tUserName.TabIndex = 1;
			// 
			// tPassword
			// 
			this.tPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tPassword.Location = new System.Drawing.Point(232, 259);
			this.tPassword.Name = "tPassword";
			this.tPassword.PasswordChar = '*';
			this.tPassword.Size = new System.Drawing.Size(336, 20);
			this.tPassword.TabIndex = 2;
			// 
			// LoginButton
			// 
			this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LoginButton.Location = new System.Drawing.Point(232, 328);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(143, 30);
			this.LoginButton.TabIndex = 3;
			this.LoginButton.Text = "Sign In";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// ResetPassword
			// 
			this.ResetPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ResetPassword.AutoEllipsis = true;
			this.ResetPassword.AutoSize = true;
			this.ResetPassword.Location = new System.Drawing.Point(348, 297);
			this.ResetPassword.Name = "ResetPassword";
			this.ResetPassword.Size = new System.Drawing.Size(104, 13);
			this.ResetPassword.TabIndex = 4;
			this.ResetPassword.Text = "I forgot my password";
			this.ResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ResetPassword.Click += new System.EventHandler(this.ResetPassword_Click);
			this.ResetPassword.MouseLeave += new System.EventHandler(this.ResetPassword_MouseLeave);
			this.ResetPassword.MouseHover += new System.EventHandler(this.ResetPassword_MouseHover);
			// 
			// SignUpBtn
			// 
			this.SignUpBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.SignUpBtn.Location = new System.Drawing.Point(425, 328);
			this.SignUpBtn.Name = "SignUpBtn";
			this.SignUpBtn.Size = new System.Drawing.Size(143, 30);
			this.SignUpBtn.TabIndex = 5;
			this.SignUpBtn.Text = "Sign Up";
			this.SignUpBtn.UseVisualStyleBackColor = true;
			this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
			// 
			// LoginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SignUpBtn);
			this.Controls.Add(this.ResetPassword);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.tPassword);
			this.Controls.Add(this.tUserName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "LoginPage";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.LoginPage_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tUserName;
		private System.Windows.Forms.TextBox tPassword;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.Label ResetPassword;
		private System.Windows.Forms.Button SignUpBtn;
	}
}

