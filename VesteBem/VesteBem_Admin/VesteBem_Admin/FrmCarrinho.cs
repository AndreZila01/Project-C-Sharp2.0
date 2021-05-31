using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;
using static VesteBem_Admin.Estado;

namespace VesteBem_Admin
{
	public partial class FrmCarrinho : Form
	{
		public FrmCarrinho()
		{
			InitializeComponent();
		}
		List<Estados> lstEstado = new List<Estados>();
		List<DetalhesEncomendas> lstDetalhesEncomendas = new List<DetalhesEncomendas>();
		List<Cliente> lstcli = new List<Cliente>();
		List<Produtos> lstProduto = new List<Produtos>();
		private void FrmCarrinho_Load(object sender, EventArgs e)
		{
			this.ShowIcon = false;
			if (!backgroundWorker1.IsBusy)
				backgroundWorker1.RunWorkerAsync();
		}
		private void button2_Click(object sender, EventArgs e)
		{

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

		private void PctRemove_Click(object sender, EventArgs e)
		{
			PictureBox Pct = sender as PictureBox;
			int value = 0;
			flowLayoutPanel1.Controls.Clear();
			if (Pct.Name == "Remove")
				lstDetalhesEncomendas.Remove(lstDetalhesEncomendas[int.Parse(Pct.Tag.ToString())]); label6.Tag = "00";
			lstDetalhesEncomendas.ToList().ForEach(item =>
			{
				int index = lstProduto.FindIndex(r => r.IdProduto == item.Id_Produtos);
				DetalhesEncomendas Detalhes = new DetalhesEncomendas();
				Panel Pnl = new Panel();
				Pnl.Location = new System.Drawing.Point(0, 0);
				Pnl.Name = "panel1";
				Pnl.BackColor = Color.Red;
				Pnl.Size = new System.Drawing.Size(245, 30);//271; 150
				Pnl.TabIndex = 0;
				flowLayoutPanel1.Controls.Add(Pnl);

				Label LblNome = new Label();
				LblNome.AutoSize = true;
				LblNome.Location = new System.Drawing.Point(5, 10);
				LblNome.Name = "label6";
				LblNome.Size = new System.Drawing.Size(35, 13);
				LblNome.TabIndex = 0;
				LblNome.BackColor = Color.LightGray;
				LblNome.Tag = pictureBox1.Tag.ToString();
				var ds = lstProduto[index].Nome.Length > 20 ? LblNome.Text = "" + lstProduto[index].Nome.Substring(0, 20) : LblNome.Text = "" + lstProduto[index].Nome;
				LblNome.Click += new System.EventHandler(label_Click);
				Pnl.Controls.Add(LblNome);

				Label LblPreco = new Label();
				LblPreco.AutoSize = true;
				LblPreco.Location = new System.Drawing.Point(175, 10);
				LblPreco.Name = "label7";
				LblPreco.Size = new System.Drawing.Size(25, 13);
				LblPreco.TabIndex = 1;
				LblPreco.BackColor = Color.Green;
				LblPreco.Text = "" + lstProduto[index].Valor + "€";
				LblPreco.Tag = "" + lstProduto[index].Valor;
				Pnl.Controls.Add(LblPreco);

				Label LblQuantidade = new Label();
				LblQuantidade.Location = new System.Drawing.Point(135, 10);
				LblQuantidade.Name = "label7";
				LblQuantidade.Size = new System.Drawing.Size(35, 13);
				LblQuantidade.TabIndex = 1;
				LblQuantidade.BackColor = Color.Gray;
				LblQuantidade.Text = " " + item.QuantEnc + " x";
				LblQuantidade.Tag = "" + item.QuantEnc;
				Pnl.Controls.Add(LblQuantidade);

				PictureBox PctRemove = new PictureBox();
				PctRemove.Image = Properties.Resources.Red_Remove;
				PctRemove.Location = new System.Drawing.Point(225, 10);
				PctRemove.Size = new System.Drawing.Size(15, 13);
				PctRemove.Name = "Remove";
				PctRemove.SizeMode = PictureBoxSizeMode.Zoom;
				PctRemove.Click += new System.EventHandler(PctRemove_Click);
				PctRemove.MouseLeave += new System.EventHandler(PctRemove_MouseLeave);
				PctRemove.MouseEnter += new System.EventHandler(PctRemove_MouseEnter);
				PctRemove.Tag = "" + value;
				Pnl.Controls.Add(PctRemove);

				label6.Tag = "" + (double.Parse(label6.Tag.ToString()) + ((item.QuantEnc * lstProduto[index].Valor)));
				label6.Text = "Total: " + label6.Tag + "€";
				value++;
			});
			if (lstDetalhesEncomendas.Count == 0)
			{
				label6.Tag = "0";
				label6.Text = "Total: " + label6.Tag + "€";
			}
		}

		private void label_Click(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			MessageBox.Show("" + lstProduto[int.Parse(lbl.Tag.ToString())].Nome);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			#region Rascunho
			//SqlCommand command = new SqlCommand();
			//using (SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			//{
			//	command.CommandText = "SPUpdateCliente";
			//	command.CommandType = System.Data.CommandType.StoredProcedure;
			//	try
			//	{
			//		command.Parameters.Add(new SqlParameter("Nome", cli.Nome));
			//		command.Parameters.Add(new SqlParameter("Sexo", cli.Sexo));
			//		command.Parameters.Add(new SqlParameter("Nif", cli.Nif));
			//		command.Parameters.Add(new SqlParameter("Morada", cli.Morada));
			//		command.Parameters.Add(new SqlParameter("CodPostal", cli.CodPostal));
			//		command.Parameters.Add(new SqlParameter("Localidade", cli.Localidade));
			//		command.Parameters.Add(new SqlParameter("DataNasc", cli.DataNasc));
			//		command.Parameters.Add(new SqlParameter("Email", cli.Email));
			//		command.Parameters.Add(new SqlParameter("Telefone", cli.Telefone));
			//		command.Parameters.Add(new SqlParameter("Id_Cliente", cli.Id_Cliente));
			//		command.Parameters.Add(new SqlParameter("Id_Login", cli.Id_Login));

			//		command.Connection = liga;

			//		liga.Open();

			//		command.ExecuteNonQuery();
			//		return "sucesso";
			//	}
			//	catch (Exception ex)
			//	{
			//		return ex.Message;
			//	}
			//	finally
			//	{
			//		liga.Close();
			//	}
			//}
			#endregion
			DateTime date = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
			Encomenda enc = new Encomenda();
			enc.EstadoEncomendas = comboBox2.Text;
			enc.DataEntrega = dateTimePicker2.Value;
			enc.DataEncomenda = date;
			enc.Id_Cliente = Clientes.SelectIdCliente(comboBox1.Text);
			enc.ValorEncomendas = double.Parse(textBox1.Text);
			EncomendasEDetalhesEProduto.InsertEncomendas(enc, lstEstado[lstEstado.FindIndex(ash => ash.Estado == comboBox2.SelectedItem)].IdEstado);
			enc.IdEncomendas = EncomendasEDetalhesEProduto.SelectIdEncomenda(enc.ValorEncomendas, enc.Id_Cliente, enc.DataEncomenda, enc.DataEntrega, lstEstado[lstEstado.FindIndex(p => p.Estado == enc.EstadoEncomendas)].IdEstado);
			//int idEncomenda = EncomendasEDetalhesEProduto.SelectIdEncomenda(enc.Id_Cliente);
			int temp = 0;
			lstDetalhesEncomendas.ToList().ForEach(item=>{
				lstDetalhesEncomendas[temp].Id_Encomendas = enc.IdEncomendas;
				temp++;
			});
			EncomendasEDetalhesEProduto.InsertDetalhes(lstDetalhesEncomendas);
			lstDetalhesEncomendas.Clear();
			panel2.Enabled = false;
			textBox1.Text = "";
			comboBox1.Text = "";
			flowLayoutPanel1.Controls.Clear();
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			pictureBox1.Image = lstProduto[comboBox3.SelectedIndex].Icon;
			pictureBox1.Tag = comboBox3.SelectedIndex;
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			//int count = 0;
			List<int> lstIdProduto = new List<int>();
			List<int> lstId = new List<int>();
			List<DetalhesEncomendas> lst = new List<DetalhesEncomendas>();
			Encomenda enc = new Encomenda();
			enc.ValorEncomendas = double.Parse(label6.Tag.ToString());
			int ds = 0;
			List<DetalhesEncomendas> indexT = new List<DetalhesEncomendas>();//new int[lstDetalhesEncomendas.Count()];

			lstDetalhesEncomendas.ToList().ForEach(item =>
			{
				DetalhesEncomendas Pre = new DetalhesEncomendas();
				Pre.Id_Produtos = item.Id_Produtos;
				Pre.QuantEnc = item.QuantEnc;
				Pre.Id_Encomendas = ds;
				lst.Add(Pre);
				ds++;
			});

			lst.ToList().ForEach(item =>
			{
				#region Rascunho 
				//var index = lstDetalhesEncomendas.IndexOf(lst);
				//int indexT = listEmployee.FindIndex(r >= r.Name == findName);
				//int [] dsssssss = lstDetalhesEncomendas.FindAll(""+item.IdProduto);
				#endregion

				int index = 0;
				int quant = 0;

				var count = lstDetalhesEncomendas.Count(s => (s.Id_Produtos == item.Id_Produtos));
				if (count > 1)
				{
					#region Rascunho 
					//lstDetalhesEncomendas.ToList().ForEach(itemss =>
					//{
					//	if (item.Id_Produtos == itemss.Id_Produtos)
					//	{
					//		DetalhesEncomendas detalhes = new DetalhesEncomendas();
					//		detalhes.Id_Encomendas = itemss.Id_Encomendas;
					//		detalhes.QuantEnc = item.QuantEnc;
					//		indexT.Add(detalhes);//indexT[index] = item.QuantEnc;
					//	}
					//	index++;
					//});
					//indexT.ToList().ForEach(items =>
					//{
					//	var dss = indexT[indexT.LastIndexOf(items)];
					//	quant += items;
					//});
					#endregion
					index = 0;
					lstDetalhesEncomendas.ToList().ForEach(itemss =>
					{
						if (item.Id_Produtos == itemss.Id_Produtos)
						{

							//lstDetalhesEncomendas.ToList().ForEach(itemsss =>
							//{
							//	if (item.IdProduto == itemsss.Id_Produtos)
							//	{
							DetalhesEncomendas detalhes = itemss;
							count = lstDetalhesEncomendas.Count(s => (s.Id_Produtos == item.Id_Produtos));
							if (lstDetalhesEncomendas.Count > 1 && (count > 1) && !((lst[lstDetalhesEncomendas.Count() - 1].Id_Encomendas == itemss.Id_Encomendas && lst[lstDetalhesEncomendas.Count() - 1].Id_Produtos == itemss.Id_Produtos)))
							{
								quant += itemss.QuantEnc;
								lstDetalhesEncomendas.Remove(detalhes);
								int test = lstDetalhesEncomendas.FindIndex(ash => ash.Id_Produtos == (itemss.Id_Produtos));//lstDetalhesEncomendas.IndexOf(lst.Where(p => p.Id_Encomendas == itemss.Id_Encomendas).FirstOrDefault());
								lstDetalhesEncomendas[test].QuantEnc += quant;
							}
							index++;
							//Verificar se é o ultimo index da lista, se for não apagar o valor

							//indexT.Add(item.QuantEnc);//indexT[index] = item.QuantEnc;
							//	}
							//});
						}
						//index++;
					});

					//lstDetalhesEncomendas
				}
				//count++;
			});
			//Encomenda obj = lstDetalhesEncomendas.Find(x => (x.Name == "product name"));
			//Certificar se o utilizador meteu varias vezes os produtos
			if (lstDetalhesEncomendas.Count() > 0)
			{
				textBox1.Text = label6.Tag.ToString();
				comboBox2.SelectedItem = "Na Fabrica";
				textBox1.Enabled = false;
				panel2.Enabled = true;
			}
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			label6.Tag = "00";
			lstEstado = Funcionarios.SelectEstado();
			lstEstado.ToList().ForEach(item =>
			{
				if (item.Estado == "Na Fabrica")
					comboBox2.Items.Add(item.Estado);
			});
			lstcli = Clientes.SelectId();
			lstcli.ToList().ForEach(item =>
			{
				comboBox1.Items.Add(item.Nome);
			});
			lstProduto = EncomendasEDetalhesEProduto.SelectProdutos();
			lstProduto.ToList().ForEach(item =>
			{
				comboBox3.Items.Add(item.IdProduto + " - " + item.Nome);
			});

			pictureBox2.Click += PctRemove_Click;
			dateTimePicker1.Value = DateTime.Today;
			dateTimePicker1.MinDate = DateTime.Today;
			try
			{
				var ds = DateTime.Today.Month!=12? dateTimePicker2.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 4): dateTimePicker2.Value = new DateTime((DateTime.Today.Year+1), 1, 4);
			}
			catch
			{
				var ds = DateTime.Today.Month != 12 ? dateTimePicker2.Value = new DateTime(DateTime.Today.Year, (DateTime.Today.Month+1), 1) : dateTimePicker2.Value = new DateTime((DateTime.Today.Year+1), 1, 1);
			}
			try
			{
				var ds = DateTime.Today.Month != 12 ? dateTimePicker2.MinDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 1) : dateTimePicker2.MinDate = new DateTime((DateTime.Today.Year+1), 1, 1);
			}
			catch
			{
				var ds = DateTime.Today.Month != 12 ? dateTimePicker2.MinDate = new DateTime(DateTime.Today.Year, (DateTime.Today.Month+1),1): dateTimePicker2.MinDate = new DateTime((DateTime.Today.Year+1), 1, 1);
			}
			int data; int mes = DateTime.Today.Month + 4;
			if (mes > 12)
				mes -= 12;
			if (mes != 2)
			{
				var temp = mes == 1 && mes == 3 && mes == 5 && mes == 7 && mes == 8 && mes == 9 && mes == 12 ? data = 31 : data = 30;
				//var temp = mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 9 || mes == 12 ? data = 31 : data = 28;
			}
			else
				if (DateTime.Today.Year % 400 == 0 || (DateTime.Today.Year % 4 == 0 && DateTime.Today.Year % 100 != 0))
				data = 29;
			else
				data = 28;

			
			dateTimePicker2.MaxDate = new DateTime(DateTime.Today.Year, mes, data);
		}

