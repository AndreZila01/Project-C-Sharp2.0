using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;
using static VesteBem_Admin.Estado;

namespace VesteBem_Admin
{
	public partial class FrmCarrinho : Form
	{
		public FrmCarrinho()
		{
			InitializeComponent();
		}
		List<string> lstEstado = new List<string>();
		List<Encomenda> lstEncomenda = new List<Encomenda>();
		List<Cliente> lstcli = new List<Cliente>();
		List<Produtos> lstProduto = new List<Produtos>();
		private void FrmCarrinho_Load(object sender, EventArgs e)
		{
			label6.Tag = "00";
			lstEstado = Estado.SelectFuncao();
			lstEstado.ToList().ForEach(item =>
			{
				comboBox2.Items.Add(item);
			});
			lstcli = Estado.SelectId();
			lstcli.ToList().ForEach(item =>
			{
				comboBox2.Items.Add(item.Nome);
			});
			lstProduto = Estado.SelectProdutos();
			lstProduto.ToList().ForEach(item =>
			{
				comboBox3.Items.Add(item.IdProduto + " - " + item.Nome);
			});


		}
		private void button2_Click(object sender, EventArgs e)
		{
			//if (lstEncomenda)
			{

				DetalhesEncomendas Detalhes = new DetalhesEncomendas();
				Panel pnl = new Panel();
				pnl.Location = new System.Drawing.Point(0, 0);
				pnl.Name = "panel1";
				pnl.BackColor = Color.Red;
				pnl.Size = new System.Drawing.Size(245, 30);//271; 150
				pnl.TabIndex = 0;
				flowLayoutPanel1.Controls.Add(pnl);

				Label lblNome = new Label();
				lblNome.AutoSize = true;
				lblNome.Location = new System.Drawing.Point(5, 5);
				lblNome.Name = "label6";
				lblNome.Size = new System.Drawing.Size(35, 13);
				lblNome.TabIndex = 0;
				lblNome.BackColor = Color.LightGray;
				lblNome.Tag = pictureBox1.Tag.ToString();
				var ds = lstProduto[int.Parse(pictureBox1.Tag.ToString())].Nome.Length > 20 ? lblNome.Text = "" + lstProduto[int.Parse(pictureBox1.Tag.ToString())].Nome.Substring(0, 20) : lblNome.Text = "" + lstProduto[int.Parse(pictureBox1.Tag.ToString())].Nome;
				lblNome.Click += new System.EventHandler(label_Click);
				pnl.Controls.Add(lblNome);

				Label lblPreco = new Label();
				lblPreco.AutoSize = true;
				lblPreco.Location = new System.Drawing.Point(191, 5);
				lblPreco.Name = "label7";
				lblPreco.Size = new System.Drawing.Size(35, 13);
				lblPreco.TabIndex = 1;
				lblPreco.BackColor = Color.Green;
				lblPreco.Text = "" + lstProduto[int.Parse(pictureBox1.Tag.ToString())].Valor + "€";
				lblPreco.Tag = "" + lstProduto[int.Parse(pictureBox1.Tag.ToString())].Valor;
				pnl.Controls.Add(lblPreco);

				Label lblQuantidade = new Label();
				lblQuantidade.Location = new System.Drawing.Point(148, 5);
				lblQuantidade.Name = "label7";
				lblQuantidade.Size = new System.Drawing.Size(35, 13);
				lblQuantidade.TabIndex = 1;
				lblQuantidade.BackColor = Color.Gray;
				lblQuantidade.Text = " " + numericUpDown1.Value + " x";
				lblQuantidade.Tag = "" + numericUpDown1.Value;
				pnl.Controls.Add(lblQuantidade);

				label6.Tag = "" + (double.Parse(label6.Tag.ToString()) + ((int.Parse(lblQuantidade.Tag.ToString()) * double.Parse(lblPreco.Tag.ToString()))));
				label6.Text = "Total: " + label6.Tag + "€";


				Detalhes.Id_Produtos = lstProduto[int.Parse(pictureBox1.Tag.ToString())].IdProduto;
				Detalhes.QuantEnc = int.Parse(numericUpDown1.Value.ToString());
				List<Author> authors = new List<Author>
{
	new Author { Name = "Mahesh Chand", Book = "Apress", Price = 49.95 },
	new Author { Name = "Neel Beniwal", Book = "Apress", Price = 19.95 },
	new Author { Name = "Chris Love", Book = "PakT", Price = 29.95 }
};
			}
		}

