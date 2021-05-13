using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VesteBem.Classes;

namespace VesteBem
{
	public partial class Teste : System.Web.UI.Page
	{

		protected void Page_Load(object sender, EventArgs e)
		{
			string Paths = Path.Combine(Path.GetTempPath());
			Logins login = new Logins();
			List<Logins> ListLogin = new List<Logins>();
			try
			{ 
				if (File.Exists($"{Paths + @"\Login.json"}"))
				{
					File.Delete($"{Paths + @"\Login.json"}");
				}
				login.UserName = "Admin";
				login.Password = "Admin";

				ListLogin.Clear();
				ListLogin.Add(login);

				string json = JsonConvert.SerializeObject(ListLogin);
				File.WriteAllText(Paths + "\\Login.json", json);
			}
			catch (Exception Ex)
			{
				Console.WriteLine(Ex.ToString());
			}
		}

        protected void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
			Response.Redirect("FrmCHomem.aspx");
        }
    }
}