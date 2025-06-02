namespace CallAPI
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
			this.dgv = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_madm = new System.Windows.Forms.TextBox();
			this.txt_tendm = new System.Windows.Forms.TextBox();
			this.txt_from = new System.Windows.Forms.TextBox();
			this.txt_to = new System.Windows.Forms.TextBox();
			this.btn_laytheodm = new System.Windows.Forms.Button();
			this.btn_laytheogia = new System.Windows.Forms.Button();
			this.btn_luu = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn__show_all = new System.Windows.Forms.Button();
			this.btn_show_all_dm = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(12, 291);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 51;
			this.dgv.RowTemplate.Height = 24;
			this.dgv.Size = new System.Drawing.Size(880, 337);
			this.dgv.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(207, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã danh mục";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(207, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tên danh mục";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(207, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Đơn giá từ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(397, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Đến";
			// 
			// txt_madm
			// 
			this.txt_madm.Location = new System.Drawing.Point(308, 23);
			this.txt_madm.Name = "txt_madm";
			this.txt_madm.Size = new System.Drawing.Size(199, 22);
			this.txt_madm.TabIndex = 5;
			// 
			// txt_tendm
			// 
			this.txt_tendm.Location = new System.Drawing.Point(308, 62);
			this.txt_tendm.Name = "txt_tendm";
			this.txt_tendm.Size = new System.Drawing.Size(199, 22);
			this.txt_tendm.TabIndex = 6;
			// 
			// txt_from
			// 
			this.txt_from.Location = new System.Drawing.Point(308, 101);
			this.txt_from.Name = "txt_from";
			this.txt_from.Size = new System.Drawing.Size(73, 22);
			this.txt_from.TabIndex = 7;
			// 
			// txt_to
			// 
			this.txt_to.Location = new System.Drawing.Point(434, 101);
			this.txt_to.Name = "txt_to";
			this.txt_to.Size = new System.Drawing.Size(73, 22);
			this.txt_to.TabIndex = 8;
			// 
			// btn_laytheodm
			// 
			this.btn_laytheodm.Location = new System.Drawing.Point(542, 18);
			this.btn_laytheodm.Name = "btn_laytheodm";
			this.btn_laytheodm.Size = new System.Drawing.Size(155, 33);
			this.btn_laytheodm.TabIndex = 9;
			this.btn_laytheodm.Text = "Lấy SP theo danh mục";
			this.btn_laytheodm.UseVisualStyleBackColor = true;
			this.btn_laytheodm.Click += new System.EventHandler(this.btn_laytheodm_Click);
			// 
			// btn_laytheogia
			// 
			this.btn_laytheogia.Location = new System.Drawing.Point(542, 57);
			this.btn_laytheogia.Name = "btn_laytheogia";
			this.btn_laytheogia.Size = new System.Drawing.Size(155, 33);
			this.btn_laytheogia.TabIndex = 10;
			this.btn_laytheogia.Text = "Lấy SP theo giá";
			this.btn_laytheogia.UseVisualStyleBackColor = true;
			this.btn_laytheogia.Click += new System.EventHandler(this.btn_laytheogia_Click);
			// 
			// btn_luu
			// 
			this.btn_luu.Location = new System.Drawing.Point(542, 96);
			this.btn_luu.Name = "btn_luu";
			this.btn_luu.Size = new System.Drawing.Size(155, 33);
			this.btn_luu.TabIndex = 11;
			this.btn_luu.Text = "Lưu danh mục";
			this.btn_luu.UseVisualStyleBackColor = true;
			this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(542, 135);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(155, 33);
			this.btn_sua.TabIndex = 12;
			this.btn_sua.Text = "Sửa danh mục";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(542, 174);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(155, 33);
			this.btn_xoa.TabIndex = 13;
			this.btn_xoa.Text = "Xóa danh mục";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn__show_all
			// 
			this.btn__show_all.Location = new System.Drawing.Point(542, 213);
			this.btn__show_all.Name = "btn__show_all";
			this.btn__show_all.Size = new System.Drawing.Size(155, 33);
			this.btn__show_all.TabIndex = 14;
			this.btn__show_all.Text = "Tất cả sản phẩm";
			this.btn__show_all.UseVisualStyleBackColor = true;
			this.btn__show_all.Click += new System.EventHandler(this.btn_show_all_Click);
			// 
			// btn_show_all_dm
			// 
			this.btn_show_all_dm.Location = new System.Drawing.Point(542, 252);
			this.btn_show_all_dm.Name = "btn_show_all_dm";
			this.btn_show_all_dm.Size = new System.Drawing.Size(155, 33);
			this.btn_show_all_dm.TabIndex = 15;
			this.btn_show_all_dm.Text = "Tất cả danh mục";
			this.btn_show_all_dm.UseVisualStyleBackColor = true;
			this.btn_show_all_dm.Click += new System.EventHandler(this.btn_show_all_dm_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 640);
			this.Controls.Add(this.btn_show_all_dm);
			this.Controls.Add(this.btn__show_all);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.btn_luu);
			this.Controls.Add(this.btn_laytheogia);
			this.Controls.Add(this.btn_laytheodm);
			this.Controls.Add(this.txt_to);
			this.Controls.Add(this.txt_from);
			this.Controls.Add(this.txt_tendm);
			this.Controls.Add(this.txt_madm);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgv);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_madm;
		private System.Windows.Forms.TextBox txt_tendm;
		private System.Windows.Forms.TextBox txt_from;
		private System.Windows.Forms.TextBox txt_to;
		private System.Windows.Forms.Button btn_laytheodm;
		private System.Windows.Forms.Button btn_laytheogia;
		private System.Windows.Forms.Button btn_luu;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn__show_all;
		private System.Windows.Forms.Button btn_show_all_dm;
	}
}

