using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace VesteBem
{
    public partial class FrmCHomem : System.Web.UI.Page
    {
        SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lblCalcas_Click(object sender, EventArgs e)
        {
            GridCalcas.Visible = true;
            
        }
        protected void lblPijama_Click(object sender, EventArgs e)
        {


        }
        protected void lblSapatos_Click(object sender, EventArgs e)
        {


        }
        protected void lblCamisolaI_Click(object sender, EventArgs e)
        {


        }
        protected void lblCamisa_Click(object sender, EventArgs e)
        {


        }
        protected void lblCamisolaE_Click(object sender, EventArgs e)
        {


        }
        protected void lblRoupaI_Click(object sender, EventArgs e)
        {


        }
        protected void lblCasacos_Click(object sender, EventArgs e)
        {


        }
        protected void lblAcessorios_Click(object sender, EventArgs e)
        {


        }

    }
}