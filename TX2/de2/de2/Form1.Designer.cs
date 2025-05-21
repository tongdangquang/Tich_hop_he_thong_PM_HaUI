namespace de2
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
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_tim = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_ngay = new System.Windows.Forms.TextBox();
			this.txt_ma = new System.Windows.Forms.TextBox();
			this.txt_kieutt = new System.Windows.Forms.TextBox();
			this.txt_ndmax = new System.Windows.Forms.TextBox();
			this.txt_ndmin = new System.Windows.Forms.TextBox();
			this.dgv = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_them
			// 
			this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_them.Location = new System.Drawing.Point(799, 6);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 38);
			this.btn_them.TabIndex = 0;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoa.Location = new System.Drawing.Point(799, 53);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(75, 38);
			this.btn_xoa.TabIndex = 1;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_tim
			// 
			this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_tim.Location = new System.Drawing.Point(799, 100);
			this.btn_tim.Name = "btn_tim";
			this.btn_tim.Size = new System.Drawing.Size(75, 38);
			this.btn_tim.TabIndex = 2;
			this.btn_tim.Text = "Tìm";
			this.btn_tim.UseVisualStyleBackColor = true;
			this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Ngày";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mã khu vực";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Kiểu thời tiết";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(383, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Nhiệt độ cao nhất";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(383, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(145, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Nhiệt độ thấp nhất";
			// 
			// txt_ngay
			// 
			this.txt_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_ngay.Location = new System.Drawing.Point(133, 12);
			this.txt_ngay.Name = "txt_ngay";
			this.txt_ngay.Size = new System.Drawing.Size(180, 27);
			this.txt_ngay.TabIndex = 7;
			// 
			// txt_ma
			// 
			this.txt_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_ma.Location = new System.Drawing.Point(134, 59);
			this.txt_ma.Name = "txt_ma";
			this.txt_ma.Size = new System.Drawing.Size(180, 27);
			this.txt_ma.TabIndex = 8;
			this.txt_ma.TextChanged += new System.EventHandler(this.Form1_Load);
			// 
			// txt_kieutt
			// 
			this.txt_kieutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_kieutt.Location = new System.Drawing.Point(134, 106);
			this.txt_kieutt.Name = "txt_kieutt";
			this.txt_kieutt.Size = new System.Drawing.Size(180, 27);
			this.txt_kieutt.TabIndex = 9;
			// 
			// txt_ndmax
			// 
			this.txt_ndmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_ndmax.Location = new System.Drawing.Point(555, 12);
			this.txt_ndmax.Name = "txt_ndmax";
			this.txt_ndmax.Size = new System.Drawing.Size(180, 27);
			this.txt_ndmax.TabIndex = 10;
			// 
			// txt_ndmin
			// 
			this.txt_ndmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_ndmin.Location = new System.Drawing.Point(555, 59);
			this.txt_ndmin.Name = "txt_ndmin";
			this.txt_ndmin.Size = new System.Drawing.Size(180, 27);
			this.txt_ndmin.TabIndex = 11;
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(16, 164);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 51;
			this.dgv.RowTemplate.Height = 24;
			this.dgv.Size = new System.Drawing.Size(858, 289);
			this.dgv.TabIndex = 12;
			this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 465);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.txt_ndmin);
			this.Controls.Add(this.txt_ndmax);
			this.Controls.Add(this.txt_kieutt);
			this.Controls.Add(this.txt_ma);
			this.Controls.Add(this.txt_ngay);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_tim);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_them);
			this.Name = "Form1";
			this.Text = "Dự báo thời tiết";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_tim;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_ngay;
		private System.Windows.Forms.TextBox txt_ma;
		private System.Windows.Forms.TextBox txt_kieutt;
		private System.Windows.Forms.TextBox txt_ndmax;
		private System.Windows.Forms.TextBox txt_ndmin;
		private System.Windows.Forms.DataGridView dgv;
	}
}

