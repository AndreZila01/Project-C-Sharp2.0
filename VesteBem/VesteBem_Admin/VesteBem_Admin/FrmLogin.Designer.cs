namespace VesteBem_Admin
{
	partial class FrmLogin
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.TxtUser = new System.Windows.Forms.TextBox();
			this.TxtPass = new System.Windows.Forms.TextBox();
			this.LblUser = new System.Windows.Forms.Label();
			this.LblPass = new System.Windows.Forms.Label();
			this.lblTimer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(339, 164);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(90, 38);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.button1_Click);
			// 
			// TxtUser
			// 
			this.TxtUser.Location = new System.Drawing.Point(122, 67);
			this.TxtUser.Name = "TxtUser";
			this.TxtUser.Size = new System.Drawing.Size(214, 20);
			this.TxtUser.TabIndex = 1;
			// 
			// TxtPass
			// 
			this.TxtPass.Location = new System.Drawing.Point(122, 118);
			this.TxtPass.Name = "TxtPass";
			this.TxtPass.Size = new System.Drawing.Size(214, 20);
			this.TxtPass.TabIndex = 2;
			// 
			// LblUser
			// 
			this.LblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LblUser.AutoSize = true;
			this.LblUser.Location = new System.Drawing.Point(43, 70);
			this.LblUser.Name = "LblUser";
			this.LblUser.Size = new System.Drawing.Size(58, 13);
			this.LblUser.TabIndex = 3;
			this.LblUser.Text = "Username:";
			// 
			// LblPass
			// 
			this.LblPass.AutoSize = true;
			this.LblPass.Location = new System.Drawing.Point(43, 121);
			this.LblPass.Name = "LblPass";
			this.LblPass.Size = new System.Drawing.Size(56, 13);
			this.LblPass.TabIndex = 4;
			this.LblPass.Text = "Password:";
			// 
			// lblTimer
			// 
			this.lblTimer.Enabled = false;
			this.lblTimer.Location = new System.Drawing.Point(12, 9);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(251, 21);
			this.lblTimer.TabIndex = 5;
			this.lblTimer.Text = "label3";
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 223);
			this.Controls.Add(this.lblTimer);
			this.Controls.Add(this.LblPass);
			this.Controls.Add(this.LblUser);
			this.Controls.Add(this.TxtPass);
			this.Controls.Add(this.TxtUser);
			this.Controls.Add(this.btnLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox TxtUser;
		private System.Windows.Forms.TextBox TxtPass;
		private System.Windows.Forms.Label LblUser;
		private System.Windows.Forms.Label LblPass;
		private System.Windows.Forms.Label lblTimer;
	}
}

