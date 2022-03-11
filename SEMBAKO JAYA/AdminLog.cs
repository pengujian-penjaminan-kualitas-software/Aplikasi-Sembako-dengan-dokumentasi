using System.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace SEMBAKO_JAYA
{
	/// <summary>
	/// Description of Admin_Panel.
	/// </summary>
	public partial class Admin_Panel : Form
	{
	///Proses penautan datasource atau sumber data untuk diambil sistem untuk dilakukan pencocokan
		SqlConnection konecsi = new SqlConnection(@"Data Source=E3-SENTRY;initial Catalog=DBAdmin;integrated Security=True");
		public Admin_Panel()
			//class koneksi untuk mengkoneksikan db yang telah dibuat :)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//kemudian dibawah ini ada button untuk masuk ke dashboard
		void button1_Click(object sender, EventArgs e)
			//terdapat pengulangan if else yang digunakan untuk menentukan jika data yang diambil dari database cocok maka akan diarahkan ke admin 
			//dashboard
		{
			konecsi.Close();
			///if = jika , ketika texbox1 dan texbox 2 kosong maka akan menampilkan MessageBox
			//Messagebox.Show *(tampilkan popup pesan yang akan meminta user untuk mengisikannya
			if(textBox1.Text == ""|| textBox2.Text == "")
			{
				MessageBox.Show("Masukan nama atau kata sandi");
			}
			///lain jika user sudah memasukkan sebuah text maka sistem akan mencarikan data yang cocok sesuai yang di tulis dan di klik berada didalam database
			else
			{
			//Query untuk mengambil data dari class Koneksi.cs , yang akan ditempatkan di field perintah oleh query
				SqlDataAdapter dadapt = new SqlDataAdapter("Select ADMID,ADMPASS from TABELADMIN where ADMID = '" + textBox1.Text +"'AND ADMPASS = '"+textBox2.Text+"'", konecsi);
				DataTable dt =new DataTable();
				dadapt.Fill(dt);
				if(dt.Rows.Count > 0)
                {
					foreach(DataRow drow in dt.Rows)
					{
					///jika data cocok maka sistem akan mengeksekusi kode selanjutnyha yaitu menutup halaman login.cs dan di proses masuk ke halaman selanjutnya
					///this.Close(); untuk menutup halaman AdminLog.cs kemudian dilanjutkan ke form admindashboard.cs
					///thedash adalah julukan /class  admindashboard untuk mempersingkat kalimat yang nanti akan dipanggil oleh script untuk ditampilkan
						this.Close();
						admindashboard thedash = new admindashboard();
						thedash.Show();
					}
                		}
			}
		}
		void button2_Click(object sender, EventArgs e)
		{
			//digunakan untuk keluar aplikasi jika batal login
			Application.Exit();
		}
		void label5_Click(object sender, EventArgs e)
		{ 
			//pada label ini terdapat label dan ketika label di klik akan berpindah ke login khusus karyawan
			this.Hide();
			LoginForm logutama = new LoginForm();
			logutama.Show();
		}
	}
}
