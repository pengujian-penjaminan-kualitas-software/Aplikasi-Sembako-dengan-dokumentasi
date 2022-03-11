using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SEMBAKO_JAYA
{
	/// <summary>
	////// Pada bagian ini terdapat query dan class koneksi yang menghubungkan database databuyer atau data admin
	/// </summary>
	public partial class ManajemenAdmin : Form
	{
		SqlConnection co = new SqlConnection("Server = E3-SENTRY; Database = DataUser; integrated security = true");
		SqlCommand mycommand = new SqlCommand();
		SqlDataAdapter myadapter = new SqlDataAdapter();
		
		public ManajemenAdmin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Bersihkan();
			readdata();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Bersihkan() {
			textBox1.Text="";
			textBox2.Text="";
			textBox3.Text="";
			textBox4.Text="";

		}
		
			void readdata() {
			
			try {
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from TabelUser";
				DataSet ds= new DataSet();
				if (myadapter.Fill(ds,"TabelUser")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "TabelUser";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "")
			{
				MessageBox.Show("Isi setiap kolom dulu ");
			}
			else
			{
				try{
					mycommand.Connection = co;
					myadapter.SelectCommand = mycommand;
					mycommand.CommandText = "INSERT INTO TabelUser VALUES ('"+textBox1.Text+"',	'"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')";
					DataSet ds= new DataSet();
					if (myadapter.Fill(ds,"TabelUser")>0){
						dataGridView1.DataSource = ds;
						dataGridView1.DataMember = "TabelUser";
					}
					MessageBox.Show("Data berhasil masuk");
						readdata();
						Bersihkan();
					co.Close();
				}
				catch (Exception ex){
					MessageBox.Show("Data Gagal di input");
			}
				
			}
		}
		void button2_Click(object sender, EventArgs e)
		{
			if(textBox1.Text.Trim() == ""|| textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "")
			{
				MessageBox.Show("Isi setiap kolom dulu ");
			}
			else
			{
				try{
					mycommand.Connection = co;
					myadapter.SelectCommand = mycommand;
					mycommand.CommandText = "UPDATE INTO TabelUser VALUES ('"+textBox1.Text+"',	'"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')";
					DataSet ds= new DataSet();
					if (myadapter.Fill(ds,"TabelUser")>0){
						dataGridView1.DataSource = ds;
						dataGridView1.DataMember = "TabelUser";
					}
					MessageBox.Show("Data berhasil diperbarui");
						readdata();
						Bersihkan();
					co.Close();
				}
				catch (Exception ex){
					MessageBox.Show(ex.ToString());
			}
				
			}
		}
		void button3_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Yakin ingin menghapus "+textBox2.Text+"?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try{
					mycommand.Connection = co;
					myadapter.SelectCommand = mycommand;
					mycommand.CommandText = "DELETE FROM TabelUser where KodeUser='"+textBox1.Text+"'";
					DataSet ds= new DataSet();
					if (myadapter.Fill(ds,"TabelUser")>0){
						dataGridView1.DataSource = ds;
					}
					MessageBox.Show("Hapus Data berhasil !");
							readdata();
							Bersihkan();
						co.Close();
			}
				catch (Exception ex){
					MessageBox.Show(ex.ToString());
			}
				
			}
		}
		void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
					DataGridViewRow row = this.dataGridView1.Rows [e.RowIndex];
					textBox1.Text = row.Cells["KodeUser"].Value.ToString();
					textBox2.Text = row.Cells["NamaUser"].Value.ToString();
					textBox3.Text = row.Cells["PasswordUser"].Value.ToString();
					textBox4.Text = row.Cells["LevelUser"].Value.ToString();
					
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
		

			}
		}
		void button4_Click(object sender, EventArgs e)
		{
			admindashboard dash= new admindashboard();
			dash.Show();
			this.Hide();
		}
	}
}
