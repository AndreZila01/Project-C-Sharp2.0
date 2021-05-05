
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.novosFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.novosFuncionariosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 48;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// clienteToolStripMenuItem
			// 
			this.clienteToolStripMenuItem.Image = global::VesteBem_Admin.Properties.Resources.user;
			this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
			this.clienteToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.clienteToolStripMenuItem.Text = "Cliente";
			this.clienteToolStripMenuItem.Click += new System.EventHandler(this.ToolstripMenuItem_Click);
			// 
			// funcionarioToolStripMenuItem
			// 
			this.funcionarioToolStripMenuItem.Image = global::VesteBem_Admin.Properties.Resources.Admin;
			this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
			this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
			this.funcionarioToolStripMenuItem.Text = "Funcionario";
			this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.ToolstripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 532);
			this.panel1.TabIndex = 49;
			this.panel1.Visible = false;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// novosFuncionariosToolStripMenuItem
			// 
			this.novosFuncionariosToolStripMenuItem.Image = global::VesteBem_Admin.Properties.Resources.add;
			this.novosFuncionariosToolStripMenuItem.Name = "novosFuncionariosToolStripMenuItem";
			this.novosFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
			this.novosFuncionariosToolStripMenuItem.Text = "Novos Funcionarios";
			this.novosFuncionariosToolStripMenuItem.Visible = false;
			// 
			// FrmCliEFun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 556);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmCliEFun";
			this.Text = "FrmCliEFun";
			this.Load += new System.EventHandler(this.FrmCliEFun_Load);
			this.SizeChanged += new System.EventHandler(this.FrmCliEFun_SizeChanged);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ToolStripMenuItem novosFuncionariosToolStripMenuItem;
	}
}