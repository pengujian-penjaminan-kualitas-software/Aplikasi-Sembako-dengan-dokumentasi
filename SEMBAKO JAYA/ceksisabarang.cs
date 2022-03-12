
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SEMBAKO_JAYA
{
	/// <summary>
	/// Description of ceksisabarang.= hanya sekedar mengecek barang
	/// </summary>
	public partial class ceksisabarang : Form
	{
		public ceksisabarang()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void ceksisabarang_Load(object sender, EventArgs e)
        {
            // TODO: Baris kode ini memuat data ke dalam 'dBKasirDataSet2.Table_Barang' tabel. Anda dapat memindahkan, atau menghapus itu, seperti yang diperlukan.
            this.table_BarangTableAdapter.Fill(this.dBKasirDataSet2.Table_Barang);

        }
    }
}
