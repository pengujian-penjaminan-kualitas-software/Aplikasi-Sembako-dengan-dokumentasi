/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 6/24/2021
 * Time: 2:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SEMBAKO_JAYA
{
	partial class Lihat_Pembeli
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Data.DataView dataView1;
		private System.Windows.Forms.Button button1;
		
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
			this.dataView1 = new System.Data.DataView();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noHpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datapembeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.databuyerDataSet = new SEMBAKO_JAYA.DatabuyerDataSet();
			this.data_pembeliTableAdapter = new SEMBAKO_JAYA.DatabuyerDataSetTableAdapters.data_pembeliTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datapembeliBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.databuyerDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(170, 308);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 33);
			this.button1.TabIndex = 14;
			this.button1.Text = "Kembali";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.namaDataGridViewTextBoxColumn,
			this.noHpDataGridViewTextBoxColumn,
			this.alamatDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.datapembeliBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 92);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(338, 150);
			this.dataGridView1.TabIndex = 15;
			// 
			// namaDataGridViewTextBoxColumn
			// 
			this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
			this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
			this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
			// 
			// noHpDataGridViewTextBoxColumn
			// 
			this.noHpDataGridViewTextBoxColumn.DataPropertyName = "NoHp";
			this.noHpDataGridViewTextBoxColumn.HeaderText = "NoHp";
			this.noHpDataGridViewTextBoxColumn.Name = "noHpDataGridViewTextBoxColumn";
			// 
			// alamatDataGridViewTextBoxColumn
			// 
			this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
			this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
			this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
			// 
			// datapembeliBindingSource
			// 
			this.datapembeliBindingSource.DataMember = "data_pembeli";
			this.datapembeliBindingSource.DataSource = this.databuyerDataSet;
			// 
			// databuyerDataSet
			// 
			this.databuyerDataSet.DataSetName = "DatabuyerDataSet";
			this.databuyerDataSet.Namespace = "http://tempuri.org/DatabuyerDataSet.xsd";
			this.databuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// data_pembeliTableAdapter
			// 
			this.data_pembeliTableAdapter.ClearBeforeFill = true;
			// 
			// Lihat_Pembeli
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(363, 343);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Lihat_Pembeli";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lihat_Pembeli";
			this.Load += new System.EventHandler(this.Lihat_Pembeli_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datapembeliBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.databuyerDataSet)).EndInit();
			this.ResumeLayout(false);

		}

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabuyerDataSet databuyerDataSet;
        private System.Windows.Forms.BindingSource datapembeliBindingSource;
        private DatabuyerDataSetTableAdapters.data_pembeliTableAdapter data_pembeliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
    }
}
