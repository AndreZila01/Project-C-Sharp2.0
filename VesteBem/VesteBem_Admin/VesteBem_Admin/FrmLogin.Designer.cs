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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			this.btnLogin = new System.Windows.Forms.Button();
			this.TxtUser = new System.Windows.Forms.TextBox();
			this.TxtPass = new System.Windows.Forms.TextBox();
			this.LblUser = new System.Windows.Forms.Label();
			this.LblPass = new System.Windows.Forms.Label();
			this.lblTimer = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblAjuda = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(351, 173);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(90, 38);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.button1_Click);
			// 
			// TxtUser
			// 
			this.TxtUser.Location = new System.Drawing.Point(99, 71);
			this.TxtUser.Name = "TxtUser";
			this.TxtUser.Size = new System.Drawing.Size(214, 20);
			this.TxtUser.TabIndex = 1;
			// 
			// TxtPass
			// 
			this.TxtPass.Location = new System.Drawing.Point(99, 122);
			this.TxtPass.Name = "TxtPass";
			this.TxtPass.Size = new System.Drawing.Size(214, 20);
			this.TxtPass.TabIndex = 2;
			// 
			// LblUser
			// 
			this.LblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LblUser.AutoSize = true;
			this.LblUser.Location = new System.Drawing.Point(20, 74);
			this.LblUser.Name = "LblUser";
			this.LblUser.Size = new System.Drawing.Size(58, 13);
			this.LblUser.TabIndex = 3;
			this.LblUser.Text = "Username:";
			// 
			// LblPass
			// 
			this.LblPass.AutoSize = true;
			this.LblPass.Location = new System.Drawing.Point(20, 125);
			this.LblPass.Name = "LblPass";
			this.LblPass.Size = new System.Drawing.Size(56, 13);
			this.LblPass.TabIndex = 4;
			this.LblPass.Text = "Password:";
			// 
			// lblTimer
			// 
			this.lblTimer.Enabled = false;
			this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimer.Location = new System.Drawing.Point(12, 9);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(251, 42);
			this.lblTimer.TabIndex = 5;
			this.lblTimer.Text = "label3";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::VesteBem_Admin.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(351, 71);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(77, 71);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// lblAjuda
			// 
			this.lblAjuda.AutoSize = true;
			this.lblAjuda.Location = new System.Drawing.Point(220, 149);
			this.lblAjuda.Name = "lblAjuda";
			this.lblAjuda.Size = new System.Drawing.Size(101, 13);
			this.lblAjuda.TabIndex = 7;
			this.lblAjuda.Text = "Precisa de ajuda?!?";
			this.lblAjuda.Click += new System.EventHandler(this.lblAjuda_Click);
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 223);
			this.Controls.Add(this.lblAjuda);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblTimer);
			this.Controls.Add(this.LblPass);
			this.Controls.Add(this.LblUser);
			this.Controls.Add(this.TxtPass);
			this.Controls.Add(this.TxtUser);
			this.Controls.Add(this.btnLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblAjuda;
	}
}

