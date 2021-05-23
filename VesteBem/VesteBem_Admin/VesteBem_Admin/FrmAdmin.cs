using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VesteBem_Admin
{
	public partial class FrmAdmin : Form
	{
		private string Username, Password;
		public FrmAdmin(string user, string pass)
		{
			InitializeComponent();
			Username = user;
			Password = pass;
		}

		Form frm;

		private void button_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			switch (btn.Text)
			{
				case "Adicionar Produtos":
					frm = new FrmAddProdutos();
					//frm.Show();
					break;
				case "Clientes E Funcionarios":
					frm = new FrmCliEFun();
					//frm.Show();
					break;
				case "Adicionar Carrinho":
					frm = new FrmCarrinho();
					//frm.Show();
					break;
				case "Consultar Carrinho":
					frm = new FrmConsultarCarrinho();
					//frm.Show();
					break;
			}

			//Process[] procs = Process.GetProcessesByName("VesteBem_Admin");
			//	foreach (Process proc in procs)
			//	{
			//		if (proc.MainWindowTitle == frm.Name)
			//			this.Tag = true;
			//	}

			this.Tag = "false";
			foreach (Form frms in Application.OpenForms)
			{
				if (frms.Name == frm.Name)
					this.Tag = "true";
			}


			if (this.Tag.ToString() != "true")
				frm.Show();


			this.WindowState = FormWindowState.Minimized;
		}

		private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		private void FrmAdmin_Load(object sender, EventArgs e)
		{
			this.Tag = false;
		}
	}
}
