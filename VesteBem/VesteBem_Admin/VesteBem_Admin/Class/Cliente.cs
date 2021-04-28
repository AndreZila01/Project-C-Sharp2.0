using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesteBem_Admin.Class
{
	public class Cliente
	{
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
	}
	public class ConsultaClientes
	{
		public static List<Cliente> ConsultaCliente()
		{
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand command = new SqlCommand();
			List<Cliente> lst = new List<Cliente>();
			SqlDataReader dr; Bitmap bitmap;
			try
			{
				Image images = Properties.Resources.add;
				using (var ms = new MemoryStream())
				{
					images.Save(ms, images.RawFormat);
					Debug.Print(""+ms.ToArray());
				}
				if (liga.State == System.Data.ConnectionState.Open) throw new ArgumentException("Problemas a ligar ao servidor!!");
				liga.Open();
				command.Connection = liga;

				command.CommandText = "Select * From tbl_Cliente";
				dr = command.ExecuteReader();
				if (dr.Read())
				{
					lst.Clear();
					MemoryStream MS = new MemoryStream();
					
					while (dr.Read())
					{
						Cliente cli = new Cliente();
						cli.CodPostal = (dr["CodPostal"]).ToString();
						cli.DataNasc = (dr["DataNasc"]).ToString();
						cli.Email = (dr["Email"]).ToString();
						cli.Id_Login = int.Parse(dr["Id_Login"].ToString());
						//Image.FromStream((new MemoryStream( ... ), true, true))
						cli.Icon = Image.FromStream(new MemoryStream(Convert.FromBase64String(dr["Icon"].ToString())), true, true);
						cli.Localidade = (dr["Localidade"]).ToString();
						cli.Morada = (dr["Morada"]).ToString();
						cli.Nif = (dr["Nif"]).ToString();
						cli.Nome = (dr["Nome"]).ToString();
						cli.Sexo = (dr["Sexo"]).ToString();
						cli.Telefone = (dr["Telefone"]).ToString();

						lst.Add(cli);

						/*MemoryStream stream = new MemoryStream();
					 byte[] image = (byte[])comando.ExecuteScalar();
            stream.Write(image, 0, image.Length);
            Bitmap bitmap = new Bitmap(stream);
            Response.ContentType = "image/Jpeg";
            bitmap.Save(Response.OutputStream, ImageFormat.Jpeg);*/
					}
				}

			}
			catch(Exception ex)
			{

			}
			liga.Close();
			return lst;
		}
	}
}
