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
	public partial class FrmEditarApagarProdutos : Form
	{
		List<Produtos> LstProdutos = new List<Produtos>();
		public FrmEditarApagarProdutos()
		{
			InitializeComponent();
		}

		private void FrmEditarApagarProdutos_Load(object sender, EventArgs e)
		{
			this.ShowIcon = false;
			if (!backgroundWorker1.IsBusy)
				backgroundWorker1.RunWorkerAsync();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			LstProdutos = EncomendasEDetalhesEProduto.SelectCategoriaProdutos("");
		}
		private void PctRemove_MouseEnter(object sender, EventArgs e)
		{
			PictureBox Pct = sender as PictureBox;
			try
			{
				Pct.Image = Properties.Resources.White_Remove;
			}
			catch
			{

			}
		}

		private void PctRemove_MouseLeave(object sender, EventArgs e)
		{
			PictureBox Pct = sender as PictureBox;
			try
			{
				Pct.Image = Properties.Resources.Red_Remove;
			}
			catch
			{

			}
		}
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			LstProdutos.ToList().ForEach(item =>
			{

				Panel Pnl = new Panel();
				Pnl.Dock = System.Windows.Forms.DockStyle.Top;
				Pnl.Location = new System.Drawing.Point(0, 0);
				Pnl.Margin = new System.Windows.Forms.Padding(0);
				Pnl.Name = "panel2";
				Pnl.Size = new System.Drawing.Size(800, 42);
				Pnl.TabIndex = 0;
				flowLayoutPanel1.Controls.Add(Pnl);

				PictureBox PctRemove = new PictureBox();
				PctRemove.MouseLeave += new System.EventHandler(PctRemove_MouseLeave);
				PctRemove.MouseEnter += new System.EventHandler(PctRemove_MouseEnter);
				PctRemove.Click += new System.EventHandler(Pct_Click);
				PctRemove.Image = global::VesteBem_Admin.Properties.Resources.Red_Remove;
				PctRemove.Location = new System.Drawing.Point(753, 6);
				PctRemove.Tag = item.IdProduto;
				PctRemove.Name = "PctRemove";
				PctRemove.Size = new System.Drawing.Size(35, 30);
				PctRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
				PctRemove.TabIndex = 1;
				PctRemove.TabStop = false;

				PictureBox PctEdit = new PictureBox();
				PctEdit.Image = global::VesteBem_Admin.Properties.Resources.Pencil;
				PctEdit.Click += new System.EventHandler(Pct_Click);
				PctEdit.Location = new System.Drawing.Point(705, 6);
				PctEdit.Name = "PctEdit";
				PctEdit.Size = new System.Drawing.Size(35, 30);
				PctEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
				PctEdit.TabIndex = 0;
				PctEdit.Tag = item.IdProduto;
				PctEdit.TabStop = false;

				Label LblNomeProduto = new Label();
				LblNomeProduto.AutoSize = true;
				LblNomeProduto.Location = new System.Drawing.Point(13, 15);
				LblNomeProduto.Name = "LblNomeProduto";
				LblNomeProduto.Size = new System.Drawing.Size(86, 13);
				LblNomeProduto.TabIndex = 2;
				LblNomeProduto.Text = ""+item.Nome;

				Label LblCategoria = new Label();
				LblCategoria.AutoSize = true;
				LblCategoria.Location = new System.Drawing.Point(206, 15);
				LblCategoria.Name = "LblCategoria";
				LblCategoria.Size = new System.Drawing.Size(66, 13);
				LblCategoria.TabIndex = 3;
				LblCategoria.Text = ""+item.CategoriaClass;

				Label LblSubCategoria = new Label();
				LblSubCategoria.AutoSize = true;
				LblSubCategoria.Location = new System.Drawing.Point(383, 15);
				LblSubCategoria.Name = "LblSubCategoria";
				LblSubCategoria.Size = new System.Drawing.Size(85, 13);
				LblSubCategoria.TabIndex = 4;
				LblSubCategoria.Text = ""+item.CategoriaSubClass;

				Pnl.Controls.Add(LblSubCategoria);
				Pnl.Controls.Add(LblCategoria);
				Pnl.Controls.Add(LblNomeProduto);
				Pnl.Controls.Add(PctRemove);
				Pnl.Controls.Add(PctEdit);
			});
		}

		private void Pct_Click(object sender, EventArgs e)
		{
			PictureBox Pct = sender as PictureBox;

			switch(Pct.Name){
				case "PctEdit":
					FrmAddChangeProdutos frm = new FrmAddChangeProdutos(int.Parse(Pct.Tag.ToString()));
					frm.ShowDialog();
					break;
				case "PctRemove":
					EncomendasEDetalhesEProduto.DeleteProduto(int.Parse(Pct.Tag.ToString()));
					break;
			}

				backgroundWorker1.RunWorkerAsync();
		}

		private void FrmEditarApagarProdutos_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormCollection fc = Application.OpenForms;
			foreach (Form frm in fc)
				frm.WindowState = FormWindowState.Normal;
		}
	}
}
