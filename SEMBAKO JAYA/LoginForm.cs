using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SEMBAKO_JAYA
{
	public partial class LoginForm : Form
	///CLASS SQL
	{
		///Mewakili pernyataan Transact-SQL atau prosedur tersimpan untuk dijalankan terhadap database SQL Server. 
		///cmd = class atau julukan untuk pemanggilan fungsi code untuk di eksekusi
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;
		private SqlDataReader rd;
		///pembuatan class koneksi untuk memanggil  koneksi.cs 
		Koneksi Konn = new Koneksi();
		public LoginForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		///fungsi klik tombol untuk mengirim sebuah objek dan melakukan event
		void button1_Click(object sender, EventArgs e)
		{
		///jika button diklik maka sistem akan mengeksekusi kode berikut
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand ("Select * from Tabeluser where NamaUser='"+ textBox1.Text +"' and " +
"PasswordUser='"+ textBox2.Text + "'",conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if (rd.HasRows)
			{
			///jika data berhasil cocok dengan yang berada didalam sql maka akan diproses kedalam dashboard.cs
				this.Hide();
				conn.Close();
				dashboard  frm3 = new dashboard();
				frm3.Show();
			}
			else
			{
			///untuk menampilkan perigatan jika sistem tidak menemukan atau mencocokkan data yang diinput oleh user
				MessageBox.Show("Informasi salah");
			}

		}
		//button2_Click untuk keluar
		void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		///label yang mengarah kembali ke dashboard admin
		void label5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Admin_Panel apanel= new Admin_Panel();
			apanel.Show();
		}

	}
}
