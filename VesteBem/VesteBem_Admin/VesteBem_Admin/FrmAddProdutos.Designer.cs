namespace VesteBem_Admin
{
	partial class FrmAddChangeProdutos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddChangeProdutos));
			this.TxtNome = new System.Windows.Forms.TextBox();
			this.TxtValor = new System.Windows.Forms.TextBox();
			this.TxtEmpresa = new System.Windows.Forms.TextBox();
			this.TxtCat = new System.Windows.Forms.TextBox();
			this.TxtSubCat = new System.Windows.Forms.TextBox();
			this.TxtIcon = new System.Windows.Forms.TextBox();
			this.PctImage = new System.Windows.Forms.PictureBox();
			this.LblNome = new System.Windows.Forms.Label();
			this.LblValor = new System.Windows.Forms.Label();
			this.LblEmpresa = new System.Windows.Forms.Label();
			this.LblCategoria = new System.Windows.Forms.Label();
			this.LblSubCateg = new System.Windows.Forms.Label();
			this.LblSexo = new System.Windows.Forms.Label();
			this.LblIcon = new System.Windows.Forms.Label();
			this.LblImagem = new System.Windows.Forms.Label();
			this.LblEuro = new System.Windows.Forms.Label();
			this.PctAdd = new System.Windows.Forms.PictureBox();
			this.BtnRegistar = new System.Windows.Forms.Button();
			this.CboSexo = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.PctImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PctAdd)).BeginInit();
			this.SuspendLayout();
			// 
			// TxtNome
			// 
			this.TxtNome.Location = new System.Drawing.Point(109, 47);
			this.TxtNome.MaxLength = 100;
			this.TxtNome.Name = "TxtNome";
			this.TxtNome.Size = new System.Drawing.Size(100, 20);
			this.TxtNome.TabIndex = 0;
			// 
			// TxtValor
			// 
			this.TxtValor.Location = new System.Drawing.Point(109, 83);
			this.TxtValor.MaxLength = 9;
			this.TxtValor.Name = "TxtValor";
			this.TxtValor.Size = new System.Drawing.Size(100, 20);
			this.TxtValor.TabIndex = 1;
			this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
			this.TxtValor.Leave += new System.EventHandler(this.TxtValor_Leave);
			// 
			// TxtEmpresa
			// 
			this.TxtEmpresa.Location = new System.Drawing.Point(109, 122);
			this.TxtEmpresa.MaxLength = 100;
			this.TxtEmpresa.Name = "TxtEmpresa";
			this.TxtEmpresa.Size = new System.Drawing.Size(100, 20);
			this.TxtEmpresa.TabIndex = 2;
			// 
			// TxtCat
			// 
			this.TxtCat.Location = new System.Drawing.Point(109, 163);
			this.TxtCat.MaxLength = 100;
			this.TxtCat.Name = "TxtCat";
			this.TxtCat.Size = new System.Drawing.Size(100, 20);
			this.TxtCat.TabIndex = 3;
			this.TxtCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCat_KeyPress);
			// 
			// TxtSubCat
			// 
			this.TxtSubCat.Location = new System.Drawing.Point(109, 201);
			this.TxtSubCat.MaxLength = 100;
			this.TxtSubCat.Name = "TxtSubCat";
			this.TxtSubCat.Size = new System.Drawing.Size(100, 20);
			this.TxtSubCat.TabIndex = 4;
			this.TxtSubCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSubCat_KeyPress);
			// 
			// TxtIcon
			// 
			this.TxtIcon.Location = new System.Drawing.Point(109, 275);
			this.TxtIcon.Name = "TxtIcon";
			this.TxtIcon.ReadOnly = true;
			this.TxtIcon.Size = new System.Drawing.Size(100, 20);
			this.TxtIcon.TabIndex = 6;
			// 
			// PctImage
			// 
			this.PctImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.PctImage.Location = new System.Drawing.Point(265, 47);
			this.PctImage.Name = "PctImage";
			this.PctImage.Size = new System.Drawing.Size(288, 323);
			this.PctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PctImage.TabIndex = 7;
			this.PctImage.TabStop = false;
			// 
			// LblNome
			// 
			this.LblNome.AutoSize = true;
			this.LblNome.Location = new System.Drawing.Point(10, 47);
			this.LblNome.Name = "LblNome";
			this.LblNome.Size = new System.Drawing.Size(35, 13);
			this.LblNome.TabIndex = 8;
			this.LblNome.Text = "Nome";
			// 
			// LblValor
			// 
			this.LblValor.AutoSize = true;
			this.LblValor.Location = new System.Drawing.Point(10, 86);
			this.LblValor.Name = "LblValor";
			this.LblValor.Size = new System.Drawing.Size(31, 13);
			this.LblValor.TabIndex = 9;
			this.LblValor.Text = "Valor";
			// 
			// LblEmpresa
			// 
			this.LblEmpresa.AutoSize = true;
			this.LblEmpresa.Location = new System.Drawing.Point(10, 125);
			this.LblEmpresa.Name = "LblEmpresa";
			this.LblEmpresa.Size = new System.Drawing.Size(48, 13);
			this.LblEmpresa.TabIndex = 10;
			this.LblEmpresa.Text = "Empresa";
			// 
			// LblCategoria
			// 
			this.LblCategoria.AutoSize = true;
			this.LblCategoria.Location = new System.Drawing.Point(12, 166);
			this.LblCategoria.Name = "LblCategoria";
			this.LblCategoria.Size = new System.Drawing.Size(52, 13);
			this.LblCategoria.TabIndex = 11;
			this.LblCategoria.Text = "Categoria";
			// 
			// LblSubCateg
			// 
			this.LblSubCateg.AutoSize = true;
			this.LblSubCateg.Location = new System.Drawing.Point(12, 204);
			this.LblSubCateg.Name = "LblSubCateg";
			this.LblSubCateg.Size = new System.Drawing.Size(74, 13);
			this.LblSubCateg.TabIndex = 12;
			this.LblSubCateg.Text = "Sub Categoria";
			// 
			// LblSexo
			// 
			this.LblSexo.AutoSize = true;
			this.LblSexo.Location = new System.Drawing.Point(12, 242);
			this.LblSexo.Name = "LblSexo";
			this.LblSexo.Size = new System.Drawing.Size(31, 13);
			this.LblSexo.TabIndex = 13;
			this.LblSexo.Text = "Sexo";
			// 
			// LblIcon
			// 
			this.LblIcon.AutoSize = true;
			this.LblIcon.Location = new System.Drawing.Point(10, 278);
			this.LblIcon.Name = "LblIcon";
			this.LblIcon.Size = new System.Drawing.Size(28, 13);
			this.LblIcon.TabIndex = 14;
			this.LblIcon.Text = "Icon";
			// 
			// LblImagem
			// 
			this.LblImagem.AutoSize = true;
			this.LblImagem.Location = new System.Drawing.Point(272, 31);
			this.LblImagem.Name = "LblImagem";
			this.LblImagem.Size = new System.Drawing.Size(39, 13);
			this.LblImagem.TabIndex = 15;
			this.LblImagem.Text = "Image:";
			// 
			// LblEuro
			// 
			this.LblEuro.AutoSize = true;
			this.LblEuro.Location = new System.Drawing.Point(215, 86);
			this.LblEuro.Name = "LblEuro";
			this.LblEuro.Size = new System.Drawing.Size(13, 13);
			this.LblEuro.TabIndex = 16;
			this.LblEuro.Text = "€";
			// 
			// PctAdd
			// 
			this.PctAdd.Image = global::VesteBem_Admin.Properties.Resources.add;
			this.PctAdd.Location = new System.Drawing.Point(218, 275);
			this.PctAdd.Name = "PctAdd";
			this.PctAdd.Size = new System.Drawing.Size(19, 20);
			this.PctAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PctAdd.TabIndex = 17;
			this.PctAdd.TabStop = false;
			this.PctAdd.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// BtnRegistar
			// 
			this.BtnRegistar.Location = new System.Drawing.Point(44, 322);
			this.BtnRegistar.Name = "BtnRegistar";
			this.BtnRegistar.Size = new System.Drawing.Size(151, 48);
			this.BtnRegistar.TabIndex = 18;
			this.BtnRegistar.Text = "Registar Produtos";
			this.BtnRegistar.UseVisualStyleBackColor = true;
			this.BtnRegistar.Click += new System.EventHandler(this.button1_Click);
			// 
			// CboSexo
			// 
			this.CboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CboSexo.FormattingEnabled = true;
			this.CboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Indefenido"});
			this.CboSexo.Location = new System.Drawing.Point(109, 242);
			this.CboSexo.Name = "CboSexo";
			this.CboSexo.Size = new System.Drawing.Size(100, 21);
			this.CboSexo.TabIndex = 19;
			// 
			// FrmAddChangeProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 404);
			this.Controls.Add(this.CboSexo);
			this.Controls.Add(this.BtnRegistar);
			this.Controls.Add(this.PctAdd);
			this.Controls.Add(this.LblEuro);
			this.Controls.Add(this.LblImagem);
			this.Controls.Add(this.LblIcon);
			this.Controls.Add(this.LblSexo);
			this.Controls.Add(this.LblSubCateg);
			this.Controls.Add(this.LblCategoria);
			this.Controls.Add(this.LblEmpresa);
			this.Controls.Add(this.LblValor);
			this.Controls.Add(this.LblNome);
			this.Controls.Add(this.PctImage);
			this.Controls.Add(this.TxtIcon);
			this.Controls.Add(this.TxtSubCat);
			this.Controls.Add(this.TxtCat);
			this.Controls.Add(this.TxtEmpresa);
			this.Controls.Add(this.TxtValor);
			this.Controls.Add(this.TxtNome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmAddChangeProdutos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adicionar Produtos";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddProdutos_FormClosed);
			this.Load += new System.EventHandler(this.FrmAddProdutos_Load);
			((System.ComponentModel.ISupportInitialize)(this.PctImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PctAdd)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtNome;
		private System.Windows.Forms.TextBox TxtValor;
		private System.Windows.Forms.TextBox TxtEmpresa;
		private System.Windows.Forms.TextBox TxtCat;
		private System.Windows.Forms.TextBox TxtSubCat;
		private System.Windows.Forms.TextBox TxtIcon;
		private System.Windows.Forms.PictureBox PctImage;
		private System.Windows.Forms.Label LblNome;
		private System.Windows.Forms.Label LblValor;
		private System.Windows.Forms.Label LblEmpresa;
		private System.Windows.Forms.Label LblCategoria;
		private System.Windows.Forms.Label LblSubCateg;
		private System.Windows.Forms.Label LblSexo;
		private System.Windows.Forms.Label LblIcon;
		private System.Windows.Forms.Label LblImagem;
		private System.Windows.Forms.Label LblEuro;
		private System.Windows.Forms.PictureBox PctAdd;
		private System.Windows.Forms.Button BtnRegistar;
		private System.Windows.Forms.ComboBox CboSexo;
	}
}