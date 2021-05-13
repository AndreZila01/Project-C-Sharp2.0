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
		List<DetalhesEncomendas> lstDetalhesEncomendas = new List<DetalhesEncomendas>();
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
			{
				DetalhesEncomendas Detalhes = new DetalhesEncomendas();
				Panel Pnl = new Panel();
				Pnl.Location = new System.Drawing.Point(0, 0);
				Pnl.Name = "panel1";
				Pnl.BackColor = Color.Red;
				Pnl.Size = new System.Drawing.Size(245, 30);//271; 150
				Pnl.TabIndex = 0;
				flowLayoutPanel1.Controls.Add(Pnl);

				Label LblNome = new Label();
				LblNome.AutoSize = true;
				LblNome.Location = new System.Drawing.Point(5, 10);
				LblNome.Name = "label6";
				LblNome.Size = new System.Drawing.Size(35, 13);
				LblNome.TabIndex = 0;
				LblNome.BackColor = Color.LightGray;
				LblNome.Tag = pictureBox1.Tag.ToString();
				var ds = lstProduto[int.Parse(pictureBox1.Tag.ToString())].Nome.Length > 20 ? LblNome.Text = "" + lstProduto[int.Parse(pictureBox1.Tag.ToString())].Nome.Substring(0, 20) : LblNome.Text = "" + lstProduto[int.Parse(pictureBox1.Tag.ToString())].Nome;
				LblNome.Click += new System.EventHandler(label_Click);
				Pnl.Controls.Add(LblNome);

				Label LblPreco = new Label();
				LblPreco.AutoSize = true;
				LblPreco.Location = new System.Drawing.Point(160, 10);
				LblPreco.Name = "label7";
				LblPreco.Size = new System.Drawing.Size(25, 13);
				LblPreco.TabIndex = 1;
				LblPreco.BackColor = Color.Green;
				LblPreco.Text = "" + lstProduto[int.Parse(pictureBox1.Tag.ToString())].Valor + "€";
				LblPreco.Tag = "" + lstProduto[int.Parse(pictureBox1.Tag.ToString())].Valor;
				Pnl.Controls.Add(LblPreco);

				Label LblQuantidade = new Label();
				LblQuantidade.Location = new System.Drawing.Point(140, 10);
				LblQuantidade.Name = "label7";
				LblQuantidade.Size = new System.Drawing.Size(35, 13);
				LblQuantidade.TabIndex = 1;
				LblQuantidade.BackColor = Color.Gray;
				LblQuantidade.Text = " " + numericUpDown1.Value + " x";
				LblQuantidade.Tag = "" + numericUpDown1.Value;
				Pnl.Controls.Add(LblQuantidade);

				PictureBox PctRemove = new PictureBox();
				PctRemove.Image = Properties.Resources.Red_Remove;
				PctRemove.Location = new System.Drawing.Point(225, 10);
				PctRemove.Size = new System.Drawing.Size(15, 13);
				PctRemove.SizeMode = PictureBoxSizeMode.Zoom;
				PctRemove.Click += new System.EventHandler(PctRemove_Click);
				PctRemove.MouseLeave += new System.EventHandler(PctRemove_MouseLeave);
				PctRemove.MouseEnter += new System.EventHandler(PctRemove_MouseEnter);
				PctRemove.Tag = "" + lstDetalhesEncomendas.Count();
				Pnl.Controls.Add(PctRemove);

				label6.Tag = "" + (double.Parse(label6.Tag.ToString()) + ((int.Parse(LblQuantidade.Tag.ToString()) * double.Parse(LblPreco.Tag.ToString()))));
				label6.Text = "Total: " + label6.Tag + "€";


				Detalhes.Id_Produtos = lstProduto[int.Parse(pictureBox1.Tag.ToString())].IdProduto;
				Detalhes.QuantEnc = int.Parse(numericUpDown1.Value.ToString());
				lstDetalhesEncomendas.Add(Detalhes);
			}
		}

		private void PctRemove_MouseEnter(object sender, EventArgs e)
		{
			
		}

		private void PctRemove_MouseLeave(object sender, EventArgs e)
		{
			try
			{

			}catch
			{

			}
		}

		private void PctRemove_Click(object sender, EventArgs e)
		{
			int value = 0;
			flowLayoutPanel1.Controls.Clear();
			PictureBox Pct = sender as PictureBox;
			lstDetalhesEncomendas.RemoveAt(int.Parse(Pct.Tag.ToString())); label6.Tag = "00";
			lstDetalhesEncomendas.ToList().ForEach(item =>
			{
				int index = lstProduto.FindIndex(r => r.IdProduto == item.Id_Produtos);
				DetalhesEncomendas Detalhes = new DetalhesEncomendas();
				Panel Pnl = new Panel();
				Pnl.Location = new System.Drawing.Point(0, 0);
				Pnl.Name = "panel1";
				Pnl.BackColor = Color.Red;
				Pnl.Size = new System.Drawing.Size(245, 30);//271; 150
				Pnl.TabIndex = 0;
				flowLayoutPanel1.Controls.Add(Pnl);

				Label LblNome = new Label();
				LblNome.AutoSize = true;
				LblNome.Location = new System.Drawing.Point(5, 10);
				LblNome.Name = "label6";
				LblNome.Size = new System.Drawing.Size(35, 13);
				LblNome.TabIndex = 0;
				LblNome.BackColor = Color.LightGray;
				LblNome.Tag = pictureBox1.Tag.ToString();
				var ds = lstProduto[index].Nome.Length > 20 ? LblNome.Text = "" + lstProduto[index].Nome.Substring(0, 20) : LblNome.Text = "" + lstProduto[index].Nome;
				LblNome.Click += new System.EventHandler(label_Click);
				Pnl.Controls.Add(LblNome);

				Label LblPreco = new Label();
				LblPreco.AutoSize = true;
				LblPreco.Location = new System.Drawing.Point(160, 10);
				LblPreco.Name = "label7";
				LblPreco.Size = new System.Drawing.Size(25, 13);
				LblPreco.TabIndex = 1;
				LblPreco.BackColor = Color.Green;
				LblPreco.Text = "" + lstProduto[index].Valor + "€";
				LblPreco.Tag = "" + lstProduto[index].Valor;
				Pnl.Controls.Add(LblPreco);

				Label LblQuantidade = new Label();
				LblQuantidade.Location = new System.Drawing.Point(140, 10);
				LblQuantidade.Name = "label7";
				LblQuantidade.Size = new System.Drawing.Size(35, 13);
				LblQuantidade.TabIndex = 1;
				LblQuantidade.BackColor = Color.Gray;
				LblQuantidade.Text = " " + numericUpDown1.Value + " x";
				LblQuantidade.Tag = "" + numericUpDown1.Value;
				Pnl.Controls.Add(LblQuantidade);

				PictureBox PctRemove = new PictureBox();
				PctRemove.Image = Properties.Resources.Red_Remove;
				PctRemove.Location = new System.Drawing.Point(225, 10);
				PctRemove.Size = new System.Drawing.Size(15, 13);
				PctRemove.SizeMode = PictureBoxSizeMode.Zoom;
				PctRemove.Click += new System.EventHandler(PctRemove_Click);
				PctRemove.MouseLeave += new System.EventHandler(PctRemove_MouseLeave);
				PctRemove.MouseEnter += new System.EventHandler(PctRemove_MouseEnter);
				PctRemove.Tag = "" + value;
				Pnl.Controls.Add(PctRemove);

				label6.Tag = "" + (double.Parse(label6.Tag.ToString()) + ((item.QuantEnc * lstProduto[index].Valor)));
				label6.Text = "Total: " + label6.Tag + "€";
				value++;
			});
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
