
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SEMBAKO_JAYA
{
	/// <summary>
	/// Description of ceksisabarang.
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
            // TODO: This line of code loads data into the 'dBKasirDataSet2.Table_Barang' table. You can move, or remove it, as needed.
            this.table_BarangTableAdapter.Fill(this.dBKasirDataSet2.Table_Barang);

        }
    }
}
