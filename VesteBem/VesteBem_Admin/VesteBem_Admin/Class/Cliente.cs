using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VesteBem_Admin.Class
{
	public class ConsultaClientes
	{
		public static List<Cliente> ConsultaCliente()
		{
			List<Cliente> lstcliclidoutors = new List<Cliente>();
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("select * From tbl_Cliente", liga);
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
						Cliente cli = new Cliente();
						try
						{
							Byte[] data = new Byte[0];
							data = (Byte[])(dataSet.Tables[0].Rows[ds]["Icon"]);
							MemoryStream mem = new MemoryStream(data);

							cli.Icon = Image.FromStream(mem);
						}
						catch
						{
							cli.Icon = Properties.Resources.user;
						}
						cli.Id_Cliente = int.Parse(oReader["IdCliente"].ToString());
						cli.Nome = oReader["Nome"].ToString();
						cli.Sexo = oReader["Sexo"].ToString();
						cli.Id_Login = int.Parse(oReader["Id_Login"].ToString());
						cli.Morada = oReader["Morada"].ToString();
						cli.CodPostal = oReader["CodPostal"].ToString();
						cli.Localidade = oReader["Localidade"].ToString();
						cli.DataNasc = DateTime.Parse(oReader["DataNasc"].ToString());
						cli.Email = oReader["Email"].ToString();
						cli.Telefone = oReader["Telefone"].ToString();
						cli.Nif = oReader["Nif"].ToString();
						ds++;
						lstcliclidoutors.Add(cli);
					}
					liga.Close();
				}
			}
			catch (Exception ex)
			{

			}
			return lstcliclidoutors;
		}
	}
	public class InsertClientes
	{
		public static string InsertCliente(Cliente cli)
		{
			SqlCommand command = new SqlCommand();
			using (SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			{
				command.CommandText = "SPUpdateCliente";
				command.CommandType = System.Data.CommandType.StoredProcedure;
				try
				{
					command.Parameters.Add(new SqlParameter("Nome", cli.Nome));
					command.Parameters.Add(new SqlParameter("Sexo", cli.Sexo));
					command.Parameters.Add(new SqlParameter("Nif", cli.Nif));
					command.Parameters.Add(new SqlParameter("Morada", cli.Morada));
					command.Parameters.Add(new SqlParameter("CodPostal", cli.CodPostal));
					command.Parameters.Add(new SqlParameter("Localidade", cli.Localidade));
					command.Parameters.Add(new SqlParameter("DataNasc", cli.DataNasc));
					command.Parameters.Add(new SqlParameter("Email", cli.Email));
					command.Parameters.Add(new SqlParameter("Telefone", cli.Telefone));
					command.Parameters.Add(new SqlParameter("Id_Cliente", cli.Id_Cliente));
					command.Parameters.Add(new SqlParameter("Id_Login", cli.Id_Login));

					command.Connection = liga;

					liga.Open();

					command.ExecuteNonQuery();
					return "sucesso";
				}
				catch (Exception ex)
				{
					return ex.Message;
				}

			}
		}
	}
	public class ApagarClientes
	{
		public static string ApagarCliente(int id_Cli, string Nome)
		{
			SqlCommand command = new SqlCommand();
			using (SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			{
				command.CommandText = "Delete tbl_Cliente where IdCliente=" + id_Cli + " and Nome='" + Nome + "'";
				try
				{
					command.Connection = liga;

					liga.Open();

					command.ExecuteNonQuery();
					return "sucesso";
				}
				catch (Exception ex)
				{
					return ex.Message;
				}

			}
		}
	}
	public class ConsultarFuncionarios
	{
		public static List<Funcionario> ConsultarFuncionario()
		{
			List<Funcionario> lstFun = new List<Funcionario>();
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select IdFuncionario, Nome, Telemovel, Id_Login, Funcao From tbl_Funcionario, tblFuncao where tbl_Funcionario.Id_Funcao=tblFuncao.IdFuncao", liga);
			try
			{
				comando.Connection = liga;
				liga.Open();
				using (SqlDataReader oReader = comando.ExecuteReader())
				{
					while (oReader.Read())
					{
						Funcionario fun = new Funcionario();
						fun.IdFuncionario = int.Parse(oReader["IdFuncionario"].ToString());
						fun.Funcao = oReader["Funcao"].ToString();
						fun.Id_Login = int.Parse(oReader["Id_Login"].ToString());
						fun.Nome = oReader["Nome"].ToString();
						fun.Telemovel = oReader["Telemovel"].ToString();

						lstFun.Add(fun);
					}
					liga.Close();
				}
			}
			catch (Exception ex)
			{

			}
			return lstFun;
		}

	}

	public class ColectIdFun
	{
		public static string SelectName(int id_logi)
		{
			string nome = "";
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select Usern From tbl_Funcionario, tbl_login where tbl_Funcionario.Id_Login = tbl_login.IdLogin", liga);
			try
			{
				comando.Connection = liga;
				liga.Open();
				using (SqlDataReader oReader = comando.ExecuteReader())
				{
					while (oReader.Read())
					{
						Funcionario fun = new Funcionario();
						nome = oReader["Usern"].ToString();
						liga.Close();
						break;

					}
				}
			}
			catch
			{
				return null;
			}

			return nome;
		}

		public static string SelectPass(int id_logi)
		{
			string pass = "";
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select Usern From tbl_Funcionario, tbl_login where tbl_Funcionario.Id_Login = tbl_login.IdLogin", liga);
			try
			{
				comando.Connection = liga;
				liga.Open();
				using (SqlDataReader oReader = comando.ExecuteReader())
				{
					while (oReader.Read())
					{
						Funcionario fun = new Funcionario();
						pass = oReader["Usern"].ToString();
						pass = EncryptADeDecrypt.EncryptRSA(pass);
						liga.Close();
						break;

					}
				}
			}
			catch
			{
				return null;
			}
			return pass;
		}

	}
}
