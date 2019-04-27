namespace FinancialApp
{
	partial class ResetPassword
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.EmailAddress = new System.Windows.Forms.TextBox();
			this.NewPw = new System.Windows.Forms.TextBox();
			this.ConfPassword = new System.Windows.Forms.TextBox();
			this.NewPassword = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "E-mail Address:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "New Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Confirm Password:";
			// 
			// EmailAddress
			// 
			this.EmailAddress.Location = new System.Drawing.Point(42, 47);
			this.EmailAddress.Name = "EmailAddress";
			this.EmailAddress.Size = new System.Drawing.Size(169, 20);
			this.EmailAddress.TabIndex = 3;
			// 
			// NewPw
			// 
			this.NewPw.Location = new System.Drawing.Point(42, 93);
			this.NewPw.Name = "NewPw";
			this.NewPw.PasswordChar = '*';
			this.NewPw.Size = new System.Drawing.Size(169, 20);
			this.NewPw.TabIndex = 4;
			// 
			// ConfPassword
			// 
			this.ConfPassword.Location = new System.Drawing.Point(42, 139);
			this.ConfPassword.Name = "ConfPassword";
			this.ConfPassword.PasswordChar = '*';
			this.ConfPassword.Size = new System.Drawing.Size(169, 20);
			this.ConfPassword.TabIndex = 5;
			// 
			// NewPassword
			// 
			this.NewPassword.Location = new System.Drawing.Point(75, 185);
			this.NewPassword.Name = "NewPassword";
			this.NewPassword.Size = new System.Drawing.Size(103, 29);
			this.NewPassword.TabIndex = 6;
			this.NewPassword.Text = "Send";
			this.NewPassword.UseVisualStyleBackColor = true;
			this.NewPassword.Click += new System.EventHandler(this.NewPassword_Click);
			// 
			// ResetPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(252, 247);
			this.Controls.Add(this.NewPassword);
			this.Controls.Add(this.ConfPassword);
			this.Controls.Add(this.NewPw);
			this.Controls.Add(this.EmailAddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(268, 286);
			this.Name = "ResetPassword";
			this.Text = "Reset Password";
			this.Load += new System.EventHandler(this.ResetPassword_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox EmailAddress;
		private System.Windows.Forms.TextBox NewPw;
		private System.Windows.Forms.TextBox ConfPassword;
		private System.Windows.Forms.Button NewPassword;
	}
}