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
	/// Description of Lihat_Pembeli. = form yang hanya berguna untuk melihat pemantauan perkembangan pembeli
	/// </summary>
	public partial class Lihat_Pembeli : Form
	{
	///query untuk pengambilan data untuk di tampilkan
		SqlConnection co = new SqlConnection("Server = E3-SENTRY; Database = AnggotaBaru; integrated security = true");
		SqlCommand mycommand = new SqlCommand();
		SqlDataAdapter myadapter = new SqlDataAdapter();
		
		public Lihat_Pembeli()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//fungsi yang hanya bisa baca data saja 
		void readdata() {
			
			try {
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from DATABUYER";
				DataSet ds= new DataSet();
				if (myadapter.Fill(ds,"DATABUYER")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "DATABUYER";
				}
				//penutupan koneksi
				co.Close();
			}
			//ketika data tertangkap maka akan ditampilkan kedalam textbox dalam bentuk string 
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		///fungsi ketika datagridview diklik maka tulisan yang sebaris akan ditampilkan juga kedalam textbox dalam bentuk string
		
		void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
					DataGridViewRow row = this.dataGridView1.Rows [e.RowIndex];
					
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
		

			}
		}
		////fungsi tombol untuk kembali ke dashboard admin
		void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			admindashboard backtomain = new admindashboard();
			backtomain.Show();
		}

        private void Lihat_Pembeli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databuyerDataSet.data_pembeli' table. You can move, or remove it, as needed.
            this.data_pembeliTableAdapter.Fill(this.databuyerDataSet.data_pembeli);

        }
    }
}
