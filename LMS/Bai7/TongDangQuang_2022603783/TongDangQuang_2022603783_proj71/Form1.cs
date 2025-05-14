using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TongDangQuang_2022603783;

namespace TongDangQuang_2022603783_proj71
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		DataUtil data = new DataUtil();

		private void Form1_Load(object sender, EventArgs e)
		{
			Hienthi();
		}

		public void Hienthi()
		{
			dataGridView1.DataSource = data.GetTaiKhoan();
			dataGridView1.Columns[0].Width = 100;
			dataGridView1.Columns[1].Width = 200;
			dataGridView1.Columns[2].Width = 100;
			dataGridView1.Columns[3].Width = 100;
			dataGridView1.Columns[4].Width = 100;
			lbl_tong.Text = dataGridView1.Rows.Count.ToString();
		}

		private void Them_Click(object sender, EventArgs e)
		{
			if ((txt_stk.Text == "") ||
				(txt_ttk.Text == "") ||
				(txt_dc.Text == "") ||
				(txt_dt.Text == "") ||
				(txt_st.Text == ""))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu trước khi thêm!",
					"Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Hienthi();
				return;
			}
			Taikhoan t = new Taikhoan();
			t.sotaikhoan = txt_stk.Text;
			t.tentaikhoan = txt_ttk.Text;
			t.diachi = txt_dc.Text;
			t.dienthoai = txt_dt.Text;
			t.sotien = txt_st.Text;
			if (data.Them(t))
			{
				MessageBox.Show("Thêm tài khoản thành công!",
					"Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Clear();
				Hienthi();
			}
			else
			{
				MessageBox.Show($"Đã tồn tại tài khoản '{txt_stk.Text}' trong danh sách!",
					"Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Hienthi();
			}
		}
		private void Clear()
		{
			txt_stk.Clear();
			txt_st.Clear();
			txt_dt.Clear();
			txt_dc.Clear();
			txt_ttk.Clear();
		}

		private bool Check_empty_data()
		{
			if (txt_stk.Text == "")
			{
				MessageBox.Show("Vui lòng nhập số tài khoản!",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Hienthi();
				return false;
			}
			return true;
		}
		private void btn_cap_nhat_Click(object sender, EventArgs e)
		{
			if (Check_empty_data())
			{
				Taikhoan t = new Taikhoan();
				t.sotaikhoan = txt_stk.Text;
				t.tentaikhoan = txt_ttk.Text;
				t.diachi = txt_dc.Text;
				t.dienthoai = txt_dt.Text;
				t.sotien = txt_st.Text;
				if (data.Capnhat(t))
				{
					MessageBox.Show("Cập nhật thành công!", "Cập nhật",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					Hienthi();
				}
				else
				{
					MessageBox.Show($"Không tìm thấy số tài khoản '{txt_stk.Text}' để cập nhật!",
						"Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Hienthi();
				}
			}
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			if (Check_empty_data())
			{
				Taikhoan t = new Taikhoan();
				t.sotaikhoan = txt_stk.Text;
				DialogResult result = MessageBox.Show($"Bạn chắc chắn muốn xóa tài khoản '{txt_stk.Text}'!",
					"Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					if (data.Xoa(t))
					{
						MessageBox.Show($"Xóa tài khoản thành công!", "Xóa tài khoản",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						Clear();
						Hienthi();
					}
					else
					{
						MessageBox.Show($"Không tìm thấy tài khoản '{txt_stk.Text}' " +
							$"để xóa!", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
						Hienthi();
					}
				}
			}
		}

		private void btn_Tim_Click(object sender, EventArgs e)
		{
			if (Check_empty_data())
			{
				Taikhoan t = data.Tim_kiem(txt_stk.Text);
				if (t != null)
				{
					txt_stk.Text = t.sotaikhoan;
					txt_ttk.Text = t.tentaikhoan;
					txt_dc.Text = t.diachi;
					txt_dt.Text = t.dienthoai;
					txt_st.Text = t.sotaikhoan;

					List<Taikhoan> tk_lst = new List<Taikhoan>();
					tk_lst.Add(t);
					dataGridView1.DataSource = tk_lst;
					dataGridView1.Columns[0].Width = 100;
					dataGridView1.Columns[1].Width = 200;
					dataGridView1.Columns[2].Width = 100;
					dataGridView1.Columns[3].Width = 100;
					dataGridView1.Columns[4].Width = 100;

					lbl_tong.Text = dataGridView1.Rows.Count.ToString();
				}
				else
				{
					MessageBox.Show($"Không tìm thấy tài khoản '{txt_stk.Text}'!",
						"Tìm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Hienthi();
				}
			}
		}

		private void btn_thoat_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Click_cell(object sender, DataGridViewCellEventArgs e)
		{
			Taikhoan t = (Taikhoan)dataGridView1.CurrentRow.DataBoundItem;
			txt_stk.Text = t.sotaikhoan;
			txt_ttk.Text = t.tentaikhoan;
			txt_dc.Text = t.diachi;
			txt_dt.Text = t.dienthoai;
			txt_st.Text = t.sotien;
		}
	}
}
