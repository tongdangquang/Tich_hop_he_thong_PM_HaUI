namespace de3
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
			this.label = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_ngay = new System.Windows.Forms.TextBox();
			this.txt_manv = new System.Windows.Forms.TextBox();
			this.txt_loai = new System.Windows.Forms.TextBox();
			this.txt_sogio = new System.Windows.Forms.TextBox();
			this.txt_trangthai = new System.Windows.Forms.TextBox();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_tim = new System.Windows.Forms.Button();
			this.dgv = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ngày làm việc";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã nhân viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Loại làm thêm";
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(370, 15);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(46, 16);
			this.label.TabIndex = 3;
			this.label.Text = "Số giờ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(370, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Trạng thái";
			// 
			// txt_ngay
			// 
			this.txt_ngay.Location = new System.Drawing.Point(150, 12);
			this.txt_ngay.Name = "txt_ngay";
			this.txt_ngay.Size = new System.Drawing.Size(169, 22);
			this.txt_ngay.TabIndex = 5;
			// 
			// txt_manv
			// 
			this.txt_manv.Location = new System.Drawing.Point(150, 50);
			this.txt_manv.Name = "txt_manv";
			this.txt_manv.Size = new System.Drawing.Size(169, 22);
			this.txt_manv.TabIndex = 6;
			// 
			// txt_loai
			// 
			this.txt_loai.Location = new System.Drawing.Point(150, 88);
			this.txt_loai.Name = "txt_loai";
			this.txt_loai.Size = new System.Drawing.Size(169, 22);
			this.txt_loai.TabIndex = 7;
			// 
			// txt_sogio
			// 
			this.txt_sogio.Location = new System.Drawing.Point(446, 12);
			this.txt_sogio.Name = "txt_sogio";
			this.txt_sogio.Size = new System.Drawing.Size(169, 22);
			this.txt_sogio.TabIndex = 8;
			// 
			// txt_trangthai
			// 
			this.txt_trangthai.Location = new System.Drawing.Point(446, 50);
			this.txt_trangthai.Name = "txt_trangthai";
			this.txt_trangthai.Size = new System.Drawing.Size(169, 22);
			this.txt_trangthai.TabIndex = 9;
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(713, 9);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 29);
			this.btn_them.TabIndex = 10;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(713, 47);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(75, 29);
			this.btn_xoa.TabIndex = 11;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_tim
			// 
			this.btn_tim.Location = new System.Drawing.Point(713, 85);
			this.btn_tim.Name = "btn_tim";
			this.btn_tim.Size = new System.Drawing.Size(75, 29);
			this.btn_tim.TabIndex = 12;
			this.btn_tim.Text = "Tìm";
			this.btn_tim.UseVisualStyleBackColor = true;
			this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(15, 128);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 51;
			this.dgv.RowTemplate.Height = 24;
			this.dgv.Size = new System.Drawing.Size(773, 310);
			this.dgv.TabIndex = 13;
			this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.btn_tim);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.txt_trangthai);
			this.Controls.Add(this.txt_sogio);
			this.Controls.Add(this.txt_loai);
			this.Controls.Add(this.txt_manv);
			this.Controls.Add(this.txt_ngay);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Chấm công";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_ngay;
		private System.Windows.Forms.TextBox txt_manv;
		private System.Windows.Forms.TextBox txt_loai;
		private System.Windows.Forms.TextBox txt_sogio;
		private System.Windows.Forms.TextBox txt_trangthai;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_tim;
		private System.Windows.Forms.DataGridView dgv;
	}
}

