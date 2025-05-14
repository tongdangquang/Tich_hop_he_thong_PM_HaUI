using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongDangQuang_2022603783_proj8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		DataUtil data = new DataUtil();
		public void Display()
		{
			List<Nhanvien> nv_lst = data.GetNhanvien();
			dataGridView.DataSource = nv_lst;
			dataGridView.Columns["manv"].HeaderText = "Mã NV";
			dataGridView.Columns["hoten"].HeaderText = "Họ tên";
			dataGridView.Columns["tuoi"].HeaderText = "Tuổi";
			dataGridView.Columns["luong"].HeaderText = "Lương";
			dataGridView.Columns["xa"].HeaderText = "Xã";
			dataGridView.Columns["huyen"].HeaderText = "Huyện";
			dataGridView.Columns["tinh"].HeaderText = "Tỉnh";
			dataGridView.Columns["dienthoai"].HeaderText = "Điện thoại";
			dataGridView.Columns[0].Width = 80;
			dataGridView.Columns[1].Width = 150;
			dataGridView.Columns[2].Width = 50;
			dataGridView.Columns[3].Width = 50;
			dataGridView.Columns[4].Width = 100;
			dataGridView.Columns[5].Width = 100;
			dataGridView.Columns[6].Width = 100;
			dataGridView.Columns[7].Width = 100;
			lbl_tong.Text = dataGridView.Rows.Count.ToString();
		}

		private void CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Nhanvien nv = (Nhanvien)dataGridView.CurrentRow.DataBoundItem;
			txt_manv.Text = nv.manv;
			txt_hoten.Text = nv.hoten;
			txt_tuoi.Text = nv.tuoi.ToString();
			txt_luong.Text = nv.luong.ToString();
			txt_xa.Text = nv.xa;
			txt_huyen.Text = nv.huyen;
			txt_tinh.Text = nv.tinh;
			txt_dienthoai.Text = nv.dienthoai;
		}

		public void Clear_text()
		{
			txt_manv.Text = string.Empty;
			txt_hoten.Text = string.Empty;
			txt_tuoi.Text = string.Empty;
			txt_luong.Text = string.Empty;
			txt_xa.Text = string.Empty;
			txt_huyen.Text = string.Empty;
			txt_tinh.Text = string.Empty;
			txt_dienthoai.Text = string.Empty;
		}

		public bool Check_data()
		{
			if (txt_manv.Text == "" || txt_hoten.Text == "" || txt_tuoi.Text == "" ||
				txt_luong.Text == "" || txt_xa.Text == "" || txt_huyen.Text == "" ||
				txt_tinh.Text == "" || txt_dienthoai.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu trước khi thêm!",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			try
			{
				int tuoi = int.Parse(txt_tuoi.Text);
				if (tuoi <= 0)
				{
					MessageBox.Show("Vui lòng nhập tuổi > 0!",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txt_tuoi.Focus();
					return false;
				}
			}
			catch
			{
				MessageBox.Show("Vui lòng nhập tuổi là một số nguyên dương!",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_tuoi.Focus();
				return false;
			}

			try
			{
				int luong = int.Parse(txt_luong.Text);
				if (luong <= 0)
				{
					MessageBox.Show("Vui lòng nhập lương > 0!",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txt_luong.Focus();
					return false;
				}
			}
			catch
			{
				MessageBox.Show("Vui lòng nhập lương là một số nguyên dương!",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_luong.Focus();
				return false;
			}
			return true;
		}

		public bool Check_empty_manv()
		{
			if (txt_manv.Text == "")
			{
				MessageBox.Show("Vui lòng nhập mã nhân viên!",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			if (Check_data())
			{
				Nhanvien nv = new Nhanvien();
				nv.manv = txt_manv.Text;
				nv.hoten = txt_hoten.Text;
				nv.tuoi = int.Parse(txt_tuoi.Text);
				nv.luong = int.Parse(txt_luong.Text);
				nv.xa = txt_xa.Text;
				nv.huyen = txt_huyen.Text;
				nv.tinh = txt_tinh.Text;
				nv.dienthoai = txt_dienthoai.Text;

				if (data.Them(nv))
				{
					MessageBox.Show("Thêm nhân viên thành công!",
						"Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Clear_text();
					Display();
				}
				else
					MessageBox.Show($"Đã có nhân viên '{txt_manv.Text}' trong danh sách!",
						"Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			if (Check_data())
			{
				Nhanvien nv = new Nhanvien();
				nv.manv = txt_manv.Text;
				nv.hoten = txt_hoten.Text;
				nv.tuoi = int.Parse(txt_tuoi.Text);
				nv.luong = int.Parse(txt_luong.Text);
				nv.xa = txt_xa.Text;
				nv.huyen = txt_huyen.Text;
				nv.tinh = txt_tinh.Text;
				nv.dienthoai = txt_dienthoai.Text;

				if (data.Sua(nv))
				{
					MessageBox.Show("Sửa thông tin nhân viên thành công!",
						"Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Display();
				}
				else
					MessageBox.Show("Mã nhân viên không tồn tại!",
						"Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			if (Check_empty_manv())
			{
				DialogResult result = MessageBox.Show($"Bạn chắc chắn muốn xóa nhân viên '{txt_manv.Text}'?",
					"Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					if (data.Xoa(txt_manv.Text))
					{
						MessageBox.Show("Xóa nhân viên thành công!",
						"Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Clear_text();
						Display();
					}
					else
						MessageBox.Show($"Không tìm thấy nhân viên '{txt_manv.Text}'!",
						"Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}
		}

		private void btn_tim_ma_Click(object sender, EventArgs e)
		{
			List<Nhanvien> nv_lst = data.Tim_theo_ma(txt_manv.Text);
			if (nv_lst.Count > 0)
				dataGridView.DataSource = nv_lst;
			else
				MessageBox.Show($"Không tồn tại nhân viên có mã '{txt_manv.Text}'!",
						"Tìm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Display();
		}

		private void btn_tim_luong_Click(object sender, EventArgs e)
		{
			List<Nhanvien> nv_lst = data.Tim_theo_luong(1000);
			if (nv_lst.Count > 0)
			{
				dataGridView.DataSource = nv_lst;
				lbl_tongluong.Text = "Tổng lương: ";
				lbl_tong.Text = nv_lst.Sum(nv => nv.luong).ToString();
			}
			else
			{
				MessageBox.Show($"Không tồn tại nhân viên có lương > 1000!",
						"Tìm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Display();
			}
		}

		private void btn_tim_tinh_Click(object sender, EventArgs e)
		{
			if (txt_tinh.Text != "")
			{
				List<Nhanvien> nv_lst = data.Tim_theo_tinh(txt_tinh.Text);
				if (nv_lst.Count > 0)
				{
					dataGridView.DataSource = nv_lst;
					lbl_tong.Text = dataGridView.Rows.Count.ToString();
				}
				else
				{
					MessageBox.Show($"Không tồn tại nhân viên tỉnh '{txt_tinh.Text}'!",
							"Tìm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show($"Vui lòng nhập tên tỉnh cần tìm!",
							"Tìm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_clear_Click(object sender, EventArgs e)
		{
			Display();
			Clear_text();
		}

		private void btn_thoat_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_test_xpath_Click(object sender, EventArgs e)
		{
			List<Nhanvien> tinh_lst = data.XPATH();
			if (tinh_lst.Count > 0)
			{
				dataGridView.DataSource = tinh_lst;
				lbl_tong.Text = dataGridView.Rows.Count.ToString();
			}
			else
			{
				MessageBox.Show($"Không tồn tại nhân viên!",
						"Tìm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

				//List<string> tinh_lst = data.XPATH();
				//if (tinh_lst.Count > 0)
				//	lbl_tong.Text = string.Join(", ", tinh_lst);
		}
	}
}
