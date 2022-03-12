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
	/// Description of Register.
	/// </summary>
	public partial class Register : Form
	{
	//Proses penautan server ke dalam sistem dan database kosong yang nantinya akan diisi kedalam database Datauser
	//integrated security = true (diizinkan ) / mengizinkan sistem mengakses database di SQL SERVER
		SqlConnection co = new SqlConnection("Server = E3-SENTRY; Database = DataUser; integrated security = true");
		//kelas untuk kebutuhan penautan data
		SqlCommand mycommand = new SqlCommand();
		SqlDataAdapter myadapter = new SqlDataAdapter();
		
		public Register()
		{
			//
			
			//
			InitializeComponent();
			///fungsi untuk clear textbox jika tidak jadi menginput
			Bersihkan();
			//
			//
			//
		}
		///berguna jika
		void Bersihkan() {
		///text yang menempel di ketiga textbox ini yang bisa dibersihkan / clear
			textBox1.Text="";
			textBox2.Text="";
			textBox3.Text="";
		}
		void button1_Click(object sender, EventArgs e)
		{
		//jika textbox 1 "" alias kosong dan textbox "" kosong maka muncul
		//>messagebox.Show , memunculkan popun peringatan untuk meminta user mengisi dulu setiap kolom
			if(textBox1.Text.Trim() == "" || textBox3.Text.Trim() == "")
			{
				MessageBox.Show("Isi setiap kolom dulu ");
			}
			//apabila sudah ter isi maka...
			else
			{
				try{
				//akan dimasukkan tulisannya atau datanya kedalam database dengan perintah query INSERT kedalam tabel
				//yang bernama Tableuser ke dalam
					mycommand.Connection = co;
					myadapter.SelectCommand = mycommand;
					mycommand.CommandText = "INSERT INTO Tableuser VALUES ('"+textBox1.Text+"',	'"+textBox2.Text+"','"+textBox3.Text+"')";
					DataSet ds= new DataSet();
					if (myadapter.Fill(ds,"Tableuser")>0){
					}
					//Jika sudah sukses dalam menginsert data maka akan muncul peringatan popup berhasil
					//dan setelah itu sistem akan mengeksekusi baris selanjutnya yaitu textboxnya langsung clear tanpa tulisan jika data sudah diinsert 
					///dan berhasil
					///co = kelas atau nama panggilan koneksi server ,jadi jika server sudah menerima data masuk maka akan memutus sendiri servernya
					MessageBox.Show("Register sukses,Silahkan melanjutkan login");
						Bersihkan();
					co.Close();
				}
				//jika data gagal terhubung maka akan tampil dialog Gagal dan textnya masih stay di texbox sampai berhasil
				catch (Exception ex){
					MessageBox.Show("Register Gagal");
			}
				
			}
		}
	}
}
