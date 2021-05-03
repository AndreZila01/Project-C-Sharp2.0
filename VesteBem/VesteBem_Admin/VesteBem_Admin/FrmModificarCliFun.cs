using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;

namespace VesteBem_Admin
{
	public partial class FrmModificarCliFun : Form
	{
		List<Cliente> lst = new List<Cliente>();int id_cli;
		private const int CP_NOCLOSE_BUTTON = 0x200;
		public FrmModificarCliFun(Cliente cli)
		{
			InitializeComponent();
			lst.Add(cli);
		}
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams myCp = base.CreateParams;
				myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
				return myCp;
			}
		}
		private void FrmModificar_Load(object sender, EventArgs e)
		{
			
		}

		private void button_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			switch(btn.Text)
			{
				case "Guardar":
					break;
				case "Cancel":
					this.Close();
					break;
			}
		}
	}
}
