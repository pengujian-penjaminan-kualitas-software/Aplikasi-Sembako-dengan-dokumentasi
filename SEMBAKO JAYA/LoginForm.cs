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
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;
		private SqlDataReader rd;
		
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
		void button1_Click(object sender, EventArgs e)
		{
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand ("Select * from Tabeluser where NamaUser='"+ textBox1.Text +"' and " +
"PasswordUser='"+ textBox2.Text + "'",conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if (rd.HasRows)
			{
				this.Hide();
				conn.Close();
				dashboard  frm3 = new dashboard();
				frm3.Show();
			}
			else
			{
				MessageBox.Show("Informasi salah");
			}

		}
		void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void label5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Admin_Panel apanel= new Admin_Panel();
			apanel.Show();
		}

	}
}
