using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//untuk menggunakan sistem sqlclient

namespace SEMBAKO_JAYA
{
	/// <summary>
	/// Pada bagian ini terdapat query dan class koneksi yang menghubungkan database databuyer atau data pembeli
	/// </summary>
	public partial class Manajemen_Pembeli : Form
	{
		SqlConnection co = new SqlConnection("Server = E3-SENTRY; Database = Databuyer; integrated security = true");
		SqlCommand mycommand = new SqlCommand();
		SqlDataAdapter myadapter = new SqlDataAdapter();
		
		public Manajemen_Pembeli()
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

		}
		
			void readdata() {
			
			try {
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from data_pembeli";
				DataSet ds= new DataSet();
				if (myadapter.Fill(ds,"data_pembeli")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_pembeli";
				}
				co.Close();
				//menutup koneksi
			}
			catch (Exception ex){
				//Exception Handling merupakan mekanisme yang paling diperlukan dalam menangani error yang terjadi pada saat runtime
				MessageBox.Show(ex.ToString());
			}
		}
		void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
					DataGridViewRow row = this.dataGridView1.Rows [e.RowIndex];
					textBox1.Text = row.Cells["Nama"].Value.ToString();
					textBox2.Text = row.Cells["NoHp"].Value.ToString();
					textBox3.Text = row.Cells["Alamat"].Value.ToString();
					
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
		

			}
		}
		void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			//menyembunyikan form yang sebelumnya terbuka
			dashboard dash= new dashboard();
			dash.Show();
		}
		void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "")
			{
				MessageBox.Show("Isi setiap kolom dulu ");
			}
			else
			{
				try{
					mycommand.Connection = co;
					myadapter.SelectCommand = mycommand;
					//kode ini berfungsi untuk mengecek dan query untuk menambahkan pembeli  barang dengan 
				//perintah INSERT
					mycommand.CommandText = "INSERT INTO data_pembeli VALUES ('"+textBox1.Text+"',	'"+textBox2.Text+"','"+textBox3.Text+"')";
					DataSet ds= new DataSet();
					if (myadapter.Fill(ds,"data_pembeli")>0){
						dataGridView1.DataSource = ds;
						dataGridView1.DataMember = "data_pembeli";
					}
					MessageBox.Show("Data berhasil masuk");
					//messagebox atau dialog pesan untuk memberitahu bahwa data berhasil di insert
						readdata();
						Bersihkan();
					co.Close();
				}
				catch (Exception ex){
					MessageBox.Show("Data Gagal di input");
					//jika eror atau gagal menangkap database maka akan muncul peringatan data gagal di input
			}
				
			}
		}
		void button2_Click(object sender, EventArgs e)
		{
			// TODO: Implement button2_Click
		}
		void button3_Click(object sender, EventArgs e)
			{

			if (MessageBox.Show("Yakin ingin menghapus "+textBox2.Text+"?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try{
					mycommand.Connection = co;
					myadapter.SelectCommand = mycommand;
					//kode ini berfungsi untuk mengecek dan query untuk menambahkan pembeli  barang dengan 
				//perintah DELETE atau hapus
					mycommand.CommandText = "DELETE FROM data_pembeli where Nama='"+textBox1.Text+"'";
					DataSet ds= new DataSet();
					if (myadapter.Fill(ds,"data_pembeli")>0){
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
		void textBox3_TextChanged(object sender, EventArgs e)
		{
			// TODO: Implement textBox3_TextChanged
		}
		void textBox2_TextChanged(object sender, EventArgs e)
		{
			// TODO: Implement textBox2_TextChanged
		}
	}
}
