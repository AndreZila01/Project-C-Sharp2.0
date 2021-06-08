using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VesteBem_Admin
{
	public partial class FrmEditarCarrinho : Form
	{
		public FrmEditarCarrinho()
		{
			InitializeComponent();
		}

		private void FrmEditarCarrinho_Load(object sender, EventArgs e)
		{
			this.Location = Screen.AllScreens[(FrmAdmin.ecra - 1)].WorkingArea.Location;
			this.CenterToScreen();
			this.ShowIcon = false;
		}
	}
}