		private void FrmCarrinho_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormCollection fc = Application.OpenForms;
			foreach (Form frm in fc)
				frm.WindowState = FormWindowState.Normal;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if(comboBox3.Text!="")
			try
			{
				DetalhesEncomendas Detalhes = new DetalhesEncomendas();
				Panel Pnl = new Panel();
				Pnl.Location = new System.Drawing.Point(0, 0);
				Pnl.Name = "panel1";
				Pnl.BackColor = Color.Red;
				Pnl.Size = new System.Drawing.Size(245, 30);//271; 150
				Pnl.TabIndex = 0;
				flowLayoutPanel1.Controls.Add(Pnl);

				Label LblNome = new Label();
				LblNome.AutoSize = true;
				LblNome.Location = new System.Drawing.Point(5, 10);
				LblNome.Name = "label6";
				LblNome.Size = new System.Drawing.Size(35, 13);
				LblNome.TabIndex = 0;
				LblNome.BackColor = Color.LightGray;
				LblNome.Tag = pictureBox1.Tag.ToString();
				var ds = lstProduto[int.Parse(pictureBox1.Tag.ToString())].Nome.Length > 20 ? LblNome.Text = "" + lstProduto[int.Parse(pictureBox1.Tag.ToString())].Nome.Substring(0, 20) : LblNome.Text = "" + lstProduto[int.Parse(pictureBox1.Tag.ToString())].Nome;
				LblNome.Click += new System.EventHandler(label_Click);
				Pnl.Controls.Add(LblNome);

				Label LblPreco = new Label();
				LblPreco.AutoSize = true;
				LblPreco.Location = new System.Drawing.Point(175, 10);
				LblPreco.Name = "label7";
				LblPreco.Size = new System.Drawing.Size(25, 13);
				LblPreco.TabIndex = 1;
				LblPreco.BackColor = Color.Green;
				LblPreco.Text = "" + lstProduto[int.Parse(pictureBox1.Tag.ToString())].Valor + "€";
				LblPreco.Tag = "" + lstProduto[int.Parse(pictureBox1.Tag.ToString())].Valor;
				Pnl.Controls.Add(LblPreco);

				Label LblQuantidade = new Label();
				LblQuantidade.Location = new System.Drawing.Point(135, 10);
				LblQuantidade.Name = "label7";
				LblQuantidade.Size = new System.Drawing.Size(35, 13);
				LblQuantidade.TabIndex = 1;
				LblQuantidade.BackColor = Color.Gray;
				LblQuantidade.TextAlign = ContentAlignment.MiddleLeft;
				LblQuantidade.Text = numericUpDown1.Value + " x";
				LblQuantidade.Tag = "" + numericUpDown1.Value;
				Pnl.Controls.Add(LblQuantidade);

				PictureBox PctRemove = new PictureBox();
				PctRemove.Image = Properties.Resources.Red_Remove;
				PctRemove.Name = "Remove";
				PctRemove.Location = new System.Drawing.Point(225, 10);
				PctRemove.Size = new System.Drawing.Size(15, 13);
				PctRemove.SizeMode = PictureBoxSizeMode.Zoom;
				PctRemove.Click += new System.EventHandler(PctRemove_Click);
				PctRemove.MouseLeave += new System.EventHandler(PctRemove_MouseLeave);
				PctRemove.MouseEnter += new System.EventHandler(PctRemove_MouseEnter);
				PctRemove.Tag = "" + lstDetalhesEncomendas.Count();
				Pnl.Controls.Add(PctRemove);

				label6.Tag = "" + (double.Parse(label6.Tag.ToString()) + ((int.Parse(LblQuantidade.Tag.ToString()) * double.Parse(LblPreco.Tag.ToString()))));
				label6.Text = "Total: " + label6.Tag + "€";

				Detalhes.Id_Encomendas = lstDetalhesEncomendas.Count();
				Detalhes.Id_Produtos = lstProduto[int.Parse(pictureBox1.Tag.ToString())].IdProduto;
				Detalhes.QuantEnc = int.Parse(numericUpDown1.Value.ToString());
				lstDetalhesEncomendas.Add(Detalhes);
			}
			catch { }
		}
	}
	public class Estado
	{



		//public static List<Produtos> SelectProdutos()
		//{
		//	List<Produtos> lstProdutos = new List<Produtos>();
		//	SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		//	SqlCommand comando = new SqlCommand("Select * From tbl_Produtos", liga);
		//	SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
		//	try
		//	{
		//		ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
		//		string str = string.Empty;
		//		DataSet dataSet = new DataSet();
		//		dataAdapter.Fill(dataSet);
		//		comando.Connection = liga;
		//		liga.Open();
		//		using (SqlDataReader oReader = comando.ExecuteReader())
		//		{
		//			int ds = 0;
		//			while (oReader.Read())
		//			{
		//				Produtos pro = new Produtos();
		//				try
		//				{
		//					Byte[] data = new Byte[0];
		//					data = (Byte[])(dataSet.Tables[0].Rows[ds]["Icon"]);
		//					MemoryStream mem = new MemoryStream(data);

		//					pro.Icon = Image.FromStream(mem);
		//				}
		//				catch
		//				{
		//					pro.Icon = Properties.Resources.user;
		//				}
		//				pro.IdProduto = int.Parse(oReader["IdProduto"].ToString());
		//				pro.Nome = oReader["Nome"].ToString();
		//				pro.Valor = double.Parse(oReader["Valor"].ToString());
		//				pro.NomedaEmpresa = (oReader["NomedaEmpresa"].ToString());
		//				pro.CategoriaClass = oReader["CategoriaClasse"].ToString();
		//				pro.CategoriaSubClass = oReader["CategoriaSubClasse"].ToString();
		//				pro.Sexo = oReader["Sexo"].ToString();
		//				ds++;
		//				lstProdutos.Add(pro);
		//			}
		//		}
		//	}
		//	catch
		//	{

		//	}
		//	finally
		//	{
		//		liga.Close();
		//	}

		//	return lstProdutos;
		//	//List<Produtos> lstProduto = new List<Produtos>();
		//	//SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		//	//SqlCommand comando = new SqlCommand("Select * From tbl_Produtos", liga);
		//	//try
		//	//{
		//	//	DataSet dataSet = new DataSet();
		//	//	SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
		//	//	dataAdapter.Fill(dataSet);
		//	//	comando.Connection = liga;
		//	//	liga.Open();
		//	//	using (SqlDataReader oReader = comando.ExecuteReader())
		//	//	{
		//	//		ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

		//	//		int dss = 0;
		//	//		while (oReader.Read())
		//	//		{
		//	//			Byte[] data = new Byte[0];
		//	//			data = (Byte[])(dataSet.Tables[0].Rows[dss]["Icon"]);
		//	//			MemoryStream mem = new MemoryStream(data);

		//	//			Produtos pro = new Produtos();
		//	//			pro.Icon = Image.FromStream(mem);
		//	//			pro.IdProduto = int.Parse(oReader["IdProduto"].ToString());
		//	//			pro.Nome = (oReader["Nome"].ToString());
		//	//			pro.Valor = double.Parse(oReader["Valor"].ToString());
		//	//			pro.NomedaEmpresa = (oReader["NomedaEmpresa"].ToString());
		//	//			pro.CategoriaClass = (oReader["CategoriaClasse"].ToString());
		//	//			pro.CategoriaSubClass = (oReader["CategoriaSubClasse"].ToString());
		//	//			pro.Sexo = (oReader["Sexo"].ToString());
		//	//			dss++;
		//	//			lstProduto.Add(pro);
		//	//		}
		//	//	}
		//	//}
		//	//catch(Exception ex)
		//	//{
		//	//	return null;
		//	//}
		//	//finally
		//	//{
		//	//	liga.Close();
		//	//}

		//	//return lstProduto;
		//}
		//public static List<Estados> SelectFuncao()
		//{
		//	List<Estados> lst = new List<Estados>();
		//	SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		//	SqlCommand comando = new SqlCommand("Select IdEstado, Estado From tblEstado", liga);
		//	try
		//	{
		//		comando.Connection = liga;
		//		liga.Open();
		//		using (SqlDataReader oReader = comando.ExecuteReader())
		//		{
		//			while (oReader.Read())
		//			{
		//				Estados est = new Estados();
		//				est.IdEstado = int.Parse(oReader["IdEstado"].ToString());
		//				est.Estado = (oReader["Estado"].ToString());
		//				lst.Add(est);
		//			}
		//		}
		//	}
		//	catch
		//	{
		//		return null;
		//	}
		//	finally
		//	{
		//		liga.Close();
		//	}

		//	return lst;
		//}
		//public static string InsertEncomendas(Encomenda enc, int IdEstado)
		//{
		//	SqlCommand command = new SqlCommand();
		//	using (SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
		//	{
		//		command.CommandText = "SpInsertEncomenda";
		//		command.CommandType = System.Data.CommandType.StoredProcedure;

		//		try
		//		{
		//			command.Parameters.Add(new SqlParameter("ValorEncomendas", enc.ValorEncomendas));
		//			command.Parameters.Add(new SqlParameter("EstadoEncomendas", IdEstado));
		//			command.Parameters.Add(new SqlParameter("DataEncomenda", enc.DataEncomenda));
		//			command.Parameters.Add(new SqlParameter("DataEntrega", enc.DataEntrega));
		//			command.Parameters.Add(new SqlParameter("Id_Cliente", enc.Id_Cliente));

		//			command.Connection = liga;

		//			liga.Open();

		//			command.ExecuteNonQuery();
		//		}
		//		catch(Exception ex)
		//		{

		//		}
		//		liga.Close();
		//		return "sucesso";
		//	}
		//}
		//public static string InsertDetalhes(List<DetalhesEncomendas> lst)
		//{
		//	SqlCommand command = new SqlCommand();
		//	using (SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
		//	{
		//		command.CommandText = "SpInsertDetalhes";
		//		command.CommandType = System.Data.CommandType.StoredProcedure;
		//		lst.ToList().ForEach(item =>
		//		{
		//			try
		//			{
		//				command.Parameters.Add(new SqlParameter("Id_Encomendas", item.Id_Encomendas));
		//				command.Parameters.Add(new SqlParameter("Id_Produtos", item.Id_Produtos));
		//				command.Parameters.Add(new SqlParameter("QuantEnc", item.QuantEnc));

		//				command.Connection = liga;

		//				liga.Open();

		//				command.ExecuteNonQuery();
		//			}
		//			catch (Exception ex)
		//			{

		//			}
		//		});
		//		liga.Close();
		//		return "sucesso";
		//	}
		//}
		//public static int SelectIdEncomenda(int cli)
		//{
		//	SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		//	SqlCommand comando = new SqlCommand("Select idEncomendas From tbl_Encomendas", liga);
		//	int idEncomenda = 0;
		//	try
		//	{
		//		comando.Connection = liga;
		//		liga.Open();
		//		using (SqlDataReader oReader = comando.ExecuteReader())
		//		{
		//			if (oReader.Read())
		//				if (int.Parse(oReader["IdEncomendas"].ToString()) == cli)
		//					idEncomenda = int.Parse(oReader["IdEncomendas"].ToString());
		//			liga.Close();

		//			return idEncomenda;
		//		}
		//	}
		//	catch
		//	{
		//		return idEncomenda;
		//	}

		//}
		//public static int SelectIdCliente(string cli)
		//{
		//	SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		//	SqlCommand comando = new SqlCommand("Select IdCliente From tbl_Cliente WHERE Nome like '"+cli+"'", liga);
		//	int idcli = 0;
		//	try
		//	{
		//		comando.Connection = liga;
		//		liga.Open();
		//		using (SqlDataReader oReader = comando.ExecuteReader())
		//		{
		//			if (oReader.Read())
		//				idcli = int.Parse(oReader["IdCliente"].ToString());


		//		}
		//		return idcli; 
		//	}
		//	catch
		//	{
		//		return idcli;
		//	}

		//}
		//public static List<Cliente> SelectId()
		//{
		//	List<Cliente> lstcli = new List<Cliente>();
		//	SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		//	SqlCommand comando = new SqlCommand("Select IdCliente, Nome From tbl_Cliente", liga);
		//	try
		//	{
		//		comando.Connection = liga;
		//		liga.Open();
		//		using (SqlDataReader oReader = comando.ExecuteReader())
		//		{
		//			while (oReader.Read())
		//			{
		//				Cliente cli = new Cliente();
		//				cli.Id_Cliente = (int.Parse(oReader["IdCliente"].ToString()));
		//				cli.Nome = oReader["Nome"].ToString();

		//				lstcli.Add(cli);
		//			}
		//			liga.Close();
		//		}
		//	}
		//	catch
		//	{
		//		return null;
		//	}

		//	return lstcli;
		//}
	}
}
