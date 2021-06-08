
namespace VesteBem_Admin
{
	partial class FrmCliEFun
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliEFun));
			this.MsMenu = new System.Windows.Forms.MenuStrip();
			this.TstbCliente = new System.Windows.Forms.ToolStripTextBox();
			this.TstbFuncionario = new System.Windows.Forms.ToolStripTextBox();
			this.PnlCentro = new System.Windows.Forms.Panel();
			this.BgwCliente = new System.ComponentModel.BackgroundWorker();
			this.TsmiCliente = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiFuncionario = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiNovoFuncionario = new System.Windows.Forms.ToolStripMenuItem();
			this.MsMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MsMenu
			// 
			this.MsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiCliente,
            this.TstbCliente,
            this.TsmiFuncionario,
            this.TstbFuncionario,
            this.TsmiNovoFuncionario});
			this.MsMenu.Location = new System.Drawing.Point(0, 0);
			this.MsMenu.Name = "MsMenu";
			this.MsMenu.Size = new System.Drawing.Size(800, 24);
			this.MsMenu.TabIndex = 48;
			this.MsMenu.Text = "menuStrip1";
			// 
			// TstbCliente
			// 
			this.TstbCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.TstbCliente.Name = "TstbCliente";
			this.TstbCliente.Size = new System.Drawing.Size(100, 23);
			this.TstbCliente.Visible = false;
			this.TstbCliente.TextChanged += new System.EventHandler(this.TstbClienteEFun_TextChanged);
			// 
			// TstbFuncionario
			// 
			this.TstbFuncionario.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.TstbFuncionario.Name = "TstbFuncionario";
			this.TstbFuncionario.Size = new System.Drawing.Size(100, 23);
			this.TstbFuncionario.Visible = false;
			this.TstbFuncionario.TextChanged += new System.EventHandler(this.TstbClienteEFun_TextChanged);
			// 
			// PnlCentro
			// 
			this.PnlCentro.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.PnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlCentro.Location = new System.Drawing.Point(0, 24);
			this.PnlCentro.Name = "PnlCentro";
			this.PnlCentro.Size = new System.Drawing.Size(800, 532);
			this.PnlCentro.TabIndex = 49;
			this.PnlCentro.Visible = false;
			// 
			// BgwCliente
			// 
			this.BgwCliente.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.BgwCliente.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// TsmiCliente
			// 
			this.TsmiCliente.Image = global::VesteBem_Admin.Properties.Resources.user;
			this.TsmiCliente.Name = "TsmiCliente";
			this.TsmiCliente.Size = new System.Drawing.Size(72, 20);
			this.TsmiCliente.Text = "Cliente";
			this.TsmiCliente.Click += new System.EventHandler(this.ToolstripMenuItem_Click);
			// 
			// TsmiFuncionario
			// 
			this.TsmiFuncionario.Image = global::VesteBem_Admin.Properties.Resources.Admin;
			this.TsmiFuncionario.Name = "TsmiFuncionario";
			this.TsmiFuncionario.Size = new System.Drawing.Size(98, 20);
			this.TsmiFuncionario.Text = "Funcionario";
			this.TsmiFuncionario.Click += new System.EventHandler(this.ToolstripMenuItem_Click);
			// 
			// TsmiNovoFuncionario
			// 
			this.TsmiNovoFuncionario.Image = global::VesteBem_Admin.Properties.Resources.add;
			this.TsmiNovoFuncionario.Name = "TsmiNovoFuncionario";
			this.TsmiNovoFuncionario.Size = new System.Drawing.Size(140, 20);
			this.TsmiNovoFuncionario.Text = "Novos Funcionarios";
			this.TsmiNovoFuncionario.Visible = false;
			this.TsmiNovoFuncionario.Click += new System.EventHandler(this.ToolstripMenuItem_Click);
			// 
			// FrmCliEFun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 556);
			this.Controls.Add(this.PnlCentro);
			this.Controls.Add(this.MsMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MsMenu;
			this.MaximizeBox = false;
			this.Name = "FrmCliEFun";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cliente e Funcionario";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCliEFun_FormClosed);
			this.Load += new System.EventHandler(this.FrmCliEFun_Load);
			this.SizeChanged += new System.EventHandler(this.FrmCliEFun_SizeChanged);
			this.MsMenu.ResumeLayout(false);
			this.MsMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip MsMenu;
		private System.Windows.Forms.ToolStripMenuItem TsmiCliente;
		private System.Windows.Forms.ToolStripMenuItem TsmiFuncionario;
		private System.Windows.Forms.Panel PnlCentro;
		private System.ComponentModel.BackgroundWorker BgwCliente;
		private System.Windows.Forms.ToolStripMenuItem TsmiNovoFuncionario;
		private System.Windows.Forms.ToolStripTextBox TstbCliente;
		private System.Windows.Forms.ToolStripTextBox TstbFuncionario;
	}
}