		private void label_Click(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			MessageBox.Show("" + lstProduto[int.Parse(lbl.Tag.ToString())].Nome);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//SqlCommand command = new SqlCommand();
			//using (SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			//{
			//	command.CommandText = "SPUpdateCliente";
			//	command.CommandType = System.Data.CommandType.StoredProcedure;
			//	try
			//	{
			//		command.Parameters.Add(new SqlParameter("Nome", cli.Nome));
			//		command.Parameters.Add(new SqlParameter("Sexo", cli.Sexo));
			//		command.Parameters.Add(new SqlParameter("Nif", cli.Nif));
			//		command.Parameters.Add(new SqlParameter("Morada", cli.Morada));
			//		command.Parameters.Add(new SqlParameter("CodPostal", cli.CodPostal));
			//		command.Parameters.Add(new SqlParameter("Localidade", cli.Localidade));
			//		command.Parameters.Add(new SqlParameter("DataNasc", cli.DataNasc));
			//		command.Parameters.Add(new SqlParameter("Email", cli.Email));
			//		command.Parameters.Add(new SqlParameter("Telefone", cli.Telefone));
			//		command.Parameters.Add(new SqlParameter("Id_Cliente", cli.Id_Cliente));
			//		command.Parameters.Add(new SqlParameter("Id_Login", cli.Id_Login));

			//		command.Connection = liga;

			//		liga.Open();

			//		command.ExecuteNonQuery();
			//		return "sucesso";
			//	}
			//	catch (Exception ex)
			//	{
			//		return ex.Message;
			//	}
			//	finally
			//	{
			//		liga.Close();
			//	}
			//}
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

			pictureBox1.Image = lstProduto[comboBox3.SelectedIndex].Icon;
			pictureBox1.Tag = comboBox3.SelectedIndex;
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Encomenda en = new Encomenda();
			en.ValorEncomendas = double.Parse(label6.Text.ToString());

			//Certificar se o utilizador meteu varias vezes os produtos
		}
	}
	public class Estado
	{
		public class Encomenda
		{
			public int IdEncomendas { get; set; }
			public double ValorEncomendas { get; set; }
			public int Id_EstadoEncomendas { get; set; }
			public string EstadoEncomendas { get; set; }
			public DateTime DataEncomenda { get; set; }
			public DateTime DataEntrega { get; set; }
			public int Id_Cliente { get; set; }
			public List<DetalhesEncomendas> DetalhesEncomendas { get; set; }
		}

		public class DetalhesEncomendas
		{
			public int Id_Encomendas { get; set; }
			public int Id_Produtos { get; set; }
			public int QuantEnc { get; set; }
		}

		public static List<Produtos> SelectProdutos()
		{
			List<Produtos> lstProdutos = new List<Produtos>();
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select * From tbl_Produtos", liga);
			SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
			try
			{
				ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
				string str = string.Empty;
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				comando.Connection = liga;
				liga.Open();
				using (SqlDataReader oReader = comando.ExecuteReader())
				{
					int ds = 0;
					while (oReader.Read())
					{
						Produtos pro = new Produtos();
						try
						{
							Byte[] data = new Byte[0];
							data = (Byte[])(dataSet.Tables[0].Rows[ds]["Icon"]);
							MemoryStream mem = new MemoryStream(data);

							pro.Icon = Image.FromStream(mem);
						}
						catch
						{
							pro.Icon = Properties.Resources.user;
						}
						pro.IdProduto = int.Parse(oReader["IdProduto"].ToString());
						pro.Nome = oReader["Nome"].ToString();
						pro.Valor = double.Parse(oReader["Valor"].ToString());
						pro.NomedaEmpresa = (oReader["NomedaEmpresa"].ToString());
						pro.CategoriaClass = oReader["CategoriaClasse"].ToString();
						pro.CategoriaSubClass = oReader["CategoriaSubClasse"].ToString();
						pro.Sexo = oReader["Sexo"].ToString();
						ds++;
						lstProdutos.Add(pro);
					}
				}
			}
			catch
			{

			}
			finally
			{
				liga.Close();
			}

			return lstProdutos;
			//List<Produtos> lstProduto = new List<Produtos>();
			//SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			//SqlCommand comando = new SqlCommand("Select * From tbl_Produtos", liga);
			//try
			//{
			//	DataSet dataSet = new DataSet();
			//	SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
			//	dataAdapter.Fill(dataSet);
			//	comando.Connection = liga;
			//	liga.Open();
			//	using (SqlDataReader oReader = comando.ExecuteReader())
			//	{
			//		ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

			//		int dss = 0;
			//		while (oReader.Read())
			//		{
			//			Byte[] data = new Byte[0];
			//			data = (Byte[])(dataSet.Tables[0].Rows[dss]["Icon"]);
			//			MemoryStream mem = new MemoryStream(data);

			//			Produtos pro = new Produtos();
			//			pro.Icon = Image.FromStream(mem);
			//			pro.IdProduto = int.Parse(oReader["IdProduto"].ToString());
			//			pro.Nome = (oReader["Nome"].ToString());
			//			pro.Valor = double.Parse(oReader["Valor"].ToString());
			//			pro.NomedaEmpresa = (oReader["NomedaEmpresa"].ToString());
			//			pro.CategoriaClass = (oReader["CategoriaClasse"].ToString());
			//			pro.CategoriaSubClass = (oReader["CategoriaSubClasse"].ToString());
			//			pro.Sexo = (oReader["Sexo"].ToString());
			//			dss++;
			//			lstProduto.Add(pro);
			//		}
			//	}
			//}
			//catch(Exception ex)
			//{
			//	return null;
			//}
			//finally
			//{
			//	liga.Close();
			//}

			//return lstProduto;
		}
		public static List<string> SelectFuncao()
		{
			List<string> lst = new List<string>();
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select Estado From tblEstado", liga);
			try
			{
				comando.Connection = liga;
				liga.Open();
				using (SqlDataReader oReader = comando.ExecuteReader())
				{
					while (oReader.Read())
					{
						lst.Add(oReader["Estado"].ToString());
					}
				}
			}
			catch
			{
				return null;
			}
			finally
			{
				liga.Close();
			}

			return lst;
		}
		public static List<Cliente> SelectId()
		{
			List<Cliente> lstcli = new List<Cliente>();
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select IdCliente, Nome From tbl_Cliente", liga);
			try
			{
				comando.Connection = liga;
				liga.Open();
				using (SqlDataReader oReader = comando.ExecuteReader())
				{
					while (oReader.Read())
					{
						Cliente cli = new Cliente();
						cli.Id_Cliente = (int.Parse(oReader["IdCliente"].ToString()));
						cli.Nome = oReader["Nome"].ToString();

						lstcli.Add(cli);
					}
					liga.Close();
				}
			}
			catch
			{
				return null;
			}

			return lstcli;
		}
	}
}
