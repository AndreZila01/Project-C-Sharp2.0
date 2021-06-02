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
				comboBox1.Items.Add(item.Estado);
			});
			comboBox1.SelectedItem = lstEstado[0].Estado;
			//comboBox1.Tag = 1;
			try
			{
				DtpChegada.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, (DateTime.Today.Day + 1));
			}
			catch
			{
				DtpChegada.Value = new DateTime(DateTime.Today.Year, (DateTime.Today.Month + 1), 1);
			}
		}

		private void FrmConsultarCarrinho_Load(object sender, EventArgs e)
		{
			//flowLayoutPanel1.MouseMove += Object_MouseLeavee;
			this.ShowIcon = false;
			if (!backgroundWorker1.IsBusy)
				backgroundWorker1.RunWorkerAsync();
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
			flowLayoutPanel1.Controls.Clear();
			LstEncomendas.ToList().ForEach(item =>
			{
				Panel Pnl = new Panel();
				Pnl.Dock = System.Windows.Forms.DockStyle.Top;
				Pnl.Location = new System.Drawing.Point(0, 0);
				Pnl.Margin = new System.Windows.Forms.Padding(0);
				Pnl.Name = "panel2";
				Pnl.Size = new System.Drawing.Size(800, 49);
				Pnl.TabIndex = 0;
				flowLayoutPanel1.Controls.Add(Pnl);


				Label LblEstado = new Label();
				LblEstado.AutoSize = true;
				LblEstado.Location = new System.Drawing.Point(13, 17);
				LblEstado.Name = "LblEstado";
				LblEstado.Size = new System.Drawing.Size(35, 13);
				LblEstado.TabIndex = 0;
				LblEstado.Text = "" + comboBox1.Text;

				Label LblCliente = new Label();
				LblCliente.AutoSize = true;
				LblCliente.Location = new System.Drawing.Point(107, 17);
				LblCliente.Name = "LblCliente";
				LblCliente.Size = new System.Drawing.Size(35, 13);
				LblCliente.TabIndex = 1;
				LblCliente.Tag = "" + item.IdCliente;
				LblCliente.Text = "" + item.Nome;

				Label LblData = new Label();
				LblData.AutoSize = true;
				LblData.Location = new System.Drawing.Point(250, 17);
				LblData.Name = "LblData";
				LblData.Size = new System.Drawing.Size(35, 13);
				LblData.TabIndex = 2;
				LblData.Text = "Data Encomendada" + item.DataEncomenda+"                       Data da Entrega: "+item.DataEntrega; //\t não funciona

				PictureBox PctMoreInfo = new PictureBox();
				PctMoreInfo.Image = global::VesteBem_Admin.Properties.Resources.magnifying_glass;
				PctMoreInfo.Location = new System.Drawing.Point(744, 6);
				PctMoreInfo.Name = "PctMoreInfo";
				PctMoreInfo.Size = new System.Drawing.Size(44, 40);
				PctMoreInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
				PctMoreInfo.TabIndex = 3;
				PctMoreInfo.TabStop = false;

				Label LblIdEncomenda = new Label();
				LblIdEncomenda.AutoSize = true;
				LblIdEncomenda.Location = new System.Drawing.Point(220, 17);
				LblIdEncomenda.Name = "LblIdEncomenda";
				LblIdEncomenda.Size = new System.Drawing.Size(35, 13);
				LblIdEncomenda.TabIndex = 4;
				LblIdEncomenda.Text = "" + item.IdEncomendas;

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
			if (int.TryParse(textBox1.Text, out int dss))
				ds = int.Parse(textBox1.Text);

			LstEncomendas = EncomendasEDetalhesEProduto.SelectCarrinho(ds, textBox1.Text, lstEstado[lstEstado.FindIndex(rs => rs.Estado == comboBox1.Text)].IdEstado, DtpInicio.Value, DtpChegada.Value);

			//if(comboBox1.Tag!=null)	
			if (!backgroundWorker1.IsBusy)
				backgroundWorker2.RunWorkerAsync();
		}

		private void Object_MouseLeavee(object sender, EventArgs e)
		{
			
			int idEncomenda = 0; string Cliente = "";
			//var ds = comboBox1.Text != "" ? comboBox1.Tag.ToString() == comboBox1.Text : comboBox1.Tag = "";
			if (int.TryParse(textBox1.Text, out idEncomenda))
				idEncomenda = int.Parse(textBox1.Text);
			else
				Cliente = textBox1.Text;
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
	}
}
