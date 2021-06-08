
namespace VesteBem_Admin
{
	partial class FrmConsultarCarrinho
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarCarrinho));
			this.panel1 = new System.Windows.Forms.Panel();
			this.LblFim = new System.Windows.Forms.Label();
			this.LblInicio = new System.Windows.Forms.Label();
			this.LblCliOuId = new System.Windows.Forms.Label();
			this.LblEstado = new System.Windows.Forms.Label();
			this.DtpChegada = new System.Windows.Forms.DateTimePicker();
			this.DtpInicio = new System.Windows.Forms.DateTimePicker();
			this.TxtClienteId = new System.Windows.Forms.TextBox();
			this.CmbEstado = new System.Windows.Forms.ComboBox();
			this.BgwInicio = new System.ComponentModel.BackgroundWorker();
			this.FlpCentro = new System.Windows.Forms.FlowLayoutPanel();
			this.BgwModificar = new System.ComponentModel.BackgroundWorker();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.LblFim);
			this.panel1.Controls.Add(this.LblInicio);
			this.panel1.Controls.Add(this.LblCliOuId);
			this.panel1.Controls.Add(this.LblEstado);
			this.panel1.Controls.Add(this.DtpChegada);
			this.panel1.Controls.Add(this.DtpInicio);
			this.panel1.Controls.Add(this.TxtClienteId);
			this.panel1.Controls.Add(this.CmbEstado);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 63);
			this.panel1.TabIndex = 0;
			// 
			// LblFim
			// 
			this.LblFim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LblFim.AutoSize = true;
			this.LblFim.Location = new System.Drawing.Point(642, 17);
			this.LblFim.Name = "LblFim";
			this.LblFim.Size = new System.Drawing.Size(87, 13);
			this.LblFim.TabIndex = 7;
			this.LblFim.Text = "Encomendas até";
			// 
			// LblInicio
			// 
			this.LblInicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LblInicio.AutoSize = true;
			this.LblInicio.Location = new System.Drawing.Point(442, 17);
			this.LblInicio.Name = "LblInicio";
			this.LblInicio.Size = new System.Drawing.Size(87, 13);
			this.LblInicio.TabIndex = 6;
			this.LblInicio.Text = "Encomendas de ";
			// 
			// LblCliOuId
			// 
			this.LblCliOuId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.LblCliOuId.AutoSize = true;
			this.LblCliOuId.Location = new System.Drawing.Point(187, 17);
			this.LblCliOuId.Name = "LblCliOuId";
			this.LblCliOuId.Size = new System.Drawing.Size(123, 13);
			this.LblCliOuId.TabIndex = 5;
			this.LblCliOuId.Text = "Cliente ou IdEncomenda";
			// 
			// LblEstado
			// 
			this.LblEstado.AutoSize = true;
			this.LblEstado.Location = new System.Drawing.Point(22, 17);
			this.LblEstado.Name = "LblEstado";
			this.LblEstado.Size = new System.Drawing.Size(45, 13);
			this.LblEstado.TabIndex = 4;
			this.LblEstado.Text = "Estados";
			// 
			// DtpChegada
			// 
			this.DtpChegada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DtpChegada.Location = new System.Drawing.Point(645, 36);
			this.DtpChegada.Name = "DtpChegada";
			this.DtpChegada.Size = new System.Drawing.Size(143, 20);
			this.DtpChegada.TabIndex = 3;
			// 
			// DtpInicio
			// 
			this.DtpInicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.DtpInicio.Location = new System.Drawing.Point(445, 35);
			this.DtpInicio.Name = "DtpInicio";
			this.DtpInicio.Size = new System.Drawing.Size(143, 20);
			this.DtpInicio.TabIndex = 2;
			// 
			// TxtClienteId
			// 
			this.TxtClienteId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtClienteId.Location = new System.Drawing.Point(190, 36);
			this.TxtClienteId.Name = "TxtClienteId";
			this.TxtClienteId.Size = new System.Drawing.Size(185, 20);
			this.TxtClienteId.TabIndex = 1;
			this.TxtClienteId.MouseLeave += new System.EventHandler(this.Object_MouseLeavee);
			// 
			// CmbEstado
			// 
			this.CmbEstado.FormattingEnabled = true;
			this.CmbEstado.Location = new System.Drawing.Point(22, 36);
			this.CmbEstado.Name = "CmbEstado";
			this.CmbEstado.Size = new System.Drawing.Size(121, 21);
			this.CmbEstado.TabIndex = 0;
			this.CmbEstado.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
			this.CmbEstado.MouseLeave += new System.EventHandler(this.Object_MouseLeavee);
			// 
			// BgwInicio
			// 
			this.BgwInicio.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.BgwInicio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// FlpCentro
			// 
			this.FlpCentro.AutoSize = true;
			this.FlpCentro.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.FlpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlpCentro.Location = new System.Drawing.Point(0, 63);
			this.FlpCentro.Name = "FlpCentro";
			this.FlpCentro.Size = new System.Drawing.Size(800, 387);
			this.FlpCentro.TabIndex = 1;
			this.FlpCentro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
			// 
			// BgwModificar
			// 
			this.BgwModificar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
			this.BgwModificar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
			// 
			// FrmConsultarCarrinho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.FlpCentro);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmConsultarCarrinho";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consultar Carrinho";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultarCarrinho_FormClosed);
			this.Load += new System.EventHandler(this.FrmConsultarCarrinho_Load);
			this.SizeChanged += new System.EventHandler(this.FrmConsultarCarrinho_SizeChanged);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox CmbEstado;
		private System.Windows.Forms.TextBox TxtClienteId;
		private System.Windows.Forms.DateTimePicker DtpChegada;
		private System.Windows.Forms.DateTimePicker DtpInicio;
		private System.Windows.Forms.Label LblFim;
		private System.Windows.Forms.Label LblInicio;
		private System.Windows.Forms.Label LblCliOuId;
		private System.Windows.Forms.Label LblEstado;
		private System.ComponentModel.BackgroundWorker BgwInicio;
		private System.Windows.Forms.FlowLayoutPanel FlpCentro;
		private System.ComponentModel.BackgroundWorker BgwModificar;
	}
}