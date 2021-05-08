using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;


namespace VesteBem_Admin
{
	public partial class FrmLogin : Form
	{
		SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		SqlCommand command = new SqlCommand();
		SqlDataReader dr;
		List<Logins> lst = new List<Logins>();
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//string Paths = Path.Combine(Path.GetTempPath());
			var myString = File.ReadAllText(Path.Combine(Path.GetTempPath()) + "\\Login.json"); lst = JsonConvert.DeserializeObject<List<Logins>>(myString);

			TxtUser.Text = lst[0].UserName;
			TxtPass.Text = lst[0].Password;

			TxtPass.Enabled = false; TxtUser.Enabled = false;
			lblTimer.Text = DateTime.Now.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (TxtUser.Text != "" && TxtPass.Text != "")
			{
				string pass = "", user = "";
				pass = EncryptADeDecrypt.EncryptRSA(TxtPass.Text);
				user = EncryptADeDecrypt.EncryptRSA(TxtUser.Text);
				command.Connection = liga;
				liga.Open();
				try
				{
					command.CommandText = "Select * fROM tbl_Login  where Usern='" + user + "' and Passw='" + pass + "' and Funcionario=1";
					dr = command.ExecuteReader();
					if (dr.Read())
					{
						liga.Close();
						FrmAdmin frm = new FrmAdmin(user,pass);
						frm.Show();
						this.Hide();
					}
					else
						MessageBox.Show("Login sem sucesso!\nCertifique se a password e username está correto!", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				liga.Close();
				TxtPass.Text = string.Empty;
				TxtUser.Text = string.Empty;
			}
		}
	}
}
