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
		private System.Windows.Forms.TextBox textBoxSrc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxDest;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNThrd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonExit;
		
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
			this.textBoxSrc = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxDest = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxNThrd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStart.Location = new System.Drawing.Point(290, 86);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 3;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
			// 
			// textBoxSrc
			// 
			this.textBoxSrc.Location = new System.Drawing.Point(119, 9);
			this.textBoxSrc.Name = "textBoxSrc";
			this.textBoxSrc.Size = new System.Drawing.Size(327, 20);
			this.textBoxSrc.TabIndex = 0;
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
			// textBoxDest
			// 
			this.textBoxDest.Location = new System.Drawing.Point(119, 35);
			this.textBoxDest.Name = "textBoxDest";
			this.textBoxDest.Size = new System.Drawing.Size(327, 20);
			this.textBoxDest.TabIndex = 1;
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
			// textBoxNThrd
			// 
			this.textBoxNThrd.Location = new System.Drawing.Point(119, 61);
			this.textBoxNThrd.Name = "textBoxNThrd";
			this.textBoxNThrd.Size = new System.Drawing.Size(327, 20);
			this.textBoxNThrd.TabIndex = 2;
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
			// buttonExit
			// 
			this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(371, 86);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 4;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExit);
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(458, 112);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNThrd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxDest);
			this.Controls.Add(this.textBoxSrc);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonStart);
			this.MaximumSize = new System.Drawing.Size(474, 151);
			this.MinimumSize = new System.Drawing.Size(474, 151);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "copy-multithread-gui";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
