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
			Debug.Print(""+Convert.ToDouble("52,8725945"));
			string s = "233,33";
			double result = double.Parse(s);
		}

		private void textBox_MouseLeave(object sender, EventArgs e)
		{
			TextBox txt = sender as TextBox;

			//if(txt.Text.Length==0 || txt.Text.Length>100)
			//txt.BorderStyle=meter a borda a vermelho
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (TxtValor.Text != "" && TxtNome.Text!="" && TxtEmpresa.Text!="" && comboBox1.Text!="" && TxtSubCat.Text!="" && TxtCat.Text!="")
			{
				Produtos produtos = new Produtos();
				produtos.Nome = TxtNome.Text;
				produtos.NomedaEmpresa = TxtEmpresa.Text;
				produtos.Sexo = comboBox1.Text.Substring(0,1);
				produtos.valor = double.Parse(TxtValor.Text);
				produtos.CategoriaClass = TxtCat.Text;
				produtos.CategoriaSubClass = TxtSubCat.Text;
				var ds=TxtIcon.Text!=null?produtos.Icon= TxtIcon.Text:produtos.Icon="NULL";
				CreateProdutos.InsertProdutos(produtos);
			}
		}
		
		private void TxtValor_Leave(object sender, EventArgs e)
		{
			if (TxtValor.Text.Contains("."))
				TxtValor.Text = TxtValor.Text.Replace('.', ',');
			if (!TxtValor.Text.Contains(',') && TxtValor.Text!="")
				TxtValor.Text += ",00";
			if(TxtValor.Text.Contains('-'))//if (Math.Abs(TxtValor.Text) < 0.001)//|| TxtValor.Text.Contains('-')
				TxtValor.Text = "";
			if (Regex.IsMatch(TxtValor.Text, @"\,\d\d"))
			{
				string[] ds = TxtValor.Text.Split(',');
				TxtValor.Text = "" + ds[0] + "," + ds[1].Substring(0, 2);
			}

		}

		private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar);
		}

		private void TxtCat_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
		}

		private void TxtSubCat_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
		}

	}
}
