using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;


namespace VesteBem_Admin
{
	public partial class FrmCliEFun : Form
	{
		List<Cliente> lst = new List<Cliente>();
		public FrmCliEFun()
		{
			InitializeComponent();
		}

		private void FrmCliEFun_Load(object sender, EventArgs e)
		{
			if (!backgroundWorker1.IsBusy)
				backgroundWorker1.RunWorkerAsync();
		}

		private void ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem dss = sender as ToolStripMenuItem;

			if (dss.Text == "Cliente")
			{
				panel1.Visible = true;
				panel1.Controls.Clear();
				MemoryStream stream = new MemoryStream();
				int ds = 0;

				lst.ToList().ForEach(item => //for (int ds = 0; ds < lst.Count(); ds++)
				{
					Panel pnl = new Panel();
					pnl.Location = new Point(0, 82 * ds);
					pnl.Size = new Size(800, 82); pnl.BorderStyle = BorderStyle.None; pnl.BackColor = Color.AntiqueWhite; pnl.Margin = new Padding(0, 0, 0, 0); pnl.BackColor = Color.FromArgb((15 * ds), (20 * ds), 213);
					pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
					pnl.AutoScroll = true;
					panel1.Controls.Add(pnl);

					Label lblUser = new Label();
					lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
					lblUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
					lblUser.Location = new System.Drawing.Point(73, 21);
					lblUser.Name = "lblUser";
					lblUser.Size = new System.Drawing.Size(209, 27);
					lblUser.TabIndex = 1;
					lblUser.Text = item.Nome;
					pnl.Controls.Add(lblUser);

					PictureBox pctEdit = new PictureBox();
					pctEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
					pctEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
					pctEdit.Image = Properties.Resources.Pencil;
					pctEdit.SizeMode = PictureBoxSizeMode.Zoom;
					pctEdit.Location = new System.Drawing.Point(700, 21);
					pctEdit.Name = @"pctEdit\"+ds;
					pctEdit.Size = new System.Drawing.Size(33, 35);
					pctEdit.TabIndex = 2;
					pctEdit.TabStop = false;
					pctEdit.Click += new System.EventHandler(pctEdit_Click);
					pctEdit.Image = Properties.Resources.Pencil;
					pctEdit.Tag = "" + item.Id_Login;
					pnl.Controls.Add(pctEdit);

					PictureBox pctRemove = new PictureBox();
					pctRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
					pctRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
					pctRemove.Location = new System.Drawing.Point(755, 21);
					pctRemove.Name = "pctRemove";
					pctRemove.Image = Properties.Resources.Close_trash;
					pctRemove.SizeMode = PictureBoxSizeMode.Zoom;
					pctRemove.Size = new System.Drawing.Size(33, 35);
					pctRemove.TabIndex = 3;
					pctRemove.TabStop = false;
					pctRemove.MouseEnter += new System.EventHandler(pctRemove_MouseEnter);
					pctRemove.MouseLeave += new System.EventHandler(pctRemove_MouseLeave);
					pnl.Controls.Add(pctRemove);

					PictureBox pctUser = new PictureBox();
					pctUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
					pctUser.BackColor = System.Drawing.SystemColors.ButtonShadow;
					pctUser.Image = Properties.Resources.user;
					pctUser.Location = new System.Drawing.Point(12, 13);
					pctUser.Name = "pctUser";
					pctUser.SizeMode = PictureBoxSizeMode.Zoom;
					pctUser.Size = new System.Drawing.Size(44, 45);
					pctUser.TabIndex = 0;
					pctUser.TabStop = false;
					pnl.Controls.Add(pctUser);
					ds++;

				});

			}

		}

		private void pctEdit_Click(object sender, EventArgs e)
		{
			Cliente cli = new Cliente();
			PictureBox pct = sender as PictureBox;
			int ds = int.Parse(pct.Name.Substring(8, (pct.Name.Length-8)));
			string message = "Nome: ";
			string Title = "Editar campos";
		Nome:
			string name = Interaction.InputBox(message, Title, lst[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Nome);//Interaction.InputBox(message, title, defaultValue, 100, 100);
			if (lst.FirstOrDefault(Item => Item.Nome == name) != null)
			{
				message = "Essse nome já existe\nMeta outro nome"; goto Nome;
			}
			else
			if (System.Text.RegularExpressions.Regex.IsMatch(name, "[^a-zA-Z] + $"))
			{
				message = "Só é possível meter letras"; goto Nome;
			}
			else
				var temp = name.Length >100 ? cli.Nome = name.Substring(100) : cli.Nome = name;
																				  

			#region Rascunhos de Interation

			/*if (valor.Trim().Length == 0)//trim remove espaços
					{
						MessageBox.Show("Valor invalido, meta um valor superior a 0!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
						var d = i!=0 ? i--:i=0;
					}
					else
					{
						if(System.Text.RegularExpressions.Regex.IsMatch(valor, "[^0-9]"))
						{
							MessageBox.Show("Valor invalido, meta um valor superior a 0!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
							var d = i != 0 ? i-- : i = 0;
						}
						else { alturas[i] = int.Parse(valor); lstAlturas.Items.Add(alturas[i]); }
					}
			if (Nome == string.Empty)//trim remove espaços
					{
						MessageBox.Show("Nome invalido, meta um nome sem numeros!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
						var d = i != 0 ? i-- : i = 0;
					}
					else
					{
						if (System.Text.RegularExpressions.Regex.IsMatch(Nome, "[^a-zA-Z] + $"))
						{
							MessageBox.Show("Nome invalido, meta um nome sem numeros!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
							var d = i != 0 ? i-- : i = 0;
						}
						else { nomes[i] = Nome; lstNome.Items.Add(nomes[i]); }
					}
			 */
			#endregion
		}

		private void pctRemove_MouseLeave(object sender, EventArgs e)
		{
			PictureBox pct = sender as PictureBox;

			pct.Image = Properties.Resources.Close_trash;
		}

		private void pctRemove_MouseEnter(object sender, EventArgs e)
		{
			PictureBox pct = sender as PictureBox;

			pct.Image = Properties.Resources.Open_trash;
		}

		private void FrmCliEFun_SizeChanged(object sender, EventArgs e)
		{
			//this.SizeChanged += ToolStripMenuItem_Click;
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			lst = ConsultaClientes.ConsultaCliente();
			backgroundWorker1.DoWork += ToolStripMenuItem_Click;
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			//backgroundWorker1.RunWorkerAsync += ToolStripMenuItem_Click;
		}
	}
}
