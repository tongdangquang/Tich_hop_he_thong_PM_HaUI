using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		DataUtil data = new DataUtil();

		private void Display(List<Xe> x_lst)
		{
			dtg.DataSource = x_lst;
			dtg.Columns["tenhangxe"].HeaderText = "Hãng xe";
			dtg.Columns["tendongxe"].HeaderText = "Dòng xe";
			dtg.Columns["phienban"].HeaderText = "Phiên bản";
			dtg.Columns["dongco"].HeaderText = "Động cơ";
			dtg.Columns["gia"].HeaderText = "Giá";
			dtg.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			dtg.Columns[0].Width = 80;
			dtg.Columns[1].Width = 130;
			dtg.Columns[2].Width = 130;
			dtg.Columns[3].Width = 130;
			dtg.Columns[4].Width = 70;
		}

		public void Clear()
		{
			txt_hangxe.Text = string.Empty;
			txt_dongxe.Text = string.Empty;
			txt_phienban.Text = string.Empty;
			txt_dongco.Text = string.Empty;
			txt_gia.Text = string.Empty;
		}

		private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Xe x = dtg.CurrentRow.DataBoundItem as Xe;
			txt_hangxe.Text = x.tenhangxe;
			txt_dongxe.Text = x.tendongxe;
			txt_phienban.Text = x.phienban;
			txt_dongco.Text = x.dongco;
			txt_gia.Text = x.gia.ToString();
		}

		private bool Check_data()
		{
			if (txt_hangxe.Text == "" || txt_dongxe.Text == "" || txt_phienban.Text == "" ||
				txt_dongco.Text == "" || txt_gia.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			try
			{
				int gia = int.Parse(txt_gia.Text);
				if (gia <= 0)
				{
					MessageBox.Show("Vui lòng nhập giá là số nguyên dương!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			catch
			{
				MessageBox.Show("Vui lòng nhập giá là số nguyên dương!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Display(data.Get_xe());
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			if (Check_data())
			{
				Xe x = new Xe();
				x.tenhangxe = txt_hangxe.Text;
				x.tendongxe = txt_dongxe.Text;
				x.phienban = txt_phienban.Text;
				x.dongco = txt_dongco.Text;
				x.gia = int.Parse(txt_gia.Text);

				if (data.Add_xe(x))
				{
					MessageBox.Show("Thêm xe thành công!", "Thêm",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					Clear();
					Display(data.Get_xe());
				}
				else
					MessageBox.Show("Thông tin đã tồn tại!", "Thêm",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult r = MessageBox.Show($"Bạn có chắc chắn muốn xóa thông tin xe {txt_dongxe.Text} không?",
					"Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (r == DialogResult.Yes)
				{
					Xe x = new Xe();
					x.tenhangxe = txt_hangxe.Text;
					x.tendongxe = txt_dongxe.Text;
					x.phienban = txt_phienban.Text;
					x.dongco = txt_dongco.Text;
					x.gia = int.Parse(txt_gia.Text);
					
					if (data.Delete_xe(x))
					{
						MessageBox.Show("Xóa thông tin xe thành công!", "Xóa",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
						Clear();
						Display(data.Get_xe());
					}
					else
						MessageBox.Show("Thông tin xe không tồn tại!", "Xóa",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("Có lỗi trong quá trình xóa thông tin xe!", "Xóa",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_tim_Click(object sender, EventArgs e)
		{
			if (txt_hangxe.Text != "")
			{
				List<Xe> xe_lst = data.Get_by_hangxe(txt_hangxe.Text);
				if (xe_lst.Count > 0)
					Display(xe_lst);
				else
					MessageBox.Show($"Không tồn tại hãng xe {txt_hangxe.Text}!", "Tìm",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show("Vui lòng nhập hãng xe trước khi tìm!", "Tìm",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_hangxe.Focus();
			}

		}
	}
}
