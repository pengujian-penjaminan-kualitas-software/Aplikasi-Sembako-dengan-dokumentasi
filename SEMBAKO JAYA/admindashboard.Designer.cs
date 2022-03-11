/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 6/24/2021
 * Time: 2:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SEMBAKO_JAYA
{
	partial class admindashboard
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(78, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Admin cPanel";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 217);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 53);
			this.button1.TabIndex = 1;
			this.button1.Text = "Cek Stok Barang";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(152, 217);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(129, 53);
			this.button2.TabIndex = 2;
			this.button2.Text = "Cek Pegawai";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(288, 217);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(146, 53);
			this.button3.TabIndex = 3;
			this.button3.Text = "Cek Customer";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(333, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "label2";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(295, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(184, 46);
			this.panel1.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(41, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 27);
			this.label3.TabIndex = 0;
			this.label3.Text = "Log Out";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// admindashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(491, 324);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "admindashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "admindashboard";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
