using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;

namespace VesteBem_Admin
{
	public partial class FrmModificarCliFun : Form
	{
		List<Cliente> lst = new List<Cliente>();
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
			txtNome.Text = lst[0].Nome;
			TxtCod.Text = lst[0].CodPostal;
			TxtLoc.Text = lst[0].Localidade;
			TxtMorada.Text = lst[0].Morada;
			TxtNif.Text = lst[0].Nif;
			TxtEmail.Text = lst[0].Email;
			TxtTele.Text = lst[0].Telefone;
			DateTime time = lst[0].DataNasc;
			DTPdate.Value = time;


			if (lst[0].Sexo == "M")
				CboSexo.SelectedItem = "Masculino";
			else
			if (lst[0].Sexo == "F")
				CboSexo.SelectedItem = "Feminino";
			else
				CboSexo.SelectedItem = "Indefenido";

		}

		private void button_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			switch (btn.Text)
			{
				case "Guardar":
					Save();
					break;
				case "Cancel":
					this.Close();
					break;
			}
		}

		private void Save()
		{
			Cliente cli = new Cliente();
			cli.CodPostal = TxtCod.Text;
			cli.DataNasc = DTPdate.Value;
			cli.Email = TxtEmail.Text;
			cli.Id_Cliente = lst[0].Id_Cliente;
			cli.Id_Login = lst[0].Id_Login;
			cli.Localidade = TxtLoc.Text;
			cli.Morada = TxtMorada.Text;
			cli.Nif = TxtNif.Text;
			cli.Nome = txtNome.Text;
			cli.Sexo = CboSexo.Text.Substring(0, 1);
			cli.Telefone = TxtTele.Text;
			string result = InsertClientes.InsertCliente(cli);


			if (result == "sucesso")
				this.Close();
			else
				if (MessageBox.Show("" + result +"\nPretender Continuar as alterações?!?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
				{
					this.Close();
					
				}
		}
	}
}
