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
using System.Data.SqlClient;

namespace VesteBem
{
	public partial class Teste : System.Web.UI.Page
	{
		SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433; Database=bd; User ID=epbjc;Password=Teste123; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
		SqlCommand comando = new SqlCommand();
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

        protected void BtnVoltar_Click1(object sender, EventArgs e)
        {
			Response.Redirect("FrmHome.aspx");
        }

        protected void BtnRegistar_Click(object sender, EventArgs e)
        {
			comando.Connection = liga;
			liga.Open();
			comando.CommandText = "Insert into Tbl_Cliente(Nome ,Sexo , Nif,Morada ,CodPostal ,Localidade , DataNasc ,Email ,Telefone) " + "VALUES('" + txtNomeCliente.Text + "', '" + RadioButtonList1.SelectedValue + "', '" + txtNif.Text + "', '" + txtMorada.Text + "', '" + txtCodPostal.Text + "', '" + txtLocalidade.Text + "', '" + txtDataNasc.Text + "', '" + txtEmail.Text + "', '" + txtTelefone.Text + "')";
			comando.ExecuteNonQuery();
			comando.CommandText = "Insert into Tbl_Login(Usern ,Passw, Funcionario) " + "VALUES('" + txtUsername.Text + "', '"+ txtPassword.Text + "', '0')";


			try
			{
				comando.ExecuteNonQuery();
				lblMensagem.Text = "Registado com sucesso";
				txtNomeCliente.Text = "";
				txtEmail.Text = "";
				txtCodPostal.Text = "";
				txtDataNasc.Text = "";
				txtLocalidade.Text = "";
				txtMorada.Text = "";
				txtNif.Text = "";
				txtPassword.Text = "";
				txtPasswordConfirmar.Text = "";
				txtTelefone.Text = "";
				txtUsername.Text = "";
		


			}

			catch (Exception er)
			{
				lblMensagem.Text = er.Message;
			}
			liga.Close();

		}
	}
    }
