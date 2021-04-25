using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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

		private void textBox_MouseLeave(object sender, EventArgs e)
		{
			TextBox txt = sender as TextBox;

			//if(txt.Text.Length==0 || txt.Text.Length>100)
			//txt.BorderStyle=meter a borda a vermelho
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (TxtValor.Text != "" && TxtNome.Text!="" && TxtEmpresa.Text!="" && TxtSexo.Text!="" && TxtSubCat.Text!="" && TxtCat.Text!="")
			{
				Produtos produtos = new Produtos();
				produtos.Nome = TxtNome.Text;
				produtos.NomedaEmpresa = TxtEmpresa.Text;
				produtos.Sexo = TxtSexo.Text;
				produtos.valor = Double.Parse(TxtValor.Text);
				produtos.CategoriaClass = TxtCat.Text;
				produtos.CategoriaSubClass = TxtSubCat.Text;
				var ds=produtos.Icon!=null?produtos.Icon= TxtIcon.Text:produtos.Icon="NULL";
				//var ts=pE_PauseaPlay.Tag.ToString()=="0"? Processo="pause": Processo="start";
				CreateProdutos.InsertProdutos(produtos);
			}
		}
		string[] certificar;
		private void TxtValor_Leave(object sender, EventArgs e)
		{
			if (!TxtValor.Text.Contains('.') && TxtValor.Text!="")
				TxtValor.Text += ".00";
			if(TxtValor.Text.Contains('-'))//if (Math.Abs(TxtValor.Text) < 0.001)//|| TxtValor.Text.Contains('-')
				TxtValor.Text = "";
			if (TxtValor.Text.Length > 5)
			{
				string[] ds = TxtValor.Text.Split('.');
				if (ds[1].Length > 3)
				{
					Double dss = double.Parse(TxtValor.Text, System.Globalization.CultureInfo.InvariantCulture);
					TxtValor.Text = (Math.Round(dss, 2)).ToString();
					
					//TxtValor.Text = (Math.Round(double.Parse(TxtValor.Text), 2)).ToString();
				}
			}
		}
	}
}
