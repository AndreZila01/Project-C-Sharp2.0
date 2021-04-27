using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VesteBem_Admin
{
	public partial class FrmCliEFun : Form
	{
		public FrmCliEFun()
		{
			InitializeComponent();
		}

		private void FrmCliEFun_Load(object sender, EventArgs e)
		{

		}

		private void ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem item = sender as ToolStripMenuItem;
			

			if (item.Text == "Cliente")
			{
				panel1.Visible = true;
				
				for (int ds = 0; ds < 8; ds++)
				{
					Panel pnl = new Panel();
					pnl.Location = new Point(0, 82 * ds);
					pnl.Size = new Size(800, 82); pnl.BorderStyle = BorderStyle.None; pnl.BackColor = Color.AntiqueWhite; pnl.Margin = new Padding(0, 0, 0, 0); pnl.BackColor = Color.FromArgb((15*ds), (20*ds), 213);
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
					lblUser.Text = "label1";
					pnl.Controls.Add(lblUser);

					PictureBox pctEdit = new PictureBox();
					pctEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
					pctEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
					pctEdit.Location = new System.Drawing.Point(700, 21);
					pctEdit.Name = "pctEdit";
					pctEdit.Size = new System.Drawing.Size(33, 35);
					pctEdit.TabIndex = 2;
					pctEdit.TabStop = false;
					pnl.Controls.Add(pctEdit);

					PictureBox pctRemove = new PictureBox();
					pctRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
					pctRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
					pctRemove.Location = new System.Drawing.Point(755, 21);
					pctRemove.Name = "pctRemove";
					pctRemove.Size = new System.Drawing.Size(33, 35);
					pctRemove.TabIndex = 3;
					pctRemove.TabStop = false;
					pnl.Controls.Add(pctRemove);

					PictureBox pctUser = new PictureBox();
					pctUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
					pctUser.BackColor = System.Drawing.SystemColors.ButtonShadow;
					pctUser.Location = new System.Drawing.Point(12, 13);
					pctUser.Name = "pctUser";
					pctUser.Size = new System.Drawing.Size(44, 45);
					pctUser.TabIndex = 0;
					pctUser.TabStop = false;
					pnl.Controls.Add(pctUser);
				}

			}

		}
	}
}
