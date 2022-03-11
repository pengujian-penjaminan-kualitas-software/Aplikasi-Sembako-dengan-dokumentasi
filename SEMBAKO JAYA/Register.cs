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
		SqlConnection co = new SqlConnection("Server = E3-SENTRY; Database = DataUser; integrated security = true");
		SqlCommand mycommand = new SqlCommand();
		SqlDataAdapter myadapter = new SqlDataAdapter();
		
		public Register()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Bersihkan();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Bersihkan() {
			textBox1.Text="";
			textBox2.Text="";
			textBox3.Text="";
		}
		void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text.Trim() == "" || textBox3.Text.Trim() == "")
			{
				MessageBox.Show("Isi setiap kolom dulu ");
			}
			else
			{
				try{
					mycommand.Connection = co;
					myadapter.SelectCommand = mycommand;
					mycommand.CommandText = "INSERT INTO Tableuser VALUES ('"+textBox1.Text+"',	'"+textBox2.Text+"','"+textBox3.Text+"')";
					DataSet ds= new DataSet();
					if (myadapter.Fill(ds,"Tableuser")>0){
					}
					MessageBox.Show("Register sukses,Silahkan melanjutkan login");
						Bersihkan();
					co.Close();
				}
				catch (Exception ex){
					MessageBox.Show("Register Gagal");
			}
				
			}
		}
	}
}
