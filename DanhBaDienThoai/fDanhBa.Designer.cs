namespace DanhBaDienThoai
{
	partial class fDanhBa
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_new = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.btn_right = new System.Windows.Forms.Button();
			this.btn_left = new System.Windows.Forms.Button();
			this.dt_birthday = new System.Windows.Forms.DateTimePicker();
			this.tb_address = new System.Windows.Forms.TextBox();
			this.tb_email = new System.Windows.Forms.TextBox();
			this.tb_phone = new System.Windows.Forms.TextBox();
			this.tb_nickname = new System.Windows.Forms.TextBox();
			this.tb_fullname = new System.Windows.Forms.TextBox();
			this.tb_ID = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgv_list = new System.Windows.Forms.DataGridView();
			this.btn_searchBD = new System.Windows.Forms.Button();
			this.btn_searchHoTen = new System.Windows.Forms.Button();
			this.btn_searchID = new System.Windows.Forms.Button();
			this.tb_searchNickname = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tb_searchID = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tb_searchFullname = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(1203, 568);
			this.splitContainer1.SplitterDistance = 435;
			this.splitContainer1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_delete);
			this.groupBox1.Controls.Add(this.btn_new);
			this.groupBox1.Controls.Add(this.btn_save);
			this.groupBox1.Controls.Add(this.btn_right);
			this.groupBox1.Controls.Add(this.btn_left);
			this.groupBox1.Controls.Add(this.dt_birthday);
			this.groupBox1.Controls.Add(this.tb_address);
			this.groupBox1.Controls.Add(this.tb_email);
			this.groupBox1.Controls.Add(this.tb_phone);
			this.groupBox1.Controls.Add(this.tb_nickname);
			this.groupBox1.Controls.Add(this.tb_fullname);
			this.groupBox1.Controls.Add(this.tb_ID);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(435, 568);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin cá nhân";
			// 
			// btn_delete
			// 
			this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_delete.Location = new System.Drawing.Point(331, 462);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 35);
			this.btn_delete.TabIndex = 11;
			this.btn_delete.Text = "Xoá";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_new
			// 
			this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_new.Location = new System.Drawing.Point(188, 462);
			this.btn_new.Name = "btn_new";
			this.btn_new.Size = new System.Drawing.Size(80, 35);
			this.btn_new.TabIndex = 10;
			this.btn_new.Text = "Tạo mới";
			this.btn_new.UseVisualStyleBackColor = true;
			this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
			// 
			// btn_save
			// 
			this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_save.Location = new System.Drawing.Point(42, 462);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 35);
			this.btn_save.TabIndex = 9;
			this.btn_save.Text = "Lưu";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_right
			// 
			this.btn_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_right.Location = new System.Drawing.Point(223, 384);
			this.btn_right.Name = "btn_right";
			this.btn_right.Size = new System.Drawing.Size(53, 35);
			this.btn_right.TabIndex = 8;
			this.btn_right.Text = ">";
			this.btn_right.UseVisualStyleBackColor = true;
			this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
			// 
			// btn_left
			// 
			this.btn_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_left.Location = new System.Drawing.Point(164, 384);
			this.btn_left.Name = "btn_left";
			this.btn_left.Size = new System.Drawing.Size(53, 35);
			this.btn_left.TabIndex = 7;
			this.btn_left.Text = "<";
			this.btn_left.UseVisualStyleBackColor = true;
			this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
			// 
			// dt_birthday
			// 
			this.dt_birthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dt_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt_birthday.Location = new System.Drawing.Point(164, 163);
			this.dt_birthday.Name = "dt_birthday";
			this.dt_birthday.Size = new System.Drawing.Size(257, 24);
			this.dt_birthday.TabIndex = 3;
			this.dt_birthday.Value = new System.DateTime(2020, 5, 7, 15, 12, 35, 0);
			// 
			// tb_address
			// 
			this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_address.Location = new System.Drawing.Point(164, 291);
			this.tb_address.Multiline = true;
			this.tb_address.Name = "tb_address";
			this.tb_address.Size = new System.Drawing.Size(257, 57);
			this.tb_address.TabIndex = 6;
			// 
			// tb_email
			// 
			this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_email.Location = new System.Drawing.Point(164, 252);
			this.tb_email.Name = "tb_email";
			this.tb_email.Size = new System.Drawing.Size(257, 21);
			this.tb_email.TabIndex = 5;
			// 
			// tb_phone
			// 
			this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_phone.Location = new System.Drawing.Point(164, 209);
			this.tb_phone.Name = "tb_phone";
			this.tb_phone.Size = new System.Drawing.Size(257, 21);
			this.tb_phone.TabIndex = 4;
			// 
			// tb_nickname
			// 
			this.tb_nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_nickname.Location = new System.Drawing.Point(164, 122);
			this.tb_nickname.Name = "tb_nickname";
			this.tb_nickname.Size = new System.Drawing.Size(257, 21);
			this.tb_nickname.TabIndex = 2;
			// 
			// tb_fullname
			// 
			this.tb_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_fullname.Location = new System.Drawing.Point(164, 80);
			this.tb_fullname.Name = "tb_fullname";
			this.tb_fullname.Size = new System.Drawing.Size(257, 21);
			this.tb_fullname.TabIndex = 1;
			// 
			// tb_ID
			// 
			this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_ID.Location = new System.Drawing.Point(164, 38);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.ReadOnly = true;
			this.tb_ID.Size = new System.Drawing.Size(100, 21);
			this.tb_ID.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(38, 294);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 18);
			this.label7.TabIndex = 6;
			this.label7.Text = "Địa chỉ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(38, 252);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "Email";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(38, 209);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Số điện thoại";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(38, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ngày sinh";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Biệt danh";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Họ tên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgv_list);
			this.groupBox2.Controls.Add(this.btn_searchBD);
			this.groupBox2.Controls.Add(this.btn_searchHoTen);
			this.groupBox2.Controls.Add(this.btn_searchID);
			this.groupBox2.Controls.Add(this.tb_searchNickname);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.tb_searchID);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.tb_searchFullname);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(764, 568);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tìm kiếm";
			// 
			// dgv_list
			// 
			this.dgv_list.AllowUserToAddRows = false;
			this.dgv_list.AllowUserToDeleteRows = false;
			this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_list.Location = new System.Drawing.Point(6, 163);
			this.dgv_list.MultiSelect = false;
			this.dgv_list.Name = "dgv_list";
			this.dgv_list.ReadOnly = true;
			this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_list.Size = new System.Drawing.Size(758, 399);
			this.dgv_list.TabIndex = 23;
			// 
			// btn_searchBD
			// 
			this.btn_searchBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_searchBD.Location = new System.Drawing.Point(430, 113);
			this.btn_searchBD.Name = "btn_searchBD";
			this.btn_searchBD.Size = new System.Drawing.Size(131, 30);
			this.btn_searchBD.TabIndex = 16;
			this.btn_searchBD.Text = "Tìm kiếm";
			this.btn_searchBD.UseVisualStyleBackColor = true;
			this.btn_searchBD.Click += new System.EventHandler(this.btn_searchBD_Click);
			// 
			// btn_searchHoTen
			// 
			this.btn_searchHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_searchHoTen.Location = new System.Drawing.Point(430, 71);
			this.btn_searchHoTen.Name = "btn_searchHoTen";
			this.btn_searchHoTen.Size = new System.Drawing.Size(131, 30);
			this.btn_searchHoTen.TabIndex = 16;
			this.btn_searchHoTen.Text = "Tìm kiếm";
			this.btn_searchHoTen.UseVisualStyleBackColor = true;
			this.btn_searchHoTen.Click += new System.EventHandler(this.btn_searchHoTen_Click);
			// 
			// btn_searchID
			// 
			this.btn_searchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_searchID.Location = new System.Drawing.Point(293, 36);
			this.btn_searchID.Name = "btn_searchID";
			this.btn_searchID.Size = new System.Drawing.Size(131, 30);
			this.btn_searchID.TabIndex = 16;
			this.btn_searchID.Text = "Tìm kiếm";
			this.btn_searchID.UseVisualStyleBackColor = true;
			this.btn_searchID.Click += new System.EventHandler(this.btn_searchID_Click);
			// 
			// tb_searchNickname
			// 
			this.tb_searchNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_searchNickname.Location = new System.Drawing.Point(167, 121);
			this.tb_searchNickname.Name = "tb_searchNickname";
			this.tb_searchNickname.Size = new System.Drawing.Size(257, 21);
			this.tb_searchNickname.TabIndex = 15;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(41, 122);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(69, 18);
			this.label10.TabIndex = 21;
			this.label10.Text = "Biệt danh";
			// 
			// tb_searchID
			// 
			this.tb_searchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_searchID.Location = new System.Drawing.Point(167, 41);
			this.tb_searchID.Name = "tb_searchID";
			this.tb_searchID.Size = new System.Drawing.Size(115, 21);
			this.tb_searchID.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(41, 37);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(22, 18);
			this.label9.TabIndex = 21;
			this.label9.Text = "ID";
			// 
			// tb_searchFullname
			// 
			this.tb_searchFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_searchFullname.Location = new System.Drawing.Point(167, 79);
			this.tb_searchFullname.Name = "tb_searchFullname";
			this.tb_searchFullname.Size = new System.Drawing.Size(257, 21);
			this.tb_searchFullname.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(41, 79);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 18);
			this.label8.TabIndex = 21;
			this.label8.Text = "Họ tên";
			// 
			// fDanhBa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1203, 568);
			this.Controls.Add(this.splitContainer1);
			this.Name = "fDanhBa";
			this.Text = "Danh bạ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhBa_FormClosing);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn_left;
		private System.Windows.Forms.DateTimePicker dt_birthday;
		private System.Windows.Forms.TextBox tb_address;
		private System.Windows.Forms.TextBox tb_email;
		private System.Windows.Forms.TextBox tb_phone;
		private System.Windows.Forms.TextBox tb_nickname;
		private System.Windows.Forms.TextBox tb_fullname;
		private System.Windows.Forms.TextBox tb_ID;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_new;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_right;
		private System.Windows.Forms.DataGridView dgv_list;
		private System.Windows.Forms.Button btn_searchID;
		private System.Windows.Forms.TextBox tb_searchNickname;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tb_searchID;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tb_searchFullname;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btn_searchBD;
		private System.Windows.Forms.Button btn_searchHoTen;
	}
}