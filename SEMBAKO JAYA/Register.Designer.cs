/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 6/23/2021
 * Time: 6:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SEMBAKO_JAYA
{
	partial class Register
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(83, 201);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 48);
			this.button1.TabIndex = 0;
			this.button1.Text = "Register";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(68, 38);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(212, 20);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(68, 80);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(212, 20);
			this.textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(68, 121);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(212, 20);
			this.textBox3.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(2, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Kode User :";
			// 
			// Register
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Register";
			this.Text = "Register";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
