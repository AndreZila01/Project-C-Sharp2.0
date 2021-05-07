using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesteBem_Admin.Class
{
	public class Logins
	{/// <summary>
	 /// Nome de Username no Login
	 /// </summary>
		public string UserName { get; set; }
		/// <summary>
		/// Password de Username no Login
		/// </summary>
		public string Password { get; set; }
	}
	public class Cliente
	{
		public int Id_Cliente { get; set; }
		/// <summary>
		/// Nome do Cliente
		/// </summary>
		public string Nome { get; set; }
		/// <summary>
		/// Sexo do Cliente
		/// </summary>
		public string Sexo { get; set; }
		/// <summary>
		/// Nif do Cliente
		/// </summary>
		public string Nif { get; set; }
		public int Id_Login { get; set; }
		/// <summary>
		/// Morada do Cliente
		/// </summary>
		public string Morada { get; set; }
		/// <summary>
		/// Codigo-Postal do Cliente
		/// </summary>
		public string CodPostal { get; set; }
		/// <summary>
		/// Localidade do Cliente
		/// </summary>
		public string Localidade { get; set; }
		/// <summary>
		/// Data de Nascimento do Cliente
		/// </summary>
		public DateTime DataNasc { get; set; }
		/// <summary>
		/// Email do Cliente
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// Telefone Nome do Cliente
		/// </summary>
		public string Telefone { get; set; }
		/// <summary>
		/// Icon do Cliente, em bytes
		/// </summary>
		public Image Icon { get; set; }
	}
	public class Produtos
	{/// <summary>
	 /// Nome do Produto
	 /// </summary>
		public string Nome { get; set; }
		/// <summary>
		/// valor do Produto
		/// </summary>
		public double valor { get; set; }
		/// <summary>
		/// Nome da Empresa
		/// </summary>
		public string NomedaEmpresa { get; set; }
		/// <summary>
		/// Categoria do Produto
		/// </summary>
		public string CategoriaClass { get; set; }
		/// <summary>
		/// Sub Categoria do Produto
		/// </summary>
		public string CategoriaSubClass { get; set; }
		/// <summary>
		/// O produto deve ser usado por a pessoa do sexo(M/F/Indefenido)
		/// </summary>
		public string Sexo { get; set; }
		/// <summary>
		/// Imagem do produto, em bytes
		/// </summary>
		public string Icon { get; set; }
	}
	public class Funcionario
	{
		public int IdFuncionario { get; set; }
		/// <summary>
		/// Funcao do Funcionario
		/// </summary>
		public string Funcao { get; set; }
		/// <summary>
		/// Nome do Funcionario
		/// </summary>
		public string Nome { get; set; }
		/// <summary>
		/// Telemovel do Funcionario
		/// </summary>
		public string Telemovel { get; set; }
		/// <summary>
		/// Password do Funcionario
		/// </summary>
		public string Pass { get; set; }
		public int Id_Login { get; set; }
	}
}
