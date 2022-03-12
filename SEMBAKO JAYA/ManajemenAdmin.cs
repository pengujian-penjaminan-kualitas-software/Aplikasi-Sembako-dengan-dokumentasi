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
	//penautan server melalui kode dan pengquery an
	///co = class atau julukan dari fungsi SqlConnection yang berguna menghubungkan server kemudian database
	///integrated security = yaitu permohonan ijin ke server jika true = boleh . diizinkan untuk meng crud database tersebut.
		SqlConnection co = new SqlConnection("Server = E3-SENTRY; Database = DataUser; integrated security = true");
		SqlCommand mycommand = new SqlCommand();
		SqlDataAdapter myadapter = new SqlDataAdapter();
		
		public ManajemenAdmin()
		{
			//The InitializeComponent() call is required for Windows Forms designer support.
			//Bersihkan(); fungsi untuk membersihkan tiap kolom nantinya
			//readdata = membaca data yang sudah kita insert-kan ke database
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
		///fungsi membaca data .yaitu agar membuat aplikasi ini melihat database yang ada didalam tabeluser 
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
		//button untuk operasi penambahan kasir
		//if texbox 1 2 3 dan 4 kosong maka akan ditampilkan dialog pesan isi setiap kolom dulu
		
		void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "")
			{
				MessageBox.Show("Isi setiap kolom dulu ");
			}
			//dan jika terisi dengan teks maka akan mengeksekusi kueri tersebut untuk ditempatkan di field
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
		//if texbox 1 2 3 dan 4 kosong maka akan ditampilkan dialog pesan isi setiap kolom dulu
		
		
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
		//code dan query untuk menghapus data dalam tabel
		void button3_Click(object sender, EventArgs e)
		{
		//ketika button di klik maka data tidak akan terhapus ,sehingga akan melewati tahap sesuai baris kode dengan
		//DialogResult ketika si user admin meng klik Yes maka sama dengan = true atau mengizinkan untuk pindah exsekusi kode di baris selanjutnya yaitu dengan menjalankan kueri DELETE FROM TABEL yang bersangkutan
		//Bersihkan : ketika data sudah terhapus maka sebelum nya kita harus klik cellsnya kemudian tampil di texfield dalam bentuk string dan nanti ketika sudah muncul notif hapus data berhasil maka akan otomatis di clear 
		///dari textfield

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
		//fungsi cell content click maka ketika cellnya diklik akan ditampilkan ke texbox sesuai perintah
		void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
					DataGridViewRow row = this.dataGridView1.Rows [e.RowIndex];
					//isi cell kodeuser akan ditampilkan kedalam texbox no 1 yang paling atas.dst
					textBox1.Text = row.Cells["KodeUser"].Value.ToString();
					textBox2.Text = row.Cells["NamaUser"].Value.ToString();
					textBox3.Text = row.Cells["PasswordUser"].Value.ToString();
					textBox4.Text = row.Cells["LevelUser"].Value.ToString();
					
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
		

			}
		}
		//button kembali ke dashboard
		void button4_Click(object sender, EventArgs e)
		{
			admindashboard dash= new admindashboard();
			dash.Show();
			this.Hide();
		}
	}
}
