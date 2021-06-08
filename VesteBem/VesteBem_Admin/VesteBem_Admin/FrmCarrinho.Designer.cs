namespace VesteBem_Admin
{
	partial class FrmCarrinho
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarrinho));
			this.TxtValor = new System.Windows.Forms.TextBox();
			this.CboCliente = new System.Windows.Forms.ComboBox();
			this.LblValor = new System.Windows.Forms.Label();
			this.LblEstado = new System.Windows.Forms.Label();
			this.LblData = new System.Windows.Forms.Label();
			this.LblCliente = new System.Windows.Forms.Label();
			this.CboEstado = new System.Windows.Forms.ComboBox();
			this.DtpEntrega = new System.Windows.Forms.DateTimePicker();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.CmbProduto = new System.Windows.Forms.ComboBox();
			this.FlpProdutos = new System.Windows.Forms.FlowLayoutPanel();
			this.NudQuantidade = new System.Windows.Forms.NumericUpDown();
			this.LblTotal = new System.Windows.Forms.Label();
			this.PctRegistar = new System.Windows.Forms.PictureBox();
			this.PctEncomenda = new System.Windows.Forms.PictureBox();
			this.BgwInicio = new System.ComponentModel.BackgroundWorker();
			this.PnlEncomendar = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.PctAdd = new System.Windows.Forms.PictureBox();
			this.PnlRegistar = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.NudQuantidade)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PctRegistar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PctEncomenda)).BeginInit();
			this.PnlEncomendar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PctAdd)).BeginInit();
			this.PnlRegistar.SuspendLayout();
			this.SuspendLayout();
			// 
			// TxtValor
			// 
			this.TxtValor.Location = new System.Drawing.Point(122, 65);
			this.TxtValor.Name = "TxtValor";
			this.TxtValor.Size = new System.Drawing.Size(139, 20);
			this.TxtValor.TabIndex = 0;
			// 
			// CboCliente
			// 
			this.CboCliente.FormattingEnabled = true;
			this.CboCliente.Location = new System.Drawing.Point(122, 146);
			this.CboCliente.Name = "CboCliente";
			this.CboCliente.Size = new System.Drawing.Size(139, 21);
			this.CboCliente.TabIndex = 4;
			// 
			// LblValor
			// 
			this.LblValor.AutoSize = true;
			this.LblValor.Location = new System.Drawing.Point(15, 68);
			this.LblValor.Name = "LblValor";
			this.LblValor.Size = new System.Drawing.Size(96, 13);
			this.LblValor.TabIndex = 5;
			this.LblValor.Text = "Valor Encomendas";
			// 
			// LblEstado
			// 
			this.LblEstado.AutoSize = true;
			this.LblEstado.Location = new System.Drawing.Point(15, 94);
			this.LblEstado.Name = "LblEstado";
			this.LblEstado.Size = new System.Drawing.Size(105, 13);
			this.LblEstado.TabIndex = 6;
			this.LblEstado.Text = "Estado Encomendas";
			// 
			// LblData
			// 
			this.LblData.AutoSize = true;
			this.LblData.Location = new System.Drawing.Point(15, 122);
			this.LblData.Name = "LblData";
			this.LblData.Size = new System.Drawing.Size(70, 13);
			this.LblData.TabIndex = 8;
			this.LblData.Text = "Data Entrega";
			// 
			// LblCliente
			// 
			this.LblCliente.AutoSize = true;
			this.LblCliente.Location = new System.Drawing.Point(15, 149);
			this.LblCliente.Name = "LblCliente";
			this.LblCliente.Size = new System.Drawing.Size(39, 13);
			this.LblCliente.TabIndex = 9;
			this.LblCliente.Text = "Cliente";
			// 
			// CboEstado
			// 
			this.CboEstado.FormattingEnabled = true;
			this.CboEstado.Location = new System.Drawing.Point(122, 91);
			this.CboEstado.Name = "CboEstado";
			this.CboEstado.Size = new System.Drawing.Size(139, 21);
			this.CboEstado.TabIndex = 10;
			// 
			// DtpEntrega
			// 
			this.DtpEntrega.Location = new System.Drawing.Point(122, 120);
			this.DtpEntrega.Name = "DtpEntrega";
			this.DtpEntrega.Size = new System.Drawing.Size(200, 20);
			this.DtpEntrega.TabIndex = 12;
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Location = new System.Drawing.Point(32, 191);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(164, 46);
			this.BtnGuardar.TabIndex = 13;
			this.BtnGuardar.Text = "Efectuar Compra";
			this.BtnGuardar.UseVisualStyleBackColor = true;
			this.BtnGuardar.Click += new System.EventHandler(this.button1_Click);
			// 
			// CmbProduto
			// 
			this.CmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbProduto.FormattingEnabled = true;
			this.CmbProduto.Location = new System.Drawing.Point(209, 12);
			this.CmbProduto.Name = "CmbProduto";
			this.CmbProduto.Size = new System.Drawing.Size(239, 21);
			this.CmbProduto.TabIndex = 15;
			this.CmbProduto.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// FlpProdutos
			// 
			this.FlpProdutos.AutoScroll = true;
			this.FlpProdutos.Location = new System.Drawing.Point(177, 250);
			this.FlpProdutos.Name = "FlpProdutos";
			this.FlpProdutos.Size = new System.Drawing.Size(271, 163);
			this.FlpProdutos.TabIndex = 19;
			// 
			// NudQuantidade
			// 
			this.NudQuantidade.Location = new System.Drawing.Point(18, 224);
			this.NudQuantidade.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.NudQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NudQuantidade.Name = "NudQuantidade";
			this.NudQuantidade.Size = new System.Drawing.Size(75, 20);
			this.NudQuantidade.TabIndex = 20;
			this.NudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// LblTotal
			// 
			this.LblTotal.AutoSize = true;
			this.LblTotal.Location = new System.Drawing.Point(325, 427);
			this.LblTotal.Name = "LblTotal";
			this.LblTotal.Size = new System.Drawing.Size(40, 13);
			this.LblTotal.TabIndex = 21;
			this.LblTotal.Text = "Total : ";
			// 
			// PctRegistar
			// 
			this.PctRegistar.Image = global::VesteBem_Admin.Properties.Resources.shopping_cart;
			this.PctRegistar.Location = new System.Drawing.Point(413, 419);
			this.PctRegistar.Name = "PctRegistar";
			this.PctRegistar.Size = new System.Drawing.Size(35, 27);
			this.PctRegistar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PctRegistar.TabIndex = 22;
			this.PctRegistar.TabStop = false;
			this.PctRegistar.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// PctEncomenda
			// 
			this.PctEncomenda.Location = new System.Drawing.Point(209, 39);
			this.PctEncomenda.Name = "PctEncomenda";
			this.PctEncomenda.Size = new System.Drawing.Size(239, 205);
			this.PctEncomenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PctEncomenda.TabIndex = 14;
			this.PctEncomenda.TabStop = false;
			// 
			// BgwInicio
			// 
			this.BgwInicio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// PnlEncomendar
			// 
			this.PnlEncomendar.Controls.Add(this.label1);
			this.PnlEncomendar.Controls.Add(this.PctAdd);
			this.PnlEncomendar.Controls.Add(this.CmbProduto);
			this.PnlEncomendar.Controls.Add(this.PctRegistar);
			this.PnlEncomendar.Controls.Add(this.PctEncomenda);
			this.PnlEncomendar.Controls.Add(this.LblTotal);
			this.PnlEncomendar.Controls.Add(this.NudQuantidade);
			this.PnlEncomendar.Controls.Add(this.FlpProdutos);
			this.PnlEncomendar.Dock = System.Windows.Forms.DockStyle.Right;
			this.PnlEncomendar.Location = new System.Drawing.Point(340, 0);
			this.PnlEncomendar.Name = "PnlEncomendar";
			this.PnlEncomendar.Size = new System.Drawing.Size(460, 450);
			this.PnlEncomendar.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 201);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Quantidade : ";
			// 
			// PctAdd
			// 
			this.PctAdd.Image = global::VesteBem_Admin.Properties.Resources.add;
			this.PctAdd.Location = new System.Drawing.Point(119, 217);
			this.PctAdd.Name = "PctAdd";
			this.PctAdd.Size = new System.Drawing.Size(32, 33);
			this.PctAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PctAdd.TabIndex = 23;
			this.PctAdd.TabStop = false;
			this.PctAdd.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// PnlRegistar
			// 
			this.PnlRegistar.Controls.Add(this.CboCliente);
			this.PnlRegistar.Controls.Add(this.TxtValor);
			this.PnlRegistar.Controls.Add(this.BtnGuardar);
			this.PnlRegistar.Controls.Add(this.LblValor);
			this.PnlRegistar.Controls.Add(this.DtpEntrega);
			this.PnlRegistar.Controls.Add(this.LblEstado);
			this.PnlRegistar.Controls.Add(this.CboEstado);
			this.PnlRegistar.Controls.Add(this.LblData);
			this.PnlRegistar.Controls.Add(this.LblCliente);
			this.PnlRegistar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlRegistar.Enabled = false;
			this.PnlRegistar.Location = new System.Drawing.Point(0, 0);
			this.PnlRegistar.Name = "PnlRegistar";
			this.PnlRegistar.Size = new System.Drawing.Size(340, 450);
			this.PnlRegistar.TabIndex = 24;
			// 
			// FrmCarrinho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.PnlRegistar);
			this.Controls.Add(this.PnlEncomendar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmCarrinho";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adicionar Carrinho";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCarrinho_FormClosed);
			this.Load += new System.EventHandler(this.FrmCarrinho_Load);
			((System.ComponentModel.ISupportInitialize)(this.NudQuantidade)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PctRegistar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PctEncomenda)).EndInit();
			this.PnlEncomendar.ResumeLayout(false);
			this.PnlEncomendar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PctAdd)).EndInit();
			this.PnlRegistar.ResumeLayout(false);
			this.PnlRegistar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox TxtValor;
		private System.Windows.Forms.ComboBox CboCliente;
		private System.Windows.Forms.Label LblValor;
		private System.Windows.Forms.Label LblEstado;
		private System.Windows.Forms.Label LblData;
		private System.Windows.Forms.Label LblCliente;
		private System.Windows.Forms.ComboBox CboEstado;
		private System.Windows.Forms.DateTimePicker DtpEntrega;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.PictureBox PctEncomenda;
		private System.Windows.Forms.ComboBox CmbProduto;
		private System.Windows.Forms.FlowLayoutPanel FlpProdutos;
		private System.Windows.Forms.NumericUpDown NudQuantidade;
		private System.Windows.Forms.Label LblTotal;
		private System.Windows.Forms.PictureBox PctRegistar;
		private System.ComponentModel.BackgroundWorker BgwInicio;
		private System.Windows.Forms.Panel PnlEncomendar;
		private System.Windows.Forms.PictureBox PctAdd;
		private System.Windows.Forms.Panel PnlRegistar;
		private System.Windows.Forms.Label label1;
	}
}