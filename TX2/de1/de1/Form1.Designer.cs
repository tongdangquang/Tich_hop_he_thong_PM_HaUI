namespace de1
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
			this.txt_hangxe = new System.Windows.Forms.TextBox();
			this.txt_dongxe = new System.Windows.Forms.TextBox();
			this.txt_phienban = new System.Windows.Forms.TextBox();
			this.txt_dongco = new System.Windows.Forms.TextBox();
			this.txt_gia = new System.Windows.Forms.TextBox();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_tim = new System.Windows.Forms.Button();
			this.dtg = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hãng xe";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Dòng xe";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Phiên bản";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(303, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Động cơ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(303, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Giá";
			// 
			// txt_hangxe
			// 
			this.txt_hangxe.Location = new System.Drawing.Point(89, 18);
			this.txt_hangxe.Name = "txt_hangxe";
			this.txt_hangxe.Size = new System.Drawing.Size(164, 22);
			this.txt_hangxe.TabIndex = 5;
			// 
			// txt_dongxe
			// 
			this.txt_dongxe.Location = new System.Drawing.Point(89, 54);
			this.txt_dongxe.Name = "txt_dongxe";
			this.txt_dongxe.Size = new System.Drawing.Size(164, 22);
			this.txt_dongxe.TabIndex = 6;
			// 
			// txt_phienban
			// 
			this.txt_phienban.Location = new System.Drawing.Point(89, 90);
			this.txt_phienban.Name = "txt_phienban";
			this.txt_phienban.Size = new System.Drawing.Size(164, 22);
			this.txt_phienban.TabIndex = 7;
			// 
			// txt_dongco
			// 
			this.txt_dongco.Location = new System.Drawing.Point(381, 18);
			this.txt_dongco.Name = "txt_dongco";
			this.txt_dongco.Size = new System.Drawing.Size(164, 22);
			this.txt_dongco.TabIndex = 8;
			// 
			// txt_gia
			// 
			this.txt_gia.Location = new System.Drawing.Point(381, 54);
			this.txt_gia.Name = "txt_gia";
			this.txt_gia.Size = new System.Drawing.Size(164, 22);
			this.txt_gia.TabIndex = 9;
			// 
			// btn_them
			// 
			this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_them.Location = new System.Drawing.Point(701, 12);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(95, 35);
			this.btn_them.TabIndex = 10;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoa.Location = new System.Drawing.Point(701, 48);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(95, 35);
			this.btn_xoa.TabIndex = 11;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_tim
			// 
			this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_tim.Location = new System.Drawing.Point(701, 84);
			this.btn_tim.Name = "btn_tim";
			this.btn_tim.Size = new System.Drawing.Size(95, 35);
			this.btn_tim.TabIndex = 12;
			this.btn_tim.Text = "Tìm";
			this.btn_tim.UseVisualStyleBackColor = true;
			this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
			// 
			// dtg
			// 
			this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg.Location = new System.Drawing.Point(12, 125);
			this.dtg.Name = "dtg";
			this.dtg.RowHeadersWidth = 51;
			this.dtg.RowTemplate.Height = 24;
			this.dtg.Size = new System.Drawing.Size(783, 219);
			this.dtg.TabIndex = 13;
			this.dtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(807, 356);
			this.Controls.Add(this.dtg);
			this.Controls.Add(this.btn_tim);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.txt_gia);
			this.Controls.Add(this.txt_dongco);
			this.Controls.Add(this.txt_phienban);
			this.Controls.Add(this.txt_dongxe);
			this.Controls.Add(this.txt_hangxe);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Bảng giá xe";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_hangxe;
		private System.Windows.Forms.TextBox txt_dongxe;
		private System.Windows.Forms.TextBox txt_phienban;
		private System.Windows.Forms.TextBox txt_dongco;
		private System.Windows.Forms.TextBox txt_gia;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_tim;
		private System.Windows.Forms.DataGridView dtg;
	}
}

