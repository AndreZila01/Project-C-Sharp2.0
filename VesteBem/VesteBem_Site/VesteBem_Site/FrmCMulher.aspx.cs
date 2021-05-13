using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VesteBem
{
    public partial class FrmCMulher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistoCLiente.aspx");
        }
    }
}