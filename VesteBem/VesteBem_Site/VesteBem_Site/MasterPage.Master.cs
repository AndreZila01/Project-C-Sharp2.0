using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VesteBem.Classes;
using VesteBem_Site;

namespace VesteBem
{
	public partial class MasterPage : System.Web.UI.MasterPage

	{
		SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		SqlCommand comando = new SqlCommand();
		SqlDataReader dr;

		protected void Log_Click(object sender, EventArgs e)
		{
			try
			{
				liga.Open();
				comando.Connection = liga;
				comando.CommandText = "Select Passw from tbl_login where Usern like '" + uname.Value + "'";
				dr = comando.ExecuteReader();
				
				if (dr.Read())
				{
					string pass = dr[0].ToString();

					

					if (psw.Value == EncryptADeDecrypt.DecryptRSA(dr["Passw"].ToString()))
					{
						Session["Username"] = uname.Value;
						Response.Write("<script>alert('Sessão efetuada com sucesso')</script>");
						Response.Redirect("~/logincerto.aspx");
					}
					else
                    {
						Response.Write("<script>alert('Pass ou Username/Email Inválidos!!!')</script>");
						Response.Redirect("~/Teste.aspx");
					}
					

				}
				

			}
			catch {

				Response.Write("<script>alert('login mal sucedido')</script>");
			
			}
		}


		protected void btnSearch_Click(object sender, EventArgs e)
		{
			txtSearchMaster.Visible = true;
			if (txtSearchMaster.Text != "")
			{
				var searchText = Server.UrlEncode(txtSearchMaster.Text); // URL encode in case of special characters
				Response.Redirect("~/MasterPage.aspx?srch=" + searchText);
			}
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			txtSearchMaster.Visible = false;
		}
	}
}