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
            ImgCat1.Visible = true;
            ImgCat2.Visible = true;
            ImgCat3.Visible = true;
            ImgCat4.Visible = true;
            ImgCat5.Visible = true;
            ImgCat6.Visible = true;
            ImgCat7.Visible = true;
            ImgCat8.Visible = true; 
            ImgCat9.Visible = true;
            //Label lblPl=new Label();lblPl.Text="PLAYLIST";lblPl.Location=new Point(202,25);lblPl.Size=new Size(61,13);lblPl.BorderStyle=BorderStyle.None;lblPl.Font=new Font("Tahoma",9,FontStyle.Regular);lblPl.BackColor=Color.Transparent;lblPl.ForeColor=Color.Black;pnlPrincipal.Controls.Add(lblPl);
            //Label lbl = new Label();
            //lbl.Size = (AnchorStyles.Right | AnchorStyles.Left);
            //ImageCat1.Controls.Add();
        }

        protected void lblLink_Click(object sender, EventArgs e)
        {

            LinkButton linkButton = new LinkButton();
            switch (linkButton.Text)
            {
                case "":
                    break;
                default:
                    break;
            }
        }
    }
}