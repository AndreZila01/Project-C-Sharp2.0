using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
		//string mes, hora, minuto, segundo;
		List<Logins> lst = new List<Logins>();
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Process[] procs = Process.GetProcessesByName("VesteBem_Admin");
			if (procs.Length > 1) foreach (Process proc in procs) { if (proc != procs[0]) proc.Kill(); }
			//string Paths = Path.Combine(Path.GetTempPath());
			var myString = File.ReadAllText(Path.Combine(Path.GetTempPath()) + "\\Login.json"); lst = JsonConvert.DeserializeObject<List<Logins>>(myString);

			TxtUser.Text = EncryptADeDecrypt.DecryptOther(lst[0].UserName);
			TxtPass.Text = EncryptADeDecrypt.DecryptRSA(lst[0].Password);
			timer1.Start();
			//var ds = DateTime.Now.Month.ToString().Length == 1 ? mes = "0" + (DateTime.Now.Month.ToString()) : mes = DateTime.Now.Month.ToString();
			TxtPass.Enabled = false; TxtUser.Enabled = false;
			//File.Delete(Path.Combine(Path.GetTempPath()) + "\\Login.json");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			if (TxtUser.Text != "" && TxtPass.Text != "")
			{
				string pass = TxtPass.Text, user = "";
				user = EncryptADeDecrypt.EncryptOther(TxtUser.Text);
				command.Connection = liga;
				liga.Open();
				try
				{
					command.CommandText = "Select * fROM tbl_Login where Funcionario=1 and Usern='" + user + "'";
					dr = command.ExecuteReader();
					if (dr.Read())
					{
						if (pass == EncryptADeDecrypt.DecryptRSA(dr["Passw"].ToString()))
						{
							liga.Close();
							FrmAdmin frm = new FrmAdmin(user, pass);
							frm.Show();
							this.Hide();
						}
					}
					else
					{
						MessageBox.Show("Login sem sucesso!\nCertifique se a password e username está correto!", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
						timer1.Start();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

					timer1.Start();
				}
				liga.Close();
				TxtPass.Text = string.Empty;
				TxtUser.Text = string.Empty;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			DateTime dt = new DateTime(int.Parse(DateTime.Now.Year.ToString()), int.Parse(DateTime.Now.Month.ToString()), int.Parse(DateTime.Now.Day.ToString()), int.Parse(DateTime.Now.Hour.ToString()), int.Parse(DateTime.Now.Minute.ToString()), int.Parse(DateTime.Now.Second.ToString()));
			lblTimer.Text = (dt.ToString("dd.MM.yyyy \n HH:mm:ss tt").Replace('.', '/'));

		}
	}
}
