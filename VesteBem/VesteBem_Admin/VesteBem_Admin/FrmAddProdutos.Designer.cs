namespace VesteBem_Admin
{
	partial class FrmAddProdutos
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
			this.TxtNome = new System.Windows.Forms.TextBox();
			this.TxtValor = new System.Windows.Forms.TextBox();
			this.TxtEmpresa = new System.Windows.Forms.TextBox();
			this.TxtCat = new System.Windows.Forms.TextBox();
			this.TxtSubCat = new System.Windows.Forms.TextBox();
			this.TxtIcon = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.pictureBox1.Location = new System.Drawing.Point(265, 47);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(288, 323);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Valor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Empresa";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 166);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Categoria";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Sub Categoria";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 242);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Sexo";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 278);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(28, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Icon";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(272, 31);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Image:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(215, 86);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(13, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "€";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::VesteBem_Admin.Properties.Resources.add;
			this.pictureBox2.Location = new System.Drawing.Point(218, 275);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(19, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 17;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(44, 322);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(151, 48);
			this.button1.TabIndex = 18;
			this.button1.Text = "Registar Produtos";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Indefenido"});
			this.comboBox1.Location = new System.Drawing.Point(109, 242);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 19;
			// 
			// FrmAddProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 404);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.TxtIcon);
			this.Controls.Add(this.TxtSubCat);
			this.Controls.Add(this.TxtCat);
			this.Controls.Add(this.TxtEmpresa);
			this.Controls.Add(this.TxtValor);
			this.Controls.Add(this.TxtNome);
			this.Name = "FrmAddProdutos";
			this.Text = "FrmAddProdutos";
			this.Load += new System.EventHandler(this.FrmAddProdutos_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}