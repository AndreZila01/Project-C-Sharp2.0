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
using VesteBem_Admin.Class;

namespace VesteBem_Admin
{
	public partial class FrmConsultarCarrinho : Form
	{
		List<Estados> lstEstado = new List<Estados>();
		List<VerEncomenda> LstEncomendas = new List<VerEncomenda>();
		public FrmConsultarCarrinho()
		{
			InitializeComponent();
		}

		private void FrmConsultarCarrinho_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormCollection fc = Application.OpenForms;
			foreach (Form frm in fc)
				frm.WindowState = FormWindowState.Normal;
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			lstEstado = Funcionarios.SelectEstado();
			lstEstado.ToList().ForEach(item =>
			{
				CmbEstado.Items.Add(item.Estado);
			});
			CmbEstado.SelectedItem = lstEstado[0].Estado;
			try
			{
				DtpChegada.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, (DateTime.Today.Day + 1));
			}
			catch
			{
				DtpChegada.Value = new DateTime(DateTime.Today.Year, (DateTime.Today.Month + 1), 1);
			}
			DtpChegada.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
			DtpInicio.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
		}

		private void FrmConsultarCarrinho_Load(object sender, EventArgs e)
		{
			this.Location = Screen.AllScreens[(FrmAdmin.ecra - 1)].WorkingArea.Location;
			this.CenterToScreen();
			//flowLayoutPanel1.MouseMove += Object_MouseLeavee;
			this.ShowIcon = false;
			if (!BgwInicio.IsBusy)
				BgwInicio.RunWorkerAsync();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			//lstEstado = EncomendasEDetalhes.SelectCarrinho();
		}

		private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			FlpCentro.Controls.Clear();
			LstEncomendas.ToList().ForEach(item =>
			{
				Panel Pnl = new Panel();
				Pnl.Dock = System.Windows.Forms.DockStyle.Top;
				Pnl.Location = new System.Drawing.Point(0, 0);
				Pnl.Margin = new System.Windows.Forms.Padding(0);
				Pnl.Name = "panel2";
				Pnl.Size = new System.Drawing.Size(800, 49);
				Pnl.TabIndex = 0;
				Pnl.BackColor = Color.Red;
				FlpCentro.Controls.Add(Pnl);


				Label LblEstado = new Label();
				LblEstado.AutoSize = true;
				LblEstado.Location = new System.Drawing.Point(13, 17);
				LblEstado.Name = "LblEstado";
				LblEstado.BackColor = Color.Green;
				LblEstado.Size = new System.Drawing.Size(35, 13);
				LblEstado.TabIndex = 0;
				LblEstado.Text = "" + CmbEstado.Text;

				Label LblCliente = new Label();
				LblCliente.AutoSize = true;
				LblCliente.Location = new System.Drawing.Point(107, 17);
				LblCliente.Name = "LblCliente";
				LblCliente.BackColor = Color.Gray;
				LblCliente.Size = new System.Drawing.Size(35, 13);
				LblCliente.TabIndex = 1;
				LblCliente.Tag = "" + item.IdCliente;
				LblCliente.Text = "Cliente:   " + item.Nome;

				Label LblData = new Label();
				LblData.AutoSize = true;
				LblData.BackColor = Color.Blue;
				LblData.Location = new System.Drawing.Point(500, 17);
				LblData.Name = "LblData";
				LblData.Size = new System.Drawing.Size(35, 13);
				LblData.TabIndex = 2;
				LblData.Text = "Data Encomendada:       " + item.DataEncomenda.ToString("yyyy-MM-dd"); //\t não funciona

				PictureBox PctMoreInfo = new PictureBox();
				PctMoreInfo.Image = global::VesteBem_Admin.Properties.Resources.magnifying_glass;
				PctMoreInfo.Location = new System.Drawing.Point(700, 6);
				PctMoreInfo.Name = "PctMoreInfo";
				PctMoreInfo.Size = new System.Drawing.Size(44, 40);
				PctMoreInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
				PctMoreInfo.TabIndex = 3;
				PctMoreInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
				PctMoreInfo.TabStop = false;

				Label LblIdEncomenda = new Label();
				LblIdEncomenda.AutoSize = true;
				LblIdEncomenda.Location = new System.Drawing.Point(320, 17);
				LblIdEncomenda.Name = "LblIdEncomenda";
				LblIdEncomenda.Size = new System.Drawing.Size(35, 13);
				LblIdEncomenda.TabIndex = 4;
				LblIdEncomenda.BackColor = Color.Orange;
				LblIdEncomenda.Text = "Nº de Encomenda:    " + item.IdEncomendas;

				Pnl.Controls.Add(LblIdEncomenda);
				Pnl.Controls.Add(PctMoreInfo);
				Pnl.Controls.Add(LblData);
				Pnl.Controls.Add(LblCliente);
				Pnl.Controls.Add(LblEstado);
			});
		}

		private void Select()
		{
			int ds = 0;
			if (int.TryParse(TxtClienteId.Text, out int dss))
			{
				ds = int.Parse(TxtClienteId.Text);
				TxtClienteId.Text = "";
			}                                 
			
			LstEncomendas = EncomendasEDetalhesEProduto.SelectCarrinho(ds, TxtClienteId.Text, lstEstado[lstEstado.FindIndex(rs => rs.Estado == CmbEstado.Text)].IdEstado, DtpInicio.Value, DtpChegada.Value);

			//if(comboBox1.Tag!=null)	
			try
			{
				if (!BgwInicio.IsBusy)
					BgwModificar.RunWorkerAsync();
			}
			catch
			{

			}
		}

		private void Object_MouseLeavee(object sender, EventArgs e)
		{
			Select();
		}

		private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
		{

		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			if (DtpInicio.Value > DtpChegada.Value)
			{
				DtpInicio.Tag = DtpInicio.Value;
				DtpInicio.Value = DtpChegada.Value;
				DtpChegada.Value = DateTime.Parse(DtpInicio.Tag.ToString());
			}

			Select();

		}

		private void comboBox1_TextChanged(object sender, EventArgs e)
		{
			Select();
		}

		private void FrmConsultarCarrinho_SizeChanged(object sender, EventArgs e)
		{
			if (this.Width < 749)
				this.Width = 749;
			if (this.Height < 489)
				this.Height = 489;

		}
	}
}
