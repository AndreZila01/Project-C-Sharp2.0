using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesteBem_Admin.Class
{
	public class CreateProdutos
	{
		public static string InsertProdutos(Produtos produtos)
		{
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand command = new SqlCommand();
			try
			{
				if (liga.State == System.Data.ConnectionState.Closed) throw new ArgumentException("Problemas a ligar ao servidor!!");
				liga.Open();
				command.CommandText = "SPAddProdutos";
				command.CommandType = System.Data.CommandType.StoredProcedure;

				string ds;
				var temp = produtos.Icon != "NULL" ? ds = "d" : ds = produtos.Icon;
				if (produtos.Icon != "NULL") 
				{
					Image img = Image.FromFile(produtos.Icon);
					byte[] arr; string base64String;
					using (MemoryStream m = new MemoryStream())
					{
						img.Save(m, img.RawFormat);
						byte[] imageBytes = m.ToArray();
						base64String = Convert.ToBase64String(imageBytes);
					}

					command.Parameters.Add(new SqlParameter("Nome", produtos.Nome));
					command.Parameters.Add(new SqlParameter("Valor", produtos.valor));
					command.Parameters.Add(new SqlParameter("NomedaEmpresa", produtos.NomedaEmpresa));
					command.Parameters.Add(new SqlParameter("CategoriaClasse", produtos.CategoriaClass));
					command.Parameters.Add(new SqlParameter("CategoriaSubClasse", produtos.CategoriaSubClass));
					command.Parameters.Add(new SqlParameter("Sexo", produtos.Sexo));
					command.Parameters.Add(new SqlParameter("Icon", base64String));

					command.Connection = liga;
					command.ExecuteNonQuery();
				}
				liga.Close();
			}
			catch (Exception ex)
			{
				return ex.Message;
			}

			return "Correu bem";
		}
	}
}
