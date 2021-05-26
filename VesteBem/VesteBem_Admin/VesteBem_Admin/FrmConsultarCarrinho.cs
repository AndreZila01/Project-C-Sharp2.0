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
	}
}
