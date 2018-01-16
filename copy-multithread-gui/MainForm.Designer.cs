/*
 * Created by SharpDevelop.
 * User: Meysam
 * Date: 1/16/2018
 * Time: 08:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace copy_multithread_gui
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		
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
			this.buttonStart = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(371, 234);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 3;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(119, 9);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(327, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Source File";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(119, 35);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(327, 20);
			this.textBox2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Destination File";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(12, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(434, 142);
			this.label3.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(119, 61);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(327, 20);
			this.textBox3.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Number of Threads";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 260);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonStart);
			this.MaximumSize = new System.Drawing.Size(474, 299);
			this.MinimumSize = new System.Drawing.Size(474, 299);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "copy-multithread-gui";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
