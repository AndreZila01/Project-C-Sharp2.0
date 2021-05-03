using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesteBem_Admin.Class
{
	public class Logins
	{
		public string UserName { get; set; }
		public string Password { get; set; }
	}
	public class Cliente
	{
		public int Id_Cliente { get; set; }
		public string Nome { get; set; }
		public string Sexo { get; set; }
		public string Nif { get; set; }
		public int Id_Login { get; set; }
		public string Morada { get; set; }
		public string CodPostal { get; set; }
		public string Localidade { get; set; }
		public string DataNasc { get; set; }
		public string Email { get; set; }
		public string Telefone { get; set; }
		public Image Icon { get; set; }
		public int Funcionario { get; set; }
	}
	public class Produtos
	{
		public string Nome { get; set; }
		public double valor { get; set; }
		public string NomedaEmpresa { get; set; }
		public string CategoriaClass { get; set; }
		public string CategoriaSubClass { get; set; }
		public string Sexo { get; set; }
		public string Icon { get; set; }
	}
}
