
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SEMBAKO_JAYA
{
	/// <summary>
	/// Description of admindashboard.
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
		void button1_Click(object sender, EventArgs e)
		{
			ceksisabarang addmin = new ceksisabarang();
			addmin.Show();
			
		}
		void button3_Click(object sender, EventArgs e)
		{
			Lihat_Pembeli buyer = new Lihat_Pembeli();
			buyer.Show();
			this.Hide();
			
		}
		void button2_Click(object sender, EventArgs e)
		{
			ManajemenAdmin manadmin = new ManajemenAdmin();
			manadmin.Show();
			this.Hide();
		}
		void label3_Click(object sender, EventArgs e)
		{
			this.Close();
			LoginForm backtomain = new LoginForm();
			backtomain.Show();
			
		}
	}
}
