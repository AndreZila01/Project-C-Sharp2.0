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
		List<Cliente> lstcli = new List<Cliente>();
		Cliente cli = new Cliente();
		private const int CP_NOCLOSE_BUTTON = 0x200;
		public FrmModificarCliFun(Cliente cli)
		{
			InitializeComponent();
			lstcli.Add(cli);
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
		private void txt_Leave(object sender, EventArgs e)
		{
			TextBox Txt = sender as TextBox;
			switch (Txt.Name)
			{
				case "txtNome":
					cli.Nome = Txt.Text;
					break;
				case "TxtNif":
					cli.Nif = Txt.Text;
					break;
				case "TxtMorada":
					cli.Morada = Txt.Text;
					break;
				case "TxtCod":
					cli.CodPostal = Txt.Text;
					break;
				case "TxtTele":
					cli.Telefone = Txt.Text;
					break;
				case "TxtEmail":
					cli.Email = Txt.Text;
					break;
				case "TxtLoc":
					cli.Localidade = Txt.Text;
					break;
			}
		}

		private void FrmModificar_Load(object sender, EventArgs e)
		{
			if(lstcli.Count>0)
			{
				TextBox TxtNome = new TextBox();
				TxtNome.Location = new System.Drawing.Point(127, 13);
				TxtNome.MaxLength = 100;
				TxtNome.Name = "txtNome";
				TxtNome.Size = new System.Drawing.Size(172, 20);
				TxtNome.TabIndex = 0;
				TxtNome.Text = lstcli[0].Nome;
				TxtNome.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtNome);

				TextBox TxtNif = new TextBox();
				TxtNif.Location = new System.Drawing.Point(127, 65);
				TxtNif.MaxLength = 9;
				TxtNif.Name = "TxtNif";
				TxtNif.Size = new System.Drawing.Size(172, 20);
				TxtNif.TabIndex = 2;
				TxtNif.Text = lstcli[0].Nif;
				TxtNif.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtNif);

				TextBox TxtMorada = new TextBox();
				TxtMorada.Location = new System.Drawing.Point(127, 91);
				TxtMorada.MaxLength = 250;
				TxtMorada.Name = "TxtMorada";
				TxtMorada.Size = new System.Drawing.Size(172, 20);
				TxtMorada.TabIndex = 3;
				TxtMorada.Text = lstcli[0].Morada;
				TxtMorada.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtMorada);

				TextBox TxtCod = new TextBox();
				TxtCod.Location = new System.Drawing.Point(127, 117);
				TxtCod.MaxLength = 8;
				TxtCod.Name = "TxtCod";
				TxtCod.Size = new System.Drawing.Size(172, 20);
				TxtCod.TabIndex = 4;
				TxtCod.Text = lstcli[0].CodPostal;
				TxtCod.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtCod);

				TextBox TxtTele = new TextBox();
				TxtTele.Location = new System.Drawing.Point(127, 221);
				TxtTele.MaxLength = 9;
				TxtTele.Name = "TxtTele";
				TxtTele.Size = new System.Drawing.Size(172, 20);
				TxtTele.TabIndex = 8;
				TxtTele.Text = lstcli[0].Telefone;
				TxtTele.Leave += new System.EventHandler(txt_Leave); 
				this.Controls.Add(TxtTele);

				TextBox TxtEmail = new TextBox();
				TxtEmail.Location = new System.Drawing.Point(127, 195);
				TxtEmail.MaxLength = 300;
				TxtEmail.Name = "TxtEmail";
				TxtEmail.Size = new System.Drawing.Size(172, 20);
				TxtEmail.TabIndex = 7;
				TxtEmail.Text = lstcli[0].Email;
				TxtEmail.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtEmail);

				TextBox TxtLoc = new TextBox();
				TxtLoc.Location = new System.Drawing.Point(127, 143);
				TxtLoc.MaxLength = 100;
				TxtLoc.Name = "TxtLoc";
				TxtLoc.Size = new System.Drawing.Size(172, 20);
				TxtLoc.TabIndex = 5;
				TxtLoc.Text = lstcli[0].Localidade;
				TxtLoc.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtLoc);

				Label LblNome = new Label();
				LblNome.AutoSize = true;
				LblNome.Location = new System.Drawing.Point(17, 16);
				LblNome.Name = "label1";
				LblNome.Size = new System.Drawing.Size(35, 13);
				LblNome.TabIndex = 10;
				LblNome.Text = "Nome";
				this.Controls.Add(LblNome);

				Label LblSexo = new Label();
				LblSexo.AutoSize = true;
				LblSexo.Location = new System.Drawing.Point(17, 42);
				LblSexo.Name = "label2";
				LblSexo.Size = new System.Drawing.Size(31, 13);
				LblSexo.TabIndex = 11;
				LblSexo.Text = "Sexo";
				this.Controls.Add(LblSexo);

				Label LblNif = new Label();
				LblNif.AutoSize = true;
				LblNif.Location = new System.Drawing.Point(17, 68);
				LblNif.Name = "label3";
				LblNif.Size = new System.Drawing.Size(20, 13);
				LblNif.TabIndex = 12;
				LblNif.Text = "Nif";
				this.Controls.Add(LblNif);

				Label LblLoc = new Label();
				LblLoc.AutoSize = true;
				LblLoc.Location = new System.Drawing.Point(17, 146);
				LblLoc.Name = "label4";
				LblLoc.Size = new System.Drawing.Size(59, 13);
				LblLoc.TabIndex = 15;
				LblLoc.Text = "Localidade";
				this.Controls.Add(LblLoc);

				Label LlbCod = new Label();
				LlbCod.AutoSize = true;
				LlbCod.Location = new System.Drawing.Point(17, 120);
				LlbCod.Name = "label5";
				LlbCod.Size = new System.Drawing.Size(72, 13);
				LlbCod.TabIndex = 14;
				LlbCod.Text = "Codigo Postal";
				this.Controls.Add(LlbCod);

				Label LblMorada = new Label();
				LblMorada.AutoSize = true;
				LblMorada.Location = new System.Drawing.Point(17, 94);
				LblMorada.Name = "label6";
				LblMorada.Size = new System.Drawing.Size(43, 13);
				LblMorada.TabIndex = 13;
				LblMorada.Text = "Morada";
				this.Controls.Add(LblMorada);

				Label LblTele = new Label();
				LblTele.AutoSize = true;
				LblTele.Location = new System.Drawing.Point(17, 224);
				LblTele.Name = "label7";
				LblTele.Size = new System.Drawing.Size(49, 13);
				LblTele.TabIndex = 18;
				LblTele.Text = "Telefone";
				this.Controls.Add(LblTele);

				Label LblEmail = new Label();
				LblEmail.AutoSize = true;
				LblEmail.Location = new System.Drawing.Point(17, 198);
				LblEmail.Name = "label8";
				LblEmail.Size = new System.Drawing.Size(32, 13);
				LblEmail.TabIndex = 17;
				LblEmail.Text = "Email";
				this.Controls.Add(LblEmail);

				Label LblData = new Label();
				LblData.AutoSize = true;
				LblData.Location = new System.Drawing.Point(17, 172);
				LblData.Name = "label9";
				LblData.Size = new System.Drawing.Size(104, 13);
				LblData.TabIndex = 16;
				LblData.Text = "Data de Nascimento";
				this.Controls.Add(LblData);

				Button BtnSave = new Button();
				BtnSave.Location = new System.Drawing.Point(20, 258);
				BtnSave.Name = "button1";
				BtnSave.Size = new System.Drawing.Size(145, 52);
				BtnSave.TabIndex = 19;
				BtnSave.Text = "Guardar";
				BtnSave.UseVisualStyleBackColor = true;
				BtnSave.Click += new System.EventHandler(button_Click);
				this.Controls.Add(BtnSave);

				Button BtnCancel = new Button();
				BtnCancel.Location = new System.Drawing.Point(184, 258);
				BtnCancel.Name = "button2";
				BtnCancel.Size = new System.Drawing.Size(145, 52);
				BtnCancel.TabIndex = 20;
				BtnCancel.Text = "Cancel";
				BtnCancel.UseVisualStyleBackColor = true;
				BtnCancel.Click += new System.EventHandler(button_Click);
				this.Controls.Add(BtnCancel);

				ComboBox CboSexo = new ComboBox();
				CboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				CboSexo.FormattingEnabled = true;
				CboSexo.Items.AddRange(new object[] {
			"Masculino",
			"Feminino",
			"Indefenido"});
				CboSexo.Location = new System.Drawing.Point(127, 39);
				CboSexo.Name = "CboSexo";
				CboSexo.Size = new System.Drawing.Size(172, 21);
				CboSexo.TabIndex = 21;
				CboSexo.Leave += new System.EventHandler(comboBox1_Leave);
				if (lstcli[0].Sexo == "M")
					CboSexo.SelectedItem = "Masculino";
				else
				if (lstcli[0].Sexo == "F")
					CboSexo.SelectedItem = "Feminino";
				else
					CboSexo.SelectedItem = "Indefenido";
				this.Controls.Add(CboSexo);

				DateTimePicker Data = new DateTimePicker();
				Data.Location = new System.Drawing.Point(127, 166);
				Data.Name = "DTPdate";
				Data.Size = new System.Drawing.Size(172, 20);
				Data.TabIndex = 22;
				DateTime time = lstcli[0].DataNasc;
				Data.Value = time;
				Data.Leave += new System.EventHandler(dateTimePicker1_Leave);
				this.Controls.Add(Data);
			}


		}

		private void comboBox1_Leave(object sender, EventArgs e)
		{
			ComboBox Cbo = sender as ComboBox;
			cli.Sexo= Cbo.Text.Substring(0, 1);
		}

		private void dateTimePicker1_Leave(object sender, EventArgs e)
		{
			DateTimePicker Dtp = sender as DateTimePicker;
			cli.DataNasc = Dtp.Value;
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
					Close();
					break;
			}
		}

		private void Save()
		{

			cli.Icon = lstcli[0].Icon;
			cli.Id_Login = lstcli[0].Id_Login;
			cli.Id_Cliente = lstcli[0].Id_Cliente;
			string result = InsertClientes.InsertCliente(cli);


			if (result == "sucesso")
				Close();
			else
				if (MessageBox.Show("" + result +"\nPretender Continuar as alterações?!?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
				{
					Close();
					
				}
		}
	}
}
