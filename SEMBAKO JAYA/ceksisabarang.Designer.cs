/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 6/24/2021
 * Time: 3:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SEMBAKO_JAYA
{
	partial class ceksisabarang
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hargaJualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hargaBeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jumlahBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.satuanBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dBKasirDataSet2 = new SEMBAKO_JAYA.DBKasirDataSet2();
			this.table_BarangTableAdapter = new SEMBAKO_JAYA.DBKasirDataSet2TableAdapters.Table_BarangTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableBarangBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBKasirDataSet2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.kodeBarangDataGridViewTextBoxColumn,
			this.namaBarangDataGridViewTextBoxColumn,
			this.hargaJualDataGridViewTextBoxColumn,
			this.hargaBeliDataGridViewTextBoxColumn,
			this.jumlahBarangDataGridViewTextBoxColumn,
			this.satuanBarangDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.tableBarangBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 47);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(647, 193);
			this.dataGridView1.TabIndex = 0;
			// 
			// kodeBarangDataGridViewTextBoxColumn
			// 
			this.kodeBarangDataGridViewTextBoxColumn.DataPropertyName = "KodeBarang";
			this.kodeBarangDataGridViewTextBoxColumn.HeaderText = "KodeBarang";
			this.kodeBarangDataGridViewTextBoxColumn.Name = "kodeBarangDataGridViewTextBoxColumn";
			// 
			// namaBarangDataGridViewTextBoxColumn
			// 
			this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBarang";
			this.namaBarangDataGridViewTextBoxColumn.HeaderText = "NamaBarang";
			this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
			// 
			// hargaJualDataGridViewTextBoxColumn
			// 
			this.hargaJualDataGridViewTextBoxColumn.DataPropertyName = "HargaJual";
			this.hargaJualDataGridViewTextBoxColumn.HeaderText = "HargaJual";
			this.hargaJualDataGridViewTextBoxColumn.Name = "hargaJualDataGridViewTextBoxColumn";
			// 
			// hargaBeliDataGridViewTextBoxColumn
			// 
			this.hargaBeliDataGridViewTextBoxColumn.DataPropertyName = "HargaBeli";
			this.hargaBeliDataGridViewTextBoxColumn.HeaderText = "HargaBeli";
			this.hargaBeliDataGridViewTextBoxColumn.Name = "hargaBeliDataGridViewTextBoxColumn";
			// 
			// jumlahBarangDataGridViewTextBoxColumn
			// 
			this.jumlahBarangDataGridViewTextBoxColumn.DataPropertyName = "JumlahBarang";
			this.jumlahBarangDataGridViewTextBoxColumn.HeaderText = "JumlahBarang";
			this.jumlahBarangDataGridViewTextBoxColumn.Name = "jumlahBarangDataGridViewTextBoxColumn";
			// 
			// satuanBarangDataGridViewTextBoxColumn
			// 
			this.satuanBarangDataGridViewTextBoxColumn.DataPropertyName = "SatuanBarang";
			this.satuanBarangDataGridViewTextBoxColumn.HeaderText = "SatuanBarang";
			this.satuanBarangDataGridViewTextBoxColumn.Name = "satuanBarangDataGridViewTextBoxColumn";
			// 
			// tableBarangBindingSource
			// 
			this.tableBarangBindingSource.DataMember = "Table_Barang";
			this.tableBarangBindingSource.DataSource = this.dBKasirDataSet2;
			// 
			// dBKasirDataSet2
			// 
			this.dBKasirDataSet2.DataSetName = "DBKasirDataSet2";
			this.dBKasirDataSet2.Namespace = "http://tempuri.org/DBKasirDataSet2.xsd";
			this.dBKasirDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// table_BarangTableAdapter
			// 
			this.table_BarangTableAdapter.ClearBeforeFill = true;
			// 
			// ceksisabarang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(683, 252);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "ceksisabarang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cek Stok";
			this.Load += new System.EventHandler(this.ceksisabarang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableBarangBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBKasirDataSet2)).EndInit();
			this.ResumeLayout(false);

		}

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBKasirDataSet2 dBKasirDataSet2;
        private System.Windows.Forms.BindingSource tableBarangBindingSource;
        private DBKasirDataSet2TableAdapters.Table_BarangTableAdapter table_BarangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaJualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuanBarangDataGridViewTextBoxColumn;
    }
}
