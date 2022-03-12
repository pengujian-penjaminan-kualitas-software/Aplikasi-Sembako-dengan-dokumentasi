
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SEMBAKO_JAYA
{
	/// <summary>
	/// panel admin yang berfungsi atau digunakan untuk kebutuhan admin seperti melihat barang,dan memanajemen pegawao (kasir)
	///
	/// </summary>
	public partial class admindashboard : Form
	{
		public admindashboard()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		///buttonview yang mengarah ke form CekSisabarang.cs
		void button1_Click(object sender, EventArgs e)
		{
			ceksisabarang addmin = new ceksisabarang();
			addmin.Show();
			
		}
		///button yang terhubung ke form lihat pembeli yang digunakan untuk berpindah ke halaman Lihat_Pembeli.cs untuk memantau perkembangan pembeli
		void button3_Click(object sender, EventArgs e)
		{
			Lihat_Pembeli buyer = new Lihat_Pembeli();
			buyer.Show();
			this.Hide();
			
		}
		///button ini berguna untuk menuju ke CRUD admin jika ada orang melamar pekerjaan disini.
		void button2_Click(object sender, EventArgs e)
		{
			ManajemenAdmin manadmin = new ManajemenAdmin();
			manadmin.Show();
			this.Hide();
		}
		///form log out yang sebenarnya hanya dihubungkan ke form Loginkasir dan di close ddengan code this.Close
		//sehingga seakan terpasang fitur logout yang sesungguhnya
		void label3_Click(object sender, EventArgs e)
		{
			this.Close();
			LoginForm backtomain = new LoginForm();
			backtomain.Show();
			
		}
	}
}
