/*
 * Created by SharpDevelop.
 * User: Radiation
 * Date: 2016/10/13
 * Time: 18:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AnsiToUnicode
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button button2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "被编码的字符:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 43);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(242, 21);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 14);
			this.label2.TabIndex = 2;
			this.label2.Text = "解码结果:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(13, 99);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(242, 21);
			this.textBox2.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(37, 134);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "解码";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(19, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "By Radiation  Blog:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(138, 169);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(123, 23);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "http://b.zlweb.cc";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(138, 134);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "关于";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 190);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(290, 228);
			this.MinimumSize = new System.Drawing.Size(290, 228);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AnsiToUnicode";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
