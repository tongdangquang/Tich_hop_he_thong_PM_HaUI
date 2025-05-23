using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		DataUtil data = new DataUtil();

		private void Display(List<Nhanvien> nv_lst)
		{
			dgv.DataSource = nv_lst;
			dgv.Columns["ngay"].HeaderText = "Ngày làm việc";
			dgv.Columns["ma"].HeaderText = "Mã nhân viên";
			dgv.Columns["loai"].HeaderText = "Loại làm thêm";
			dgv.Columns["sogio"].HeaderText = "Số giờ";
			dgv.Columns["trangthai"].HeaderText = "Trạng thái";
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
			dgv.Columns[0].Width = 100;
			dgv.Columns[1].Width = 100;
			dgv.Columns[2].Width = 100;
			dgv.Columns[3].Width = 100;
			dgv.Columns[4].Width = 130;
		}

		public void Clear()
		{
			txt_ngay.Text = string.Empty;
			txt_manv.Text = string.Empty;
			txt_loai.Text = string.Empty;
			txt_sogio.Text = string.Empty;
			txt_trangthai.Text = string.Empty;
		}

		private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Nhanvien nv = dgv.CurrentRow.DataBoundItem as Nhanvien;
			txt_ngay.Text = nv.ngay;
			txt_manv.Text = nv.ma;
			txt_loai.Text = nv.loai;
			txt_sogio.Text = nv.sogio;
			txt_trangthai.Text = nv.trangthai;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Display(data.Get_nv());
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			Nhanvien nv = new Nhanvien();
			nv.ngay = txt_ngay.Text;
			nv.ma = txt_manv.Text;
			nv.loai = txt_loai.Text;
			nv.sogio = txt_sogio.Text;
			nv.trangthai = txt_trangthai.Text;

			if (data.Add_nv(nv))
			{
				MessageBox.Show("Thêm thông tin thành công!", "Thêm",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				Clear();
				Display(data.Get_nv());
			}
			else
				MessageBox.Show("Thông tin đã tồn tại!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này không?",
				"Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (r == DialogResult.Yes)
			{
				Nhanvien nv = new Nhanvien();
				nv.ngay = txt_ngay.Text;
				nv.ma = txt_manv.Text;
				nv.loai = txt_loai.Text;
				nv.sogio = txt_sogio.Text;
				nv.trangthai = txt_trangthai.Text;
				if (data.Delete_nv(nv))
				{
					MessageBox.Show("Xóa thông tin thành công!", "Xóa",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
					Clear();
					Display(data.Get_nv());
				}
				else
					MessageBox.Show("Thông tin không tồn tại!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_tim_Click(object sender, EventArgs e)
		{
			if (txt_ngay.Text != "")
			{
				List<Nhanvien> nv_lst = data.Get_nv().Where(x => x.ngay == txt_ngay.Text).ToList();
				if (nv_lst.Count == 0)
					MessageBox.Show("Không tìm thấy thông tin!", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
				Display(nv_lst);
			}
			else
				MessageBox.Show("Vui lòng nhập ngày trước khi tìm!", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
