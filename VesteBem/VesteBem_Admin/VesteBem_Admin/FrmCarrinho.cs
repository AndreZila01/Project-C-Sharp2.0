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

namespace VesteBem_Admin
{
	public partial class FrmCarrinho : Form
	{
		public FrmCarrinho()
		{
			InitializeComponent();
		}
		List<string> lstEstado = new List<string>();
		List<Cliente> lstcli = new List<Cliente>();
		List<Produtos> lstProduto = new List<Produtos>();
		private void FrmCarrinho_Load(object sender, EventArgs e)
		{
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
				comboBox3.Items.Add(item.IdProduto +" - "+item.Nome);
			});


		}
		private void button2_Click(object sender, EventArgs e)
		{

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
		}
	}
	public class Estado
	{
		public static List<Produtos> SelectProdutos()
		{
			List<Produtos> lstProduto = new List<Produtos>();
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select * From tbl_Produtos", liga);
			try
			{
				DataSet dataSet = new DataSet();
				SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
				dataAdapter.Fill(dataSet);
				comando.Connection = liga;
				liga.Open();
				using (SqlDataReader oReader = comando.ExecuteReader())
				{
					ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
					
					int dss = 0;
					while (oReader.Read())
					{
						Byte[] data = new Byte[0];
						data = (Byte[])(dataSet.Tables[0].Rows[dss]["Icon"]);
						MemoryStream mem = new MemoryStream(data);

						Produtos pro = new Produtos();
						pro.Icon = Image.FromStream(mem);
						pro.IdProduto = int.Parse(oReader["IdProduto"].ToString());
						pro.Nome = (oReader["Nome"].ToString());
						pro.Valor = double.Parse(oReader["Valor"].ToString());
						pro.NomedaEmpresa = (oReader["NomedaEmpresa"].ToString());
						pro.CategoriaClass = (oReader["CategoriaClasse"].ToString());
						pro.CategoriaSubClass = (oReader["CategoriaSubClasse"].ToString());
						pro.Sexo = (oReader["Sexo"].ToString());
						dss++;
						lstProduto.Add(pro);
					}
				}
			}
			catch(Exception ex)
			{
				return null;
			}
			finally
			{
				liga.Close();
			}

			return lstProduto;
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
