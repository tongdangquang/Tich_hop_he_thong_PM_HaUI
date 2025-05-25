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

namespace de5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		DataUtil data = new DataUtil();

		private void Display(List<Baihat> bh_lst)
		{
			dgv.DataSource = bh_lst;
			dgv.Columns["mabai"].HeaderText = "Mã bài hát";
			dgv.Columns["theloai"].HeaderText = "Thể loại";
			dgv.Columns["tenbai"].HeaderText = "Tên bài hát";
			dgv.Columns["casi"].HeaderText = "Ca sĩ";
			dgv.Columns["tacgia"].HeaderText = "Tác giả";

			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
			dgv.Columns[0].Width = 100;
			dgv.Columns[1].Width = 100;
			dgv.Columns[2].Width = 100;
			dgv.Columns[3].Width = 120;
			dgv.Columns[4].Width = 120;

			if (bh_lst.Count == 0)
				MessageBox.Show("Không có dữ liệu!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void Clear()
		{
			txt_mabai.Text = string.Empty;
			txt_theloai.Text = string.Empty;
			txt_tenbai.Text = string.Empty;
			txt_casi.Text = string.Empty;
			txt_tacgia.Text = string.Empty;
		}

		private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Baihat bh = dgv.CurrentRow.DataBoundItem as Baihat;
			txt_mabai.Text = bh.mabai;
			txt_theloai.Text = bh.theloai;
			txt_tenbai.Text = bh.tenbai;
			txt_casi.Text = bh.casi;
			txt_tacgia.Text = bh.tacgia;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Display(data.Get_bh());
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			if (txt_mabai.Text == "" || txt_theloai.Text == "" || txt_tenbai.Text == "" ||
				txt_casi.Text == "" || txt_tacgia.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu trước khi thêm!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Baihat bh = new Baihat();
			bh.mabai = txt_mabai.Text;
			bh.theloai = txt_theloai.Text;
			bh.tenbai = txt_tenbai.Text;
			bh.casi = txt_casi.Text;
			bh.tacgia = txt_tacgia.Text;
			if (data.Add_bh(bh))
			{
				MessageBox.Show("Thêm bài hát thành công!", "Thêm",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				Clear();
				Display(data.Get_bh());
			}
			else
			{
				MessageBox.Show("Thông tin bài hát đã tồn tại!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			if (txt_mabai.Text == "")
			{
				MessageBox.Show("Nhập mã bài hát bạn muốn xóa!", "Error",
					MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				txt_mabai.Focus();
				return;
			}
			DialogResult r = MessageBox.Show("Bạn chắc chắn muốn xóa bài hát này?", "Xóa",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (r == DialogResult.Yes)
			{
				Baihat bh = new Baihat();
				bh.mabai = txt_mabai.Text;
				bh.theloai = txt_theloai.Text;
				bh.tenbai = txt_tenbai.Text;
				bh.casi = txt_casi.Text;
				bh.tacgia = txt_tacgia.Text;
				if (data.Delete_bh(bh))
				{
					MessageBox.Show("Xóa thông tin bài hát thành công!", "Xóa",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
					Clear();
					Display(data.Get_bh());
				}
				else
					MessageBox.Show("Thông tin bài hát không tồn tại?", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			if (txt_mabai.Text == "" || txt_theloai.Text == "" || txt_tenbai.Text == "" ||
				txt_casi.Text == "" || txt_tacgia.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu trước khi sửa!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Baihat bh = new Baihat();
			bh.mabai = txt_mabai.Text;
			bh.theloai = txt_theloai.Text;
			bh.tenbai = txt_tenbai.Text;
			bh.casi = txt_casi.Text;
			bh.tacgia = txt_tacgia.Text;

			if (data.Update_bh(bh))
			{
				MessageBox.Show("Sửa thông tin thành công!", "Sửa",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				Clear();
				Display(data.Get_bh());
			}
			else
				MessageBox.Show($"Không tìm thấy bài hát có mã {txt_mabai.Text} để sửa!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
