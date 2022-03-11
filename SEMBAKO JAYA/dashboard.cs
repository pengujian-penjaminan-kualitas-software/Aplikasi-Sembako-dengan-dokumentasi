
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SEMBAKO_JAYA
{
	/// <summary>
	/// Halaman utama kasir ketuka sesudah melakukan Login
	/// </summary>
	public partial class dashboard : Form
	{
		public dashboard()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void button1_Click(object sender, EventArgs e)
		{
		///codingan untuk menyembunyikan halaman dashboard.cs
			this.Hide();
			///Class dabarang berguna untuk pemanggilan form Databarang.cs
			databarang dabarang = new databarang();
			//menampilkan halaman databarang.cs 
			dabarang.Show();
	
		}
		///button untuk sign out
		void button4_Click(object sender, EventArgs e)
		{
		///codingan untuk menyembunyikan halaman dashboard.cs
			this.Hide();
			///Class signout berguna untuk pemanggilan form LoginForm.cs 
			LoginForm signout = new LoginForm();
			//menampilkan halaman Login.cs 
			signout.Show();
		}
		void button3_Click(object sender, EventArgs e)
		{
		///codingan untuk menyembunyikan halaman dashboard.cs
			this.Hide();
			///Class manajadmin berguna untuk pemanggilan form ManajemenAdmin.cs 
			ManajemenAdmin manajadmin = new ManajemenAdmin();
			//menampilkan halaman ManajemenAdmincs 
			manajadmin.Show();
		}
		void button2_Click(object sender, EventArgs e)
		{
		///codingan untuk menyembunyikan halaman dashboard.cs
			this.Hide();
			///Class inputpemb berguna untuk pemanggilan form Manajemen_Pembeli.cs 
			Manajemen_Pembeli inputpemb = new Manajemen_Pembeli();
			//menampilkan halaman Manajemen_Pembeli.cs 
			inputpemb.Show();
		}
	}
}
