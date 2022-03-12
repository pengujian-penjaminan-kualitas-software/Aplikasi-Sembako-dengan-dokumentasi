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
	/// Description of databarang.
	/// </summary>
	public partial class databarang : Form
	{
		//class dan query untuk mengkoneksikan ke server ms DB dan diambil database bagian DB kasir dengan intregasi
		//boolean true
		SqlConnection co = new SqlConnection("Server = E3-SENTRY; Database = DBKasir; integrated security = true");
		//pembuatan class untuk koneksi
		SqlCommand mycommand = new SqlCommand();
		SqlDataAdapter myadapter = new SqlDataAdapter();
		
		public databarang()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Bersihkan();
			readdata();
			//class untuk membaca dan membersihkan textbox seusai penambahan atau pengeditan
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Bersihkan() {
			//void ini berfungsi untuk langsung membersihkan bagian textbox dengan meng set value tertentu setelah /seusai pengubahan data
			textBox1.Text="";
			textBox2.Text="";
			textBox3.Text="0";
			textBox4.Text="0";
			textBox5.Text="0";
			textBox6.Text="";
		}
		
			void readdata() {
			//void ini berfungsi sebagai membaca data pada tabel di database
			try {
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from Table_Barang";
				DataSet ds= new DataSet();
				if (myadapter.Fill(ds,"Table_Barang")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "Table_Barang";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		void button1_Click(object sender, EventArgs e)
		{
			//if ini berfungsi ketika textbox kosong maka akan muncul peringatan isi setiap kolom dulu
			if(textBox1.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" ||textBox5.Text.Trim() == "" ||textBox6.Text.Trim() == "")
			{
				MessageBox.Show("Isi setiap kolom dulu ");
			}
			else
				//kode ini berfungsi untuk mengecek dan query untuk menambahkan data barang ke tabel table  barang dengan 
				//perintah INSERT
			{
				try{
					mycommand.Connection = co;
					myadapter.SelectCommand = mycommand;
					mycommand.CommandText = "INSERT INTO TABLE_BARANG VALUES ('"+textBox1.Text+"',	'"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')";
					DataSet ds= new DataSet();
					if (myadapter.Fill(ds,"Table_Barang")>0){
						dataGridView1.DataSource = ds;
						dataGridView1.DataMember = "Table_Barang";
					}
					//messagebox atau dialog pesan untuk memberitahu bahwa data berhasil di insert
					MessageBox.Show("Data berhasil masuk");
						readdata();
						Bersihkan();
					co.Close();
				}
				//jika eror atau gagal menangkap database maka akan muncul peringatan data gagal di input
				catch (Exception ex){
					MessageBox.Show("Data Gagal di input");
			}
				
			}
		}
		//dan begitu juga pada bagian lainnya hanya saja diubah dengan perintah update dan delet 
		void button2_Click(object sender, EventArgs e)
		{
			if(textBox1.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" ||textBox5.Text.Trim() == "" ||textBox6.Text.Trim() == "")
			{
				MessageBox.Show("Isi setiap kolom dulu ");
			}
			else
			{
				try{
					mycommand.Connection = co;
					myadapter.SelectCommand = mycommand;
					mycommand.CommandText = "UPDATE  Table_Barang SET KodeBarang=' "+textBox1.Text+" ',NamaBarang=' "+textBox2.Text+" ',HargaJual='"+textBox3.Text+"',HargaBeli='"+textBox4.Text+"',JumlahBarang='"+textBox5.Text+"',SatuanBarang='"+textBox6.Text+" 'where KodeBarang'"+textBox1.Text+" ' ";
					DataSet ds= new DataSet();
					if (myadapter.Fill(ds,"Table_Barang")>0){
						dataGridView1.DataSource = ds;
						dataGridView1.DataMember = "Table_Barang";
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
		//button dengan fungsi klik untuk menjalankan perintah hapus barang
		void button3_Click(object sender, EventArgs e)
		{
		//sebelum barang terhapus maka akan ditampilkan popupbox terlebih dahulu dengan keputusan messegebox 
		//melalui DialogResult jika user mengklik Yes maka yang terjadi adalah dieksekusinya query delete tersebut.

			if (MessageBox.Show("Yakin ingin menghapus "+textBox2.Text+"?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try{
					mycommand.Connection = co;
					myadapter.SelectCommand = mycommand;
					mycommand.CommandText = "DELETE FROM TABLE_BARANG where KodeBarang='"+textBox1.Text+"'";
					DataSet ds= new DataSet();
					if (myadapter.Fill(ds,"Table_Barang")>0){
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
				//pada fungsi ini berfungsi ketika pada bagian row nya di klik maka akan muncul string atau tulisan yang
				//muncul di textbox
					DataGridViewRow row = this.dataGridView1.Rows [e.RowIndex];
					textBox1.Text = row.Cells["kodeBarang"].Value.ToString();
					textBox2.Text = row.Cells["NamaBarang"].Value.ToString();
					textBox3.Text = row.Cells["HargaJual"].Value.ToString();
					textBox4.Text = row.Cells["HargaBeli"].Value.ToString();
					textBox5.Text = row.Cells["JumlahBarang"].Value.ToString();
					textBox6.Text = row.Cells["SatuanBarang"].Value.ToString();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
		

			}
		}
		void button4_Click(object sender, EventArgs e)
		{
			//pada button ini berfungsi untuk kembali ke halaman pada menu utama kasir
			this.Hide();
			dashboard dash= new dashboard();
			dash.Show();
		}
	}
}
