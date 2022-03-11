
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SEMBAKO_JAYA
{
	/// <summary>
	/// Description of dashboard.
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
			this.Hide();
			databarang dabarang = new databarang();
			dabarang.Show();
	
		}
		void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginForm signout = new LoginForm();
			signout.Show();
		}
		void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			ManajemenAdmin manajadmin = new ManajemenAdmin();
			manajadmin.Show();
		}
		void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Manajemen_Pembeli inputpemb = new Manajemen_Pembeli();
			inputpemb.Show();
		}
	}
}
