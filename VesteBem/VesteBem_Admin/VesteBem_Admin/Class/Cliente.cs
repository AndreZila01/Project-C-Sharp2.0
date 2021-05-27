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
using VesteBem_Admin.Class;

namespace VesteBem_Admin.Class
{
	public class Clientes
	{
		public static int SelectIdCliente(string cli)
		{
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select IdCliente From tbl_Cliente WHERE Nome like '" + cli + "'", liga);
			int idcli = 0;
			try
			{
				comando.Connection = liga;
				liga.Open();
				using (SqlDataReader oReader = comando.ExecuteReader())
				{
					if (oReader.Read())
						idcli = int.Parse(oReader["IdCliente"].ToString());


				}
				return idcli;
			}
			catch
			{
				return idcli;
			}

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
				}
			}
			catch
			{

			}
			finally
			{
				liga.Close();
			}

			return lstcliclidoutors;
		}
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
				finally
				{
					liga.Close();
				}
			}
		}
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
				finally
				{
					liga.Close();
				}

			}
		}
	}
	public class Funcionarios
	{
		public static List<Funcao> SelectFuncao()
		{
			List<Funcao> lst = new List<Funcao>();
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select  IdFuncao, Funcao From tblFuncao", liga);
			try
			{
				comando.Connection = liga;
				liga.Open();
				using (SqlDataReader oReader = comando.ExecuteReader())
				{
					while (oReader.Read())
					{
						Funcao Fun = new Funcao();
						Fun.IdFuncao = int.Parse(oReader["IdFuncao"].ToString());
						Fun.Funcoes = oReader["Funcao"].ToString();
						lst.Add(Fun);
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
		public static List<Estados> SelectEstado()
		{
			List<Estados> lst = new List<Estados>();
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select IdEstado, Estado From tblEstado", liga);
			try
			{
				comando.Connection = liga;
				liga.Open();
				using (SqlDataReader oReader = comando.ExecuteReader())
				{
					while (oReader.Read())
					{
						Estados est = new Estados();
						est.IdEstado = int.Parse(oReader["IdEstado"].ToString());
						est.Estado = (oReader["Estado"].ToString());
						lst.Add(est);
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
		public static List<Funcionario> ConsultarFuncionario()
		{
			List<Funcionario> lstFun = new List<Funcionario>();
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select IdFuncionario, Nome, Telemovel, Usern, Id_Login, Funcao, passw From tbl_Funcionario, tblFuncao, tbl_login where tbl_Funcionario.Id_Funcao=tblFuncao.IdFuncao and tbl_login.Funcionario=1 and tbl_Funcionario.Id_Login=tbl_login.IdLogin", liga);
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
						fun.Username = EncryptADeDecrypt.DecryptOther(oReader["Usern"].ToString());
						fun.Pass = EncryptADeDecrypt.DecryptRSA(oReader["Passw"].ToString());

						lstFun.Add(fun);
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
			return lstFun;
		}
		public static string AtualizarFuncionario(Funcionario fun)
		{
			SqlCommand command = new SqlCommand();
			List<Funcionario> lstFun = new List<Funcionario>();
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

			command.CommandText = "SPUpdateFuncionarios";
			command.CommandType = System.Data.CommandType.StoredProcedure;
			try
			{
				string user = "" + EncryptADeDecrypt.EncryptOther(fun.Username);
				string pass = "" + EncryptADeDecrypt.EncryptRSA(fun.Pass);
				command.Parameters.Add(new SqlParameter("Id_Funcao", fun.id_Funcao));
				command.Parameters.Add(new SqlParameter("Nome", fun.Nome));
				command.Parameters.Add(new SqlParameter("Telemovel", fun.Telemovel));
				command.Parameters.Add(new SqlParameter("Id_Login", fun.Id_Login));
				command.Parameters.Add(new SqlParameter("UserN", user));
				command.Parameters.Add(new SqlParameter("Passw", pass));

				command.Connection = liga;

				liga.Open();

				command.ExecuteNonQuery();
				return "sucesso";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
			finally
			{
				liga.Close();
			}
		}

		public static string InsertFuncionario(Funcionario fun)
		{

			using (SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			{
				SqlCommand command = new SqlCommand();
				command.CommandText = "SpInsertLogin";
				command.CommandType = System.Data.CommandType.StoredProcedure;
				try
				{
					liga.Open();
					string user = "" + EncryptADeDecrypt.EncryptOther(fun.Username);
					string pass = "" + EncryptADeDecrypt.EncryptRSA(fun.Pass);
					command.Parameters.Add(new SqlParameter("UserN", user));
					command.Parameters.Add(new SqlParameter("Passw", pass));
					command.Parameters.Add(new SqlParameter("Funcionario", "1"));


					command.Connection = liga;
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					return ex.Message;
				}
				finally
				{
					liga.Close();
				}

			}
			using (SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			{
				SqlCommand command = new SqlCommand();
				command.CommandText = "SpInsertLogin";
				command.CommandType = System.Data.CommandType.StoredProcedure;
				try
				{
					liga.Open();
					string user = "" + EncryptADeDecrypt.EncryptOther(fun.Username);
					string pass = "" + EncryptADeDecrypt.EncryptRSA(fun.Pass);

					command.CommandText = "SPInsertFuncionarios";
					command.CommandType = System.Data.CommandType.StoredProcedure;
					//(@Id_Funcao int, @Nome varchar(100), @Telemovel varchar(9), @Id_Login int)
					int id = ColectIdFun.SelectId(user, pass);
					command.Parameters.Add(new SqlParameter("Id_Funcao", (fun.IdFuncionario + 1)));
					command.Parameters.Add(new SqlParameter("Nome", fun.Nome));
					command.Parameters.Add(new SqlParameter("Telemovel", fun.Telemovel));
					command.Parameters.Add(new SqlParameter("Id_Login", id));

					command.Connection = liga;
					command.ExecuteNonQuery();

					return "sucesso";
				}
				catch (Exception ex)
				{
					return ex.Message;
				}
				finally
				{
					liga.Close();
				}

			}
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
						break;

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
						//pass = EncryptADeDecrypt.EncryptRSA(pass);
						break;

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

			return pass;
		}
		public static int SelectId(string user, string pass)
		{
			int id = 0;
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
						if (EncryptADeDecrypt.DecryptRSA(pass) == EncryptADeDecrypt.DecryptRSA(oReader["passW"].ToString()))
						{
							Funcionario fun = new Funcionario();
							id = int.Parse(oReader["IdCliente"].ToString());
							//pass = EncryptADeDecrypt.EncryptRSA(pass);
							//break;
						}
					}
				}
			}
			catch
			{
				return 0;
			}
			finally
			{
				liga.Close();
			}
			return id;
		}

	}
	public class EncomendasEDetalhesEProduto
	{
		public static string InsertEncomendas(Encomenda enc, int IdEstado)
		{
			SqlCommand command = new SqlCommand();
			using (SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			{
				command.CommandText = "SpInsertEncomenda";
				command.CommandType = System.Data.CommandType.StoredProcedure;

				try
				{
					command.Parameters.Add(new SqlParameter("ValorEncomendas", enc.ValorEncomendas));
					command.Parameters.Add(new SqlParameter("EstadoEncomendas", IdEstado));
					command.Parameters.Add(new SqlParameter("DataEncomenda", enc.DataEncomenda));
					command.Parameters.Add(new SqlParameter("DataEntrega", enc.DataEntrega));
					command.Parameters.Add(new SqlParameter("Id_Cliente", enc.Id_Cliente));

					command.Connection = liga;

					liga.Open();

					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{

				}
				liga.Close();
				return "sucesso";
			}
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
			#region teste
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
			#endregion
		}
		public static List<Produtos> SelectCategoriaProdutos(string CategoriaClasse)
		{
			SqlCommand comando;
			List<Produtos> lstProdutos = new List<Produtos>();
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			if(CategoriaClasse!="")
				comando = new SqlCommand("Select * From tbl_Produtos where CategoriaClasse='"+CategoriaClasse+"'", liga);
			else
				comando = new SqlCommand("Select * From tbl_Produtos", liga);

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
		}
		public static List<string> SelectEstado()
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
		public static string InsertDetalhes(List<DetalhesEncomendas> lst)
		{
			SqlCommand command = new SqlCommand();
			using (SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			{
				command.CommandText = "SpInsertDetalhes";
				command.CommandType = System.Data.CommandType.StoredProcedure;
				lst.ToList().ForEach(item =>
				{
					try
					{
						command.Parameters.Add(new SqlParameter("Id_Encomendas", item.Id_Encomendas));
						command.Parameters.Add(new SqlParameter("Id_Produtos", item.Id_Produtos));
						command.Parameters.Add(new SqlParameter("QuantEnc", item.QuantEnc));

						command.Connection = liga;

						liga.Open();

						command.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						//return ex.Message;
					}
				});
				liga.Close();
				return "sucesso";
			}
		}
		public static int SelectIdEncomenda(int cli)
		{
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select idEncomendas From tbl_Encomendas", liga);
			int idEncomenda = 0;
			try
			{
				comando.Connection = liga;
				liga.Open();
				using (SqlDataReader oReader = comando.ExecuteReader())
				{
					if (oReader.Read())
						if (int.Parse(oReader["IdEncomendas"].ToString()) == cli)
							idEncomenda = int.Parse(oReader["IdEncomendas"].ToString());
					liga.Close();

					return idEncomenda;
				}
			}
			catch
			{
				return idEncomenda;
			}

		}
		public static string DeleteProduto(int idProduto)
		{
			SqlCommand command = new SqlCommand();
			using (SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			{
				command.CommandText = "Delete tbl_Produtos where IdProduto=" + idProduto+"";
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
				finally
				{
					liga.Close();
				}

			}
		}
		public static string AtualizarProdutos(Produtos pro)
		{
			SqlCommand command = new SqlCommand();
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

			command.CommandText = "SpUpdateProdutos";
			command.CommandType = System.Data.CommandType.StoredProcedure;
			try
			{
				Image img = Image.FromFile(pro.CaminhoImg);
				ImageConverter converter = new ImageConverter();
				byte[] pic = (byte[])converter.ConvertTo(img, typeof(byte[]));
				command.Parameters.Add(new SqlParameter("IdProduto", pro.IdProduto));
				command.Parameters.Add(new SqlParameter("Nome", pro.Nome));
				command.Parameters.Add(new SqlParameter("Valor", pro.Valor));
				command.Parameters.Add(new SqlParameter("NomedaEmpresa", pro.NomedaEmpresa));
				command.Parameters.Add(new SqlParameter("CategoriaClasse", pro.CategoriaClass));
				command.Parameters.Add(new SqlParameter("CategoriaSubClasse", pro.CategoriaSubClass));
				command.Parameters.Add(new SqlParameter("Icon", pic));
				command.Parameters.Add(new SqlParameter("Sexo", pro.Sexo));


				command.Connection = liga;

				liga.Open();

				command.ExecuteNonQuery();
				return "sucesso";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
			finally
			{
				liga.Close();
			}
		}

		/*public static List<VerEncomenda> SelectCarrinho(int CliouId,bool IsCli, int Estado, DateTime Inicio, DateTime Fim)
		{
			string AuxComando = "";
			if (CliouId != 0)
				AuxComando = "and IdClient=" + CliouId;
			if (Estado != 0)
				AuxComando += " and EstadoEncomendas= " + Estado;
			//if()

			try
			{
				List<VerEncomenda> lst = new List<VerEncomenda>();
				SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
				SqlCommand comando = new SqlCommand("Select DISTINCT  IdCliente, Nome, IdEncomendas, ValorEncomendas, EstadoEncomendas, Estado, DataEncomenda, DataEntrega From tbl_Cliente, tbl_Encomendas, tblEstado, tblDetalheEncomendas where tbl_Encomendas.EstadoEncomendas = tblEstado.IdEstado and tbl_Encomendas.Id_Cliente = tbl_Cliente.IdCliente order by IdCliente", liga);
				try
				{
					comando.Connection = liga;
					liga.Open();
					using (SqlDataReader oReader = comando.ExecuteReader())
					{
						while (oReader.Read())
						{
							VerEncomenda enc = new VerEncomenda();
							enc.Nome = oReader["Nome"].ToString();
							enc.IdCliente = int.Parse(oReader["IdCliente"].ToString());
							enc.IdEncomendas = int.Parse(oReader["IdEncomendas"].ToString());
							//enc.EstadoEncomendas= (oReader["IdEncomendas"].ToString())

							//lst.Add(oReader["Estado"].ToString());
						}
					}
				}
				catch
				{
					return lst;
				}
				finally
				{
					liga.Close();
				}

				return lst;
			}
			catch
			{

			}
		}*/
	}

}
