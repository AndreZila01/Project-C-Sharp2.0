using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;

namespace VesteBem_Admin
{
	public partial class FrmAddProdutos : Form
	{
		SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		SqlCommand command = new SqlCommand();
		public FrmAddProdutos()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

			OpenFileDialog ofd = new OpenFileDialog(); ofd.Multiselect = false; ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				TxtIcon.Text = ofd.FileNames[0].ToString();
				pictureBox1.ImageLocation = ofd.FileName.ToString();

			}
		}

		private void FrmAddProdutos_Load(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (TxtValor.Text != "" && TxtNome.Text != "" && TxtEmpresa.Text != "" && comboBox1.Text != "" && TxtSubCat.Text != "" && TxtCat.Text != "") 
				{
					Produtos produtos = new Produtos();
					produtos.Nome = TxtNome.Text;
					produtos.NomedaEmpresa = TxtEmpresa.Text;
					produtos.Sexo = comboBox1.Text.Substring(0, 1);
					produtos.Valor = double.Parse(TxtValor.Text);
					produtos.CategoriaClass = TxtCat.Text;
					produtos.CategoriaSubClass = TxtSubCat.Text;
					produtos.CaminhoImg = TxtIcon.Text;
					string dss = CreateProdutos.InsertProdutos(produtos);

					if (dss == "Correu bem")
					{
						TxtCat.Text = null;
						TxtIcon.Text = null;
						TxtNome.Text = null;
						TxtSubCat.Text = null;
						TxtValor.Text = null;
						TxtEmpresa.Text = null;
					}

				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(""+ex.Message, "Eror 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void TxtValor_Leave(object sender, EventArgs e)
		{
			if (TxtValor.Text.Contains("."))
				TxtValor.Text = TxtValor.Text.Replace('.', ',');
			if (!TxtValor.Text.Contains(',') && TxtValor.Text!="")
				TxtValor.Text += ",00";
			if(TxtValor.Text.Contains('-'))
				TxtValor.Text = "";
			if (Regex.IsMatch(TxtValor.Text, @"\,\d\d"))
			{
				string[] ds = TxtValor.Text.Split(',');
				TxtValor.Text = "" + ds[0] + "," + ds[1].Substring(0, 2);
			}

		}

		private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar!='.' && e.KeyChar != '\u0016' && e.KeyChar != '\b')
			e.Handled = !char.IsDigit(e.KeyChar);
		}

		private void TxtCat_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '\u0016' && e.KeyChar != '\b')
				e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
		}

		private void TxtSubCat_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar!='\u0016' && e.KeyChar != '\b')
				e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
		}

		private void FrmAddProdutos_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormCollection fc = Application.OpenForms;
			foreach (Form frm in fc)
				frm.WindowState = FormWindowState.Normal;
		}
	}
}
