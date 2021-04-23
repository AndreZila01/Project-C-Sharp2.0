using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VesteBem
{
	public partial class MasterPage : System.Web.UI.MasterPage

	{

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