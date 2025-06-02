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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_madv = new System.Windows.Forms.TextBox();
			this.txt_tendv = new System.Windows.Forms.TextBox();
			this.btn_hienthi = new System.Windows.Forms.Button();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.dgv = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(192, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã đơn vị";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(192, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên đơn vị";
			// 
			// txt_madv
			// 
			this.txt_madv.Location = new System.Drawing.Point(293, 12);
			this.txt_madv.Name = "txt_madv";
			this.txt_madv.Size = new System.Drawing.Size(214, 22);
			this.txt_madv.TabIndex = 2;
			// 
			// txt_tendv
			// 
			this.txt_tendv.Location = new System.Drawing.Point(293, 41);
			this.txt_tendv.Name = "txt_tendv";
			this.txt_tendv.Size = new System.Drawing.Size(214, 22);
			this.txt_tendv.TabIndex = 3;
			// 
			// btn_hienthi
			// 
			this.btn_hienthi.Location = new System.Drawing.Point(529, 12);
			this.btn_hienthi.Name = "btn_hienthi";
			this.btn_hienthi.Size = new System.Drawing.Size(75, 23);
			this.btn_hienthi.TabIndex = 4;
			this.btn_hienthi.Text = "Hiển thị";
			this.btn_hienthi.UseVisualStyleBackColor = true;
			this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(529, 41);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 23);
			this.btn_them.TabIndex = 5;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(529, 70);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(75, 23);
			this.btn_sua.TabIndex = 6;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(529, 99);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(75, 23);
			this.btn_xoa.TabIndex = 7;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(12, 128);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 51;
			this.dgv.RowTemplate.Height = 24;
			this.dgv.Size = new System.Drawing.Size(776, 269);
			this.dgv.TabIndex = 8;
			this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 409);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.btn_hienthi);
			this.Controls.Add(this.txt_tendv);
			this.Controls.Add(this.txt_madv);
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
		private System.Windows.Forms.TextBox txt_madv;
		private System.Windows.Forms.TextBox txt_tendv;
		private System.Windows.Forms.Button btn_hienthi;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.DataGridView dgv;
	}
}

