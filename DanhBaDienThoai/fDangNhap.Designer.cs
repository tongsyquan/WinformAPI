﻿namespace DanhBaDienThoai
{
	partial class fDangNhap
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_username = new System.Windows.Forms.TextBox();
			this.tb_password = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Submit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(145, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "ĐĂNG NHẬP";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Quicksand", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(60, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên đăng nhập:";
			// 
			// tb_username
			// 
			this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_username.Location = new System.Drawing.Point(183, 156);
			this.tb_username.Name = "tb_username";
			this.tb_username.Size = new System.Drawing.Size(220, 24);
			this.tb_username.TabIndex = 2;
			this.tb_username.Text = "quants";
			// 
			// tb_password
			// 
			this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_password.Location = new System.Drawing.Point(183, 207);
			this.tb_password.Name = "tb_password";
			this.tb_password.PasswordChar = '*';
			this.tb_password.Size = new System.Drawing.Size(220, 24);
			this.tb_password.TabIndex = 4;
			this.tb_password.Text = "quants";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Quicksand", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(60, 205);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Mật khẩu:";
			// 
			// btn_Submit
			// 
			this.btn_Submit.Font = new System.Drawing.Font("Quicksand", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Submit.Location = new System.Drawing.Point(152, 269);
			this.btn_Submit.Name = "btn_Submit";
			this.btn_Submit.Size = new System.Drawing.Size(165, 39);
			this.btn_Submit.TabIndex = 5;
			this.btn_Submit.Text = "Đăng nhập";
			this.btn_Submit.UseVisualStyleBackColor = true;
			this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btn_Submit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 408);
			this.Controls.Add(this.btn_Submit);
			this.Controls.Add(this.tb_password);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_username);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_username;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_Submit;
	}
}
