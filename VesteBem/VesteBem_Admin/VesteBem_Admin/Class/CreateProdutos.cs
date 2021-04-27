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
				liga.Open(); 

				command.Connection = liga;

				string ds;
				var temp = produtos.Icon != "NULL" ? ds = "d" : ds = produtos.Icon;
				if (produtos.Icon != "NULL")
				{
					Image img = Image.FromFile(produtos.Icon);
					byte[] arr;
					using (MemoryStream ms = new MemoryStream())
					{
						img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
						arr = ms.ToArray();
					}

					command.CommandText = "Insert into tbl_Produtos(Nome, Valor, NomedaEmpresa, CategoriaClasse, CategoriaSubClasse, Sexo, Icon) values(@Nome, @Valor, @NomedaEmpresa, @CategoriaClasse, @CategoriaSubClasse, @Sexo, @Icon)";
					command.Parameters.AddWithValue("@Nome", produtos.Nome);
					command.Parameters.AddWithValue("@Valor", produtos.valor);
					command.Parameters.AddWithValue("@NomedaEmpresa", produtos.NomedaEmpresa);
					command.Parameters.AddWithValue("@CategoriaClasse", produtos.CategoriaClass);
					command.Parameters.AddWithValue("@CategoriaSubClasse", produtos.CategoriaSubClass);
					command.Parameters.AddWithValue("@Sexo", produtos.Sexo);

					command.Parameters.AddWithValue("@Icon", arr);
					command.ExecuteNonQuery();
				}
				liga.Close();
			}
			catch(Exception ex)
			{
				return ex.Message;
			}

			return null;
        }
    }
}
