﻿namespace MCL_Adminer
{
	public partial class ManageRooms : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.listBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(28, 44);
			this.listBox1.Margin = new global::System.Windows.Forms.Padding(1);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(79, 186);
			this.listBox1.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(28, 18);
			this.label1.Margin = new global::System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(66, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select room:";
			this.button1.Location = new global::System.Drawing.Point(124, 44);
			this.button1.Margin = new global::System.Windows.Forms.Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(110, 21);
			this.button1.TabIndex = 3;
			this.button1.Text = "New room";
			this.button1.UseVisualStyleBackColor = true;
			this.button2.Location = new global::System.Drawing.Point(124, 123);
			this.button2.Margin = new global::System.Windows.Forms.Padding(1);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(110, 21);
			this.button2.TabIndex = 4;
			this.button2.Text = "Edit selected room";
			this.button2.UseVisualStyleBackColor = true;
			this.button3.Location = new global::System.Drawing.Point(124, 206);
			this.button3.Margin = new global::System.Windows.Forms.Padding(1);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(110, 21);
			this.button3.TabIndex = 5;
			this.button3.Text = "Remove selected";
			this.button3.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(241, 245);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.listBox1);
			base.Margin = new global::System.Windows.Forms.Padding(1);
			base.Name = "ManageRooms";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageRooms";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		private global::System.ComponentModel.IContainer components = null;
		private global::System.Windows.Forms.ListBox listBox1;
		private global::System.Windows.Forms.Label label1;
		private global::System.Windows.Forms.Button button1;
		private global::System.Windows.Forms.Button button2;
		private global::System.Windows.Forms.Button button3;
	}
}
