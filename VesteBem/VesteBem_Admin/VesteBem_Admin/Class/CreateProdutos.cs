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

            // Create the stored procedure command.
            SqlCommand MyCommand = new SqlCommand("StPrInsertProdutos", liga);

            // Set the command type property.
            MyCommand.CommandType = CommandType.StoredProcedure;

            // Pass the string (array) into the stored procedure.
            MyCommand.Parameters.Add(new SqlParameter("@Nome", produtos.Nome));
            MyCommand.Parameters.Add(new SqlParameter("@Valor", produtos.valor));
            MyCommand.Parameters.Add(new SqlParameter("@NomedaEmpresa", produtos.NomedaEmpresa));
            MyCommand.Parameters.Add(new SqlParameter("@CategoriaClasse", produtos.CategoriaClass));
            MyCommand.Parameters.Add(new SqlParameter("@CategoriaSubClasse", produtos.CategoriaSubClass));
            MyCommand.Parameters.Add(new SqlParameter("@Sexo", produtos.Sexo));
            MyCommand.Parameters.Add(new SqlParameter("@Icon", produtos.Icon));

            MyCommand.ExecuteReader();

            return null;
        }
    }
}
