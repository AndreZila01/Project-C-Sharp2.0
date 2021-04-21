using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VesteBem_Admin
{
	public partial class FrmAddProdutos : Form
	{
		SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		SqlCommand command = new SqlCommand();
		public FrmAddProdutos()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();

			open.ShowDialog();
			OpenFileDialog ofd = new OpenFileDialog(); ofd.Multiselect = true; ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; 
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				//command.CommandText = "Select * fROM tbl_Login  where Usern='" + TxtUser.Text + "' and Passw='" + TxtPass.Text + "' and Funcionario=1";
			}

		}

		private void FrmAddProdutos_Load(object sender, EventArgs e)
		{

		}

		private void textBox_MouseLeave(object sender, EventArgs e)
		{
			TextBox txt = sender as TextBox;

			//if(txt.Text.Length==0 || txt.Text.Length>100)
				//txt.BorderStyle=meter a borda a vermelho
		}
	}
}
