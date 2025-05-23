using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace de4
{
	public partial class Form1 : Form
	{
		DataUtil data = new DataUtil();

		public Form1()
		{
			InitializeComponent();
		}

		private void Display(List<Sinhvien> sv_lst)
		{
			dgv.DataSource = sv_lst;
			dgv.Columns["masv"].HeaderText = "Mã sinh viên";
			dgv.Columns["hoten"].HeaderText = "Họ tên";
			dgv.Columns["tuoi"].HeaderText = "Tuổi";
			dgv.Columns["diachi"].HeaderText = "Địa chỉ";
			dgv.Columns["tenmon"].HeaderText = "Môn học";
			dgv.Columns["diem"].HeaderText = "Điểm";
			dgv.Columns[0].Width = 100;
			dgv.Columns[1].Width = 100;
			dgv.Columns[2].Width = 65;
			dgv.Columns[3].Width = 100;
			dgv.Columns[4].Width = 100;
			dgv.Columns[5].Width = 65;
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
			if (sv_lst.Count <= 0)
				MessageBox.Show("Không tìm thấy thông tin sinh viên!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public void Clear()
		{
			txt_masv.Text = string.Empty;
			txt_hoten.Text = string.Empty;
			txt_tuoi.Text = string.Empty;
			txt_diachi.Text = string.Empty;
			txt_tenmon.Text = string.Empty;
			txt_diem.Text = string.Empty;
		}

		private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Sinhvien sv = dgv.CurrentRow.DataBoundItem as Sinhvien;
			txt_masv.Text = sv.masv;
			txt_hoten.Text = sv.hoten;
			txt_tuoi.Text = sv.tuoi;
			txt_diachi.Text = sv.diachi;
			txt_tenmon.Text = sv.tenmon;
			txt_diem.Text = sv.diem;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Display(data.Get_sv());
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			if (txt_masv.Text == "" || txt_hoten.Text == "" || txt_tuoi.Text == "" ||
				txt_diachi.Text == "" || txt_tenmon.Text == "" || txt_diem.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thêm",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Sinhvien sv = new Sinhvien();
			sv.masv = txt_masv.Text;
			sv.hoten = txt_hoten.Text;
			sv.tuoi = txt_tuoi.Text;
			sv.diachi = txt_diachi.Text;
			sv.tenmon = txt_tenmon.Text;
			sv.diem = txt_diem.Text;
			if (data.Add_sv(sv))
			{
				MessageBox.Show("Thêm sinh viên thành công!", "Thêm",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				Clear();
				Display(data.Get_sv());
			}
			else
				MessageBox.Show("Trùng mã sinh viên!", "Thêm",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên {txt_masv.Text} không?", "Xóa",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (r == DialogResult.Yes)
			{
				Sinhvien sv = new Sinhvien();
				sv.masv = txt_masv.Text;
				sv.hoten = txt_hoten.Text;
				sv.tuoi = txt_tuoi.Text;
				sv.diachi = txt_diachi.Text;
				sv.tenmon = txt_tenmon.Text;
				sv.diem = txt_diem.Text;
				if (data.Delete_sv(sv))
				{
					MessageBox.Show("Xóa sinh viên thành công!", "Xóa",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
					Clear();
					Display(data.Get_sv());
				}
				else
					MessageBox.Show("Không tìm thấy thông tin sinh viên để xóa!", "Xóa",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_tim_Click(object sender, EventArgs e)
		{
			try
			{
				List<Sinhvien> sv_lst = data.Get_sv().Where(s => int.Parse(txt_from.Text) <= int.Parse(s.tuoi) && int.Parse(s.tuoi) <= int.Parse(txt_to.Text)).ToList();
				Display(sv_lst);
			}
			catch
			{
				MessageBox.Show("Nhập đúng dữ liệu để tìm kiếm", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
