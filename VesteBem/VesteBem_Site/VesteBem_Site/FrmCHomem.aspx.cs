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
            command.Connection = liga;
            liga.Open();
            command.CommandText = "select Icon from tbl_Produtos";
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                Panel productPanel = new Panel();
                ImageButton images = new ImageButton();
                // Label LBL = new Label();
                byte[] image = (byte[])dr["Icon"];
                string PROFILE_PIC = Convert.ToBase64String(image);
                images.ImageUrl = String.Format("data:image/jpg;base64,{0}", PROFILE_PIC);
                //images.ImageUrl = "~/Image/" + ;
                images.CssClass = "productImage";
                // images.PostBackUrl = "~/Detalhes.aspx?CodProdutos=" + dr["CodProdutos"];
                // LBL.Text = dr["NomeProduto"].ToString();
                // LBL.CssClass = "productName";
                productPanel.Controls.Add(images);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                // productPanel.Controls.Add(LBL);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                GridView1.Controls.Add(productPanel);

            }

        }

        protected void lblCalcas_Click(object sender, EventArgs e)
        {
           GridView1.Visible = true;
            
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