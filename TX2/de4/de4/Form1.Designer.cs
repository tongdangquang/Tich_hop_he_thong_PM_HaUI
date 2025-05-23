namespace de4
{
	partial class Form1
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_masv = new System.Windows.Forms.TextBox();
			this.txt_hoten = new System.Windows.Forms.TextBox();
			this.txt_tuoi = new System.Windows.Forms.TextBox();
			this.txt_diachi = new System.Windows.Forms.TextBox();
			this.txt_tenmon = new System.Windows.Forms.TextBox();
			this.txt_diem = new System.Windows.Forms.TextBox();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_tim = new System.Windows.Forms.Button();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.txt_to = new System.Windows.Forms.TextBox();
			this.txt_from = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã sinh viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Họ tên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tuổi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(361, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Địa chỉ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(361, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Môn học";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(361, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Điểm";
			// 
			// txt_masv
			// 
			this.txt_masv.Location = new System.Drawing.Point(110, 11);
			this.txt_masv.Name = "txt_masv";
			this.txt_masv.Size = new System.Drawing.Size(194, 22);
			this.txt_masv.TabIndex = 6;
			// 
			// txt_hoten
			// 
			this.txt_hoten.Location = new System.Drawing.Point(110, 60);
			this.txt_hoten.Name = "txt_hoten";
			this.txt_hoten.Size = new System.Drawing.Size(194, 22);
			this.txt_hoten.TabIndex = 7;
			// 
			// txt_tuoi
			// 
			this.txt_tuoi.Location = new System.Drawing.Point(110, 109);
			this.txt_tuoi.Name = "txt_tuoi";
			this.txt_tuoi.Size = new System.Drawing.Size(194, 22);
			this.txt_tuoi.TabIndex = 8;
			// 
			// txt_diachi
			// 
			this.txt_diachi.Location = new System.Drawing.Point(434, 11);
			this.txt_diachi.Name = "txt_diachi";
			this.txt_diachi.Size = new System.Drawing.Size(194, 22);
			this.txt_diachi.TabIndex = 9;
			// 
			// txt_tenmon
			// 
			this.txt_tenmon.Location = new System.Drawing.Point(434, 60);
			this.txt_tenmon.Name = "txt_tenmon";
			this.txt_tenmon.Size = new System.Drawing.Size(194, 22);
			this.txt_tenmon.TabIndex = 10;
			// 
			// txt_diem
			// 
			this.txt_diem.Location = new System.Drawing.Point(434, 109);
			this.txt_diem.Name = "txt_diem";
			this.txt_diem.Size = new System.Drawing.Size(194, 22);
			this.txt_diem.TabIndex = 11;
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(713, 6);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 33);
			this.btn_them.TabIndex = 12;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(713, 55);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(75, 33);
			this.btn_xoa.TabIndex = 13;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_tim
			// 
			this.btn_tim.Location = new System.Drawing.Point(713, 104);
			this.btn_tim.Name = "btn_tim";
			this.btn_tim.Size = new System.Drawing.Size(75, 33);
			this.btn_tim.TabIndex = 14;
			this.btn_tim.Text = "Tìm";
			this.btn_tim.UseVisualStyleBackColor = true;
			this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(15, 190);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 51;
			this.dgv.RowTemplate.Height = 24;
			this.dgv.Size = new System.Drawing.Size(773, 248);
			this.dgv.TabIndex = 15;
			this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
			// 
			// txt_to
			// 
			this.txt_to.Location = new System.Drawing.Point(434, 157);
			this.txt_to.Name = "txt_to";
			this.txt_to.Size = new System.Drawing.Size(194, 22);
			this.txt_to.TabIndex = 19;
			// 
			// txt_from
			// 
			this.txt_from.Location = new System.Drawing.Point(110, 157);
			this.txt_from.Name = "txt_from";
			this.txt_from.Size = new System.Drawing.Size(194, 22);
			this.txt_from.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(361, 160);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 16);
			this.label7.TabIndex = 17;
			this.label7.Text = "Đến";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 160);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 16);
			this.label8.TabIndex = 16;
			this.label8.Text = "Từ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txt_to);
			this.Controls.Add(this.txt_from);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.btn_tim);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.txt_diem);
			this.Controls.Add(this.txt_tenmon);
			this.Controls.Add(this.txt_diachi);
			this.Controls.Add(this.txt_tuoi);
			this.Controls.Add(this.txt_hoten);
			this.Controls.Add(this.txt_masv);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_masv;
		private System.Windows.Forms.TextBox txt_hoten;
		private System.Windows.Forms.TextBox txt_tuoi;
		private System.Windows.Forms.TextBox txt_diachi;
		private System.Windows.Forms.TextBox txt_tenmon;
		private System.Windows.Forms.TextBox txt_diem;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_tim;
		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.TextBox txt_to;
		private System.Windows.Forms.TextBox txt_from;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}

