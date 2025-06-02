using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace CallAPI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Display(string link)
		{
			HttpWebRequest request = HttpWebRequest.CreateHttp(link);
			WebResponse response = request.GetResponse();
			DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
			object data = js.ReadObject(response.GetResponseStream());
			SanPham[] sp_arr = data as SanPham[];
			dgv.DataSource = sp_arr.ToList();
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			if (sp_arr.Length == 0)
				MessageBox.Show("Không có dữ liệu!", "Information",
					MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		string url = "http://localhost/test_api/api/get_all_sanpham";

		private void Form1_Load(object sender, EventArgs e)
		{
			Display(url);
		}

		private void btn_laytheodm_Click(object sender, EventArgs e)
		{
			if (txt_madm.Text == "")
			{
				MessageBox.Show("Vui lòng nhập mã danh mục trước!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string link = $"http://localhost/test_api/api/get_sanpham/{txt_madm.Text}";
			Display(link);
		}

		private void btn_laytheogia_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(txt_from.Text);
				double b = double.Parse(txt_to.Text);
				if (txt_from.Text == "" || txt_to.Text == "")
				{
					MessageBox.Show("Vui lòng nhập khoảng giá trước!", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				string link = $"http://localhost/test_api/api/get_sanpham_by_gia/{a}/{b}";
				Display(link);
			}
			catch
			{
				MessageBox.Show("Vui lòng nhập giá tiền là số thực!", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_luu_Click(object sender, EventArgs e)
		{
			if (txt_madm.Text == "" || txt_tendm.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string link = "http://localhost/test_api/api/post_danhmuc";
			var client = new WebClient();
			var dm = new NameValueCollection();
			dm["MaDanhMuc"] = txt_madm.Text;
			dm["TenDanhMuc"] = txt_tendm.Text;
			var response = client.UploadValues(link, dm);
			string msg = Encoding.UTF8.GetString(response);
			if (msg == "true")
			{
				MessageBox.Show($"Thêm danh mục thành công!", "Thêm",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				Display(url);
			}
			else
				MessageBox.Show($"Mã danh mục đã tồn tại!", "Thêm",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			if (txt_madm.Text == "" || txt_tendm.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string link = "http://localhost/test_api/api/put_danhmuc";
			var client = new WebClient();
			var dm = new NameValueCollection();
			dm["MaDanhMuc"] = txt_madm.Text;
			dm["TenDanhMuc"] = txt_tendm.Text;
			var response = client.UploadValues(link, "PUT", dm);
			string msg = Encoding.UTF8.GetString(response);
			if (msg == "true")
			{
				MessageBox.Show($"Sửa danh mục thành công!", "Cập nhật",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				Display(url);
			}
			else
				MessageBox.Show($"Danh mục không tồn tại!", "Cập nhật",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Bạn có chắn chắn muốn xóa danh mục này?", "Xóa",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (r == DialogResult.Yes)
			{
				if (txt_madm.Text == "")
				{
					MessageBox.Show("Vui lòng nhập mã danh mục trước khi xóa!", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				string link = $"http://localhost/test_api/api/delete_danhmuc/{txt_madm.Text}";
				WebRequest request = WebRequest.CreateHttp(link);
				request.Method = "DELETE";
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				if (response.StatusCode == HttpStatusCode.OK)
				{
					MessageBox.Show($"Xóa danh mục thành công!", "Xóa",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					Display(url);
				}
				else
					MessageBox.Show($"Có lỗi khi xóa!", "Xóa",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_show_all_Click(object sender, EventArgs e)
		{
			Display(url);
		}

		private void btn_show_all_dm_Click(object sender, EventArgs e)
		{
			string link = "http://localhost/test_api/api/get_all_danhmuc";
			HttpWebRequest request = WebRequest.CreateHttp(link);
			WebResponse response = request.GetResponse();
			DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc[]));
			object data = js.ReadObject(response.GetResponseStream());
			DanhMuc[] dm_arr = data as DanhMuc[];
			dgv.DataSource = dm_arr.ToList();
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}
	}
}
