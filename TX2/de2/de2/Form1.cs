using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		DataUtil data = new DataUtil();

		private void Display(List<Khuvuc> kv_lst)
		{
			dgv.DataSource = kv_lst;
			dgv.Columns["ngay"].HeaderText = "Ngày";
			dgv.Columns["ma"].HeaderText = "Mã khu vực";
			dgv.Columns["kieutt"].HeaderText = "Kiểu thời tiết";
			dgv.Columns["ndmax"].HeaderText = "Nhiệt độ cao nhất";
			dgv.Columns["ndmin"].HeaderText = "Nhiệt độ thấp nhất";
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			dgv.Columns[0].Width = 100;
			dgv.Columns[1].Width = 100;
			dgv.Columns[2].Width = 120;
			dgv.Columns[3].Width = 140;
			dgv.Columns[4].Width = 140;
		}

		public void Clear()
		{
			txt_ngay.Text = string.Empty;
			txt_ma.Text = string.Empty;
			txt_kieutt.Text = string.Empty;
			txt_ndmax.Text = string.Empty;
			txt_ndmin.Text = string.Empty;
		}

		private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Khuvuc kv = dgv.CurrentRow.DataBoundItem as Khuvuc;
			txt_ngay.Text = kv.ngay.ToString();
			txt_ma.Text = kv.ma;
			txt_kieutt.Text = kv.kieutt;
			txt_ndmax.Text = kv.ndmax.ToString();
			txt_ndmin.Text = kv.ndmin.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Display(data.Get_khuvuc());
		}

		private bool Check_data()
		{
			if (txt_ngay.Text == "" || txt_ma.Text == "" || txt_kieutt.Text == "" ||
				txt_ndmax.Text == "" || txt_ndmin.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			try
			{
				double max = double.Parse(txt_ndmax.Text);
				double min = double.Parse(txt_ndmin.Text);
			}
			catch
			{
				MessageBox.Show("Vui lòng nhập nhiệt độ là số thực!", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			if (Check_data())
			{
				Khuvuc kv = new Khuvuc();
				kv.ngay = txt_ngay.Text;
				kv.ma = txt_ma.Text;
				kv.kieutt = txt_kieutt.Text;
				kv.ndmax = double.Parse(txt_ndmax.Text);
				kv.ndmin = double.Parse(txt_ndmin.Text);

				if (data.Add_kv(kv))
				{
					MessageBox.Show("Thêm thông tin thành công!", "Thêm",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					Clear();
					Display(data.Get_khuvuc());
				}
				else
					MessageBox.Show("Thông tin đã tồn tại!", "Thêm",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			if (txt_ngay.Text != "" && txt_ma.Text != "")
			{
				DialogResult r = MessageBox.Show($"Bạn có chắc chắn muốn xóa khu vực {txt_ma.Text} không?",
					"Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (r == DialogResult.Yes)
				{
					Khuvuc kv = new Khuvuc();
					kv.ngay = txt_ngay.Text;
					kv.ma = txt_ma.Text;
					kv.kieutt = txt_kieutt.Text;
					kv.ndmax = double.Parse(txt_ndmax.Text);
					kv.ndmin = double.Parse(txt_ndmin.Text);
					if (data.Delete_kv(kv))
					{
						MessageBox.Show("Xóa thông tin thành công!", "Xóa",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
						Clear();
						Display(data.Get_khuvuc());
					}
					else
						MessageBox.Show($"Không tồn tại thông tin khu vực {txt_ma.Text}!", "Xóa",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}	
			}
			else
			{
				MessageBox.Show("Nhập ngày và mã khu vực trước khi xóa!", "Xóa",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_ngay.Focus();
			}
		}

		private void btn_tim_Click(object sender, EventArgs e)
		{
			if (txt_ngay.Text != "")
			{
				List<Khuvuc> kv_list = data.Get_by_ngay(txt_ngay.Text);
				if (kv_list.Count > 0)
					Display(kv_list);
				else
					MessageBox.Show($"Không có thông tin khu vực nào trong ngày {txt_ngay.Text}!", "Tìm",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("Nhập ngày trước khi tìm!", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
