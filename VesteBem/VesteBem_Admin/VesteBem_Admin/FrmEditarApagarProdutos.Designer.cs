
namespace VesteBem_Admin
{
	partial class FrmEditarApagarProdutos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarApagarProdutos));
			this.PnlCima = new System.Windows.Forms.Panel();
			this.lblNome = new System.Windows.Forms.Label();
			this.LblCat = new System.Windows.Forms.Label();
			this.CmbCategoria = new System.Windows.Forms.ComboBox();
			this.TxtNome = new System.Windows.Forms.TextBox();
			this.FlwCentro = new System.Windows.Forms.FlowLayoutPanel();
			this.BgwInicio = new System.ComponentModel.BackgroundWorker();
			this.BgwModificar = new System.ComponentModel.BackgroundWorker();
			this.LblNomeProduto = new System.Windows.Forms.Label();
			this.LblCategoria = new System.Windows.Forms.Label();
			this.LblSubCategoria = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.PnlCima.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// PnlCima
			// 
			this.PnlCima.Controls.Add(this.lblNome);
			this.PnlCima.Controls.Add(this.LblCat);
			this.PnlCima.Controls.Add(this.CmbCategoria);
			this.PnlCima.Controls.Add(this.TxtNome);
			this.PnlCima.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlCima.Location = new System.Drawing.Point(0, 0);
			this.PnlCima.Margin = new System.Windows.Forms.Padding(0);
			this.PnlCima.Name = "PnlCima";
			this.PnlCima.Size = new System.Drawing.Size(800, 42);
			this.PnlCima.TabIndex = 0;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(8, 13);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(93, 13);
			this.lblNome.TabIndex = 3;
			this.lblNome.Text = "Nome do Produto:";
			// 
			// LblCat
			// 
			this.LblCat.AutoSize = true;
			this.LblCat.Location = new System.Drawing.Point(559, 13);
			this.LblCat.Name = "LblCat";
			this.LblCat.Size = new System.Drawing.Size(55, 13);
			this.LblCat.TabIndex = 2;
			this.LblCat.Text = "Categoria:";
			// 
			// CmbCategoria
			// 
			this.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbCategoria.FormattingEnabled = true;
			this.CmbCategoria.Location = new System.Drawing.Point(620, 10);
			this.CmbCategoria.Name = "CmbCategoria";
			this.CmbCategoria.Size = new System.Drawing.Size(168, 21);
			this.CmbCategoria.TabIndex = 1;
			this.CmbCategoria.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
			// 
			// TxtNome
			// 
			this.TxtNome.Location = new System.Drawing.Point(104, 10);
			this.TxtNome.Name = "TxtNome";
			this.TxtNome.Size = new System.Drawing.Size(200, 20);
			this.TxtNome.TabIndex = 0;
			this.TxtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// FlwCentro
			// 
			this.FlwCentro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlwCentro.Location = new System.Drawing.Point(0, 42);
			this.FlwCentro.Name = "FlwCentro";
			this.FlwCentro.Size = new System.Drawing.Size(800, 408);
			this.FlwCentro.TabIndex = 1;
			// 
			// BgwInicio
			// 
			this.BgwInicio.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.BgwInicio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// BgwModificar
			// 
			this.BgwModificar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
			// 
			// LblNomeProduto
			// 
			this.LblNomeProduto.Location = new System.Drawing.Point(0, 0);
			this.LblNomeProduto.Name = "LblNomeProduto";
			this.LblNomeProduto.Size = new System.Drawing.Size(100, 23);
			this.LblNomeProduto.TabIndex = 0;
			// 
			// LblCategoria
			// 
			this.LblCategoria.Location = new System.Drawing.Point(0, 0);
			this.LblCategoria.Name = "LblCategoria";
			this.LblCategoria.Size = new System.Drawing.Size(100, 23);
			this.LblCategoria.TabIndex = 0;
			// 
			// LblSubCategoria
			// 
			this.LblSubCategoria.Location = new System.Drawing.Point(0, 0);
			this.LblSubCategoria.Name = "LblSubCategoria";
			this.LblSubCategoria.Size = new System.Drawing.Size(100, 23);
			this.LblSubCategoria.TabIndex = 0;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 50);
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// FrmEditarApagarProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.FlwCentro);
			this.Controls.Add(this.PnlCima);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmEditarApagarProdutos";
			this.Text = "Editar ou Apagar Produto";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEditarApagarProdutos_FormClosed);
			this.Load += new System.EventHandler(this.FrmEditarApagarProdutos_Load);
			this.PnlCima.ResumeLayout(false);
			this.PnlCima.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel PnlCima;
		private System.Windows.Forms.FlowLayoutPanel FlwCentro;
		private System.Windows.Forms.TextBox TxtNome;
		private System.Windows.Forms.ComboBox CmbCategoria;
		private System.Windows.Forms.Label LblCat;
		private System.Windows.Forms.Label lblNome;
		private System.ComponentModel.BackgroundWorker BgwInicio;
		private System.ComponentModel.BackgroundWorker BgwModificar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label LblNomeProduto;
		private System.Windows.Forms.Label LblCategoria;
		private System.Windows.Forms.Label LblSubCategoria;
	}
}