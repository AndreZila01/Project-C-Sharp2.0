using Microsoft.Win32;
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
					frm = new FrmAddChangeProdutos(0);
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


		}

		private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}


		private void label3_Click(object sender, EventArgs e)
		{
			Label Lbl = sender as Label;
			try
			{

				switch (int.Parse(Lbl.Tag.ToString()))
				{
					case 0:
						frm = new FrmAddChangeProdutos(0);
						//frm.Show();
						break;
					case 1:
						frm = new FrmEditarApagarProdutos();
						break;
					case 2:
						frm = new FrmCliEFun();
						//frm.Show();
						break;
					case 3:
						frm = new FrmCarrinho();
						//frm.Show();
						break;
					case 4:
						frm = new FrmConsultarCarrinho();
						//frm.Show();
						break;
					case 5:
						var ds = PnlSettings.Visible == true ? PnlSettings.Visible = false : PnlSettings.Visible = true;
						break;
					case 6:
						//leave
						break;
				}
				if (int.Parse(Lbl.Tag.ToString()) != 5)
					Forms();
			}
			catch
			{

			}
			//Forms();
		}

		private void Forms()
		{
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

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			try
			{

				PictureBox Pct = sender as PictureBox;

				switch (int.Parse(Pct.Tag.ToString()))
				{
					case 0:
						frm = new FrmAddChangeProdutos(0);
						//frm.Show();
						break;
					case 1:
						frm = new FrmEditarApagarProdutos();
						break;
					case 2:
						frm = new FrmCliEFun();
						//frm.Show();
						break;
					case 3:
						frm = new FrmCarrinho();
						//frm.Show();
						break;
					case 4:
						frm = new FrmConsultarCarrinho();
						//frm.Show();
						break;
					case 5:
						var ds = PnlSettings.Visible == true ? PnlSettings.Visible = false : PnlSettings.Visible = true;
						break;
					case 6:
						//leave
						break;
				}
				if(int.Parse(Pct.Tag.ToString())!=5)
					Forms();
			}
			catch
			{

			}
		}

		private void panel2_Click(object sender, EventArgs e)
		{
			try
			{

				Panel Pnl = sender as Panel;

				switch (int.Parse(Pnl.Tag.ToString()))
				{
					case 0:
						frm = new FrmAddChangeProdutos(0);
						//frm.Show();
						break;
					case 1:
						frm = new FrmEditarApagarProdutos();
						break;
					case 2:
						frm = new FrmCliEFun();
						//frm.Show();
						break;
					case 3:
						frm = new FrmCarrinho();
						//frm.Show();
						break;
					case 4:
						frm = new FrmConsultarCarrinho();
						//frm.Show();
						break;
					case 5:
						var ds = PnlSettings.Visible == true ? PnlSettings.Visible = false : PnlSettings.Visible = true;
						break;
					case 6:
						//leave
						break;
				}
				if (int.Parse(Pnl.Tag.ToString()) != 5)
					Forms();
			}
			catch
			{

			}
		}


		private void Pct_Click(object sender, EventArgs e)
		{
			PictureBox Pct = sender as PictureBox;
			if (Pct.Name == "PctFlow")
			{
				var ds = flowLayoutPanel1.Visible == true ? flowLayoutPanel1.Visible = false : flowLayoutPanel1.Visible = true;
			}
			else
			{
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (checkBox.Text == "Auto Run (Abrir com o SO, Sistema Operativo)")
			{
				RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				if (checkBox1.Checked)
				{
					Application.EnableVisualStyles();
					rkApp.SetValue("VesteBem Admin", Application.ExecutablePath.ToString());
				}
				else
					rkApp.DeleteValue("VesteBem Admin", false);
			}
		}

		private void Modes_Clicks(object sender, EventArgs e)
		{
			Button BtnMode = sender as Button;

			if (BtnMode.Text == "White Mode")
			{

			}
			else
			{

			}

		}

		private void FrmAdmin_Load(object sender, EventArgs e)
		{
			label1.Text = Username;
			this.ShowIcon = false;
			this.Tag = false;
		}
	}
}
