using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            liga.Open();

			command.Connection = liga;

			string ds;
			var temp = produtos.Icon != "NULL" ? ds = "d" : ds = produtos.Icon;
			//command.CommandText = "Insert into dbo.tbl_Produtos([Nome],[Valor],[NomedaEmpresa],[CategoriaClasse],[CategoriaSubClasse],[Sexo],[Icon]) values(@nome, '" + produtos.valor.ToString().Replace(',', '.')+"', '"+produtos.NomedaEmpresa+"', '"+produtos.CategoriaClass+"', '"+produtos.CategoriaSubClass+"', '"+produtos.Sexo+"', '"+ds+"') ";
			//command.Parameters.AddWithValue("@nome", produtos.Nome);
			//command.Parameters.AddWithValue("@Valor", txtmorada.Text);
			//command.Parameters.AddWithValue("@imagem", pic);
			command.CommandText = "Insert into tbl_Produtos(Nome, Valor, NomedaEmpresa, CategoriaClasse, CategoriaSubClasse, Sexo, Icon) values('" + produtos.Nome + "','" + produtos.valor + "','" + produtos.NomedaEmpresa + "','" + produtos.CategoriaClass + "','" + produtos.CategoriaSubClass + "','" + produtos.Sexo + "','" + ds + "')";
			command.ExecuteNonQuery();
			#region Teste
			// SqlCommand MyCommand = new SqlCommand("StPrInsertProdutos", liga);
			//// Set the command type property.
			//MyCommand.CommandType = CommandType.StoredProcedure;

			//// Pass the string (array) into the stored procedure.
			//MyCommand.Parameters.Add(new SqlParameter("@Nome", produtos.Nome));
			//MyCommand.Parameters.Add(new SqlParameter("@Valor", produtos.valor));
			//MyCommand.Parameters.Add(new SqlParameter("@NomedaEmpresa", produtos.NomedaEmpresa));
			//MyCommand.Parameters.Add(new SqlParameter("@CategoriaClasse", produtos.CategoriaClass));
			//MyCommand.Parameters.Add(new SqlParameter("@CategoriaSubClasse", produtos.CategoriaSubClass));
			//MyCommand.Parameters.Add(new SqlParameter("@Sexo", produtos.Sexo));
			//MyCommand.Parameters.Add(new SqlParameter("@Icon", produtos.Icon));

			//MyCommand.ExecuteReader();


			//MyCommand.CommandType = CommandType.StoredProcedure;
			//MyCommand.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = produtos.Nome;
			//MyCommand.Parameters.Add(new SqlParameter("@Valor", SqlDbType.Decimal)).Value = produtos.valor;
			//MyCommand.Parameters.Add(new SqlParameter("@NomedaEmpresa", SqlDbType.VarChar)).Value = produtos.NomedaEmpresa;
			//MyCommand.Parameters.Add(new SqlParameter("@CategoriaClasse", SqlDbType.VarChar)).Value = produtos.CategoriaClass;
			//MyCommand.Parameters.Add(new SqlParameter("@CategoriaSubClasse", SqlDbType.VarChar)).Value = produtos.CategoriaSubClass;
			//MyCommand.Parameters.Add(new SqlParameter("@Sexo", SqlDbType.VarChar)).Value = produtos.Sexo;
			//MyCommand.Parameters.Add(new SqlParameter("@Icon", SqlDbType.Image)).Value = produtos.Icon;

			//MyCommand.ExecuteNonQuery();
			//liga.Close();

			#endregion

			command.CommandText = "UPDATE dbo.tbl_Produtos set Icon = (SELECT * FROM OPENROWSET(BULK N'" + produtos.Icon + "', SINGLE_BLOB) as tempimg) where Icon like 0x64";
			command.ExecuteNonQuery();

			liga.Close();

			return null;
        }
    }
}
