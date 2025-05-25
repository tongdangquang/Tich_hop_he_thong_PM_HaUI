namespace de5
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
			this.txt_mabai = new System.Windows.Forms.TextBox();
			this.txt_theloai = new System.Windows.Forms.TextBox();
			this.txt_tenbai = new System.Windows.Forms.TextBox();
			this.txt_casi = new System.Windows.Forms.TextBox();
			this.txt_tacgia = new System.Windows.Forms.TextBox();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.dgv = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã bài hát";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Thể loại";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên bài hát";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(359, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ca sĩ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(359, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Tác giả";
			// 
			// txt_mabai
			// 
			this.txt_mabai.Location = new System.Drawing.Point(106, 16);
			this.txt_mabai.Name = "txt_mabai";
			this.txt_mabai.Size = new System.Drawing.Size(188, 22);
			this.txt_mabai.TabIndex = 5;
			// 
			// txt_theloai
			// 
			this.txt_theloai.Location = new System.Drawing.Point(106, 57);
			this.txt_theloai.Name = "txt_theloai";
			this.txt_theloai.Size = new System.Drawing.Size(188, 22);
			this.txt_theloai.TabIndex = 6;
			// 
			// txt_tenbai
			// 
			this.txt_tenbai.Location = new System.Drawing.Point(106, 98);
			this.txt_tenbai.Name = "txt_tenbai";
			this.txt_tenbai.Size = new System.Drawing.Size(188, 22);
			this.txt_tenbai.TabIndex = 7;
			// 
			// txt_casi
			// 
			this.txt_casi.Location = new System.Drawing.Point(431, 16);
			this.txt_casi.Name = "txt_casi";
			this.txt_casi.Size = new System.Drawing.Size(188, 22);
			this.txt_casi.TabIndex = 8;
			// 
			// txt_tacgia
			// 
			this.txt_tacgia.Location = new System.Drawing.Point(431, 57);
			this.txt_tacgia.Name = "txt_tacgia";
			this.txt_tacgia.Size = new System.Drawing.Size(188, 22);
			this.txt_tacgia.TabIndex = 9;
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(713, 12);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 30);
			this.btn_them.TabIndex = 10;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(713, 53);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(75, 30);
			this.btn_xoa.TabIndex = 11;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(713, 94);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(75, 30);
			this.btn_sua.TabIndex = 12;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(15, 143);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 51;
			this.dgv.RowTemplate.Height = 24;
			this.dgv.Size = new System.Drawing.Size(773, 295);
			this.dgv.TabIndex = 13;
			this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.txt_tacgia);
			this.Controls.Add(this.txt_casi);
			this.Controls.Add(this.txt_tenbai);
			this.Controls.Add(this.txt_theloai);
			this.Controls.Add(this.txt_mabai);
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
		private System.Windows.Forms.TextBox txt_mabai;
		private System.Windows.Forms.TextBox txt_theloai;
		private System.Windows.Forms.TextBox txt_tenbai;
		private System.Windows.Forms.TextBox txt_casi;
		private System.Windows.Forms.TextBox txt_tacgia;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.DataGridView dgv;
	}
}

