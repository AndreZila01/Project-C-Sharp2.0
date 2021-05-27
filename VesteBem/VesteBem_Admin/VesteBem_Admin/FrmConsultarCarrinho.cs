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
			dateTimePicker2.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, (DateTime.Today.Day + 1));
		}

		private void FrmConsultarCarrinho_Load(object sender, EventArgs e)
		{
			if (!backgroundWorker1.IsBusy)
				backgroundWorker1.RunWorkerAsync();
		}

		private void Objects_TextChanged(object sender, EventArgs e)
		{

		}

		private void Teste()
		{

		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			int idEncomenda=0; string Cliente="";
			var ds = comboBox1.Text != "" ? comboBox1.Tag.ToString() == comboBox1.Text : comboBox1.Tag = "";
			if (int.TryParse(textBox1.Text, out idEncomenda))
				idEncomenda = int.Parse(textBox1.Text);
			else
				Cliente = textBox1.Text;
			if(dateTimePicker1.Value<dateTimePicker2.Value)
				dateTimePicker1.Value=

			lstEstado = EncomendasEDetalhes.SelectCarrinho();
		}

		private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
			LblCliente.Text = "label6";

			Label LblData = new Label();
			LblData.AutoSize = true;
			LblData.Location = new System.Drawing.Point(358, 17);
			LblData.Name = "LblData";
			LblData.Size = new System.Drawing.Size(35, 13);
			LblData.TabIndex = 2;
			LblData.Text = "label7";

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
			LblIdEncomenda.Text = "label6";

			Pnl.Controls.Add(LblIdEncomenda);
			Pnl.Controls.Add(PctMoreInfo);
			Pnl.Controls.Add(LblData);
			Pnl.Controls.Add(LblCliente);
			Pnl.Controls.Add(LblEstado);
		}
	}
}
