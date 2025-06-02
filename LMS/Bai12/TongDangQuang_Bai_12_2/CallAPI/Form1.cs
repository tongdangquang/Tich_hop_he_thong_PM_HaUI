using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;

namespace CallAPI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Clear()
		{
			txt_madv.Text = string.Empty;
			txt_tendv.Text = string.Empty;
		}

		private void Display()
		{
			string link = "http://localhost/test_api/api/get_dv";
			HttpWebRequest request = HttpWebRequest.CreateHttp(link);
			WebResponse response = request.GetResponse();
			DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DonVi[]));
			object data = js.ReadObject(response.GetResponseStream());
			DonVi[] dv_arr = data as DonVi[];
			dgv.DataSource = dv_arr;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DonVi dv = dgv.CurrentRow.DataBoundItem as DonVi;
			txt_madv.Text = dv.MaDonVi.ToString();
			txt_tendv.Text = dv.TenDonVi;
		}

		private void btn_hienthi_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			if (txt_madv.Text == "" || txt_tendv.Text == "")
			{
				MessageBox.Show("Nhập đầy đủ thông tin trước khi sửa!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string link = "http://localhost/test_api/api/post_dv";
			var client = new WebClient();
			var dv = new NameValueCollection();
			dv["MaDonVi"] = txt_madv.Text;
			dv["TenDonVi"] = txt_tendv.Text;
			var response = client.UploadValues(link, dv);
			string msg = Encoding.UTF8.GetString(response);
			if (msg == "true")
			{
				MessageBox.Show("Thêm đơn vị thành công!", "Thêm",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				Display();
				Clear();
			}
			else
				MessageBox.Show("Mã đơn vị đã tồn tại!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			if (txt_madv.Text == "" || txt_tendv.Text == "")
			{
				MessageBox.Show("Nhập đầy đủ thông tin trước khi sửa!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string link = "http://localhost/test_api/api/put_dv";
			var client = new WebClient();
			var dv = new NameValueCollection();
			dv["MaDonVi"] = txt_madv.Text;
			dv["TenDonVi"] = txt_tendv.Text;
			var response = client.UploadValues(link, "PUT", dv);
			string msg = Encoding.UTF8.GetString(response);
			if (msg == "true")
			{
				MessageBox.Show("Sửa đơn vị thành công!", "Sửa",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				Display();
				Clear();
			}
			else
				MessageBox.Show("Mã đơn vị không tồn tại!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			if (txt_madv.Text == "")
			{
				MessageBox.Show("Nhập mã đơn vị trước khi xóa!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DialogResult r = MessageBox.Show("Bạn có chắn chắn muốn xóa đơn vị này?", "Xóa",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (r == DialogResult.Yes)
			{
				string link = $"http://localhost/test_api/api/delete_dv?madv={txt_madv.Text}";
				WebRequest request = WebRequest.CreateHttp(link);
				request.Method = "DELETE";
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				StreamReader reader = new StreamReader(response.GetResponseStream());
				string result = reader.ReadToEnd();
				if (result == "true")
				{
					MessageBox.Show("Xóa đơn vị thành công!", "Xóa",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					Display();
					Clear();
				}
				else
					MessageBox.Show("Mã đơn vị không tồn tại!", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
