using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Windows.Forms;

namespace Call_API_winform
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string link = "http://204.0.188.49//WebAPI_bai11/api/";

		public void Display()
		{
			HttpWebRequest request = HttpWebRequest.CreateHttp(link + "get_all_nv");
			WebResponse response = request.GetResponse();
			DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
			object data = js.ReadObject(response.GetResponseStream());
			NhanVien[] nv_arr = (NhanVien[])data;
			dgv.DataSource = nv_arr;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void btn_11_1_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void btn_11_2_Click(object sender, EventArgs e)
		{
			HttpWebRequest request = HttpWebRequest.CreateHttp($"{link}get_nv_by_ma?ma={txt_manv.Text}");
			WebResponse response = request.GetResponse();
			DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien));
			object data = js.ReadObject(response.GetResponseStream());
			List<NhanVien> nv_lst = new List<NhanVien>();
			nv_lst.Add(data as NhanVien);
			dgv.DataSource = nv_lst;
		}

		private void btn_11_3_Click(object sender, EventArgs e)
		{
			HttpWebRequest request = HttpWebRequest.CreateHttp($"{link}get_nv_by_donvi?madonvi={txt_madv_11_3.Text}");
			WebResponse response = request.GetResponse();
			DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
			object data = js.ReadObject(response.GetResponseStream());
			NhanVien[] dv_arr = data as NhanVien[];
			dgv.DataSource = dv_arr;
		}

		private void btn_11_4_Click(object sender, EventArgs e)
		{
			HttpWebRequest request = HttpWebRequest.CreateHttp($"{link}get_nv_by_gioitinh?gender={txt_gioitinh.Text}");
			WebResponse response = request.GetResponse();
			DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
			object data = js.ReadObject(response.GetResponseStream());
			NhanVien[] nv_arr = data as NhanVien[];
			dgv.DataSource = nv_arr;
		}

		private void btn_11_5_Click(object sender, EventArgs e)
		{
			HttpWebRequest request = HttpWebRequest.CreateHttp($"{link}get_nv_by_luong?a={txt_from.Text}&b={txt_to.Text}");
			WebResponse response = request.GetResponse();
			DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
			object data = js.ReadObject(response.GetResponseStream());
			NhanVien[] nv_arr = data as NhanVien[];
			dgv.DataSource = nv_arr;
		}

		private void btn_11_6_Click(object sender, EventArgs e)
		{
			HttpWebRequest request = HttpWebRequest.CreateHttp($"{link}get_all_dv");
			WebResponse response = request.GetResponse();
			DataContractJsonSerializer js = new DataContractJsonSerializer (typeof(DonVi[]));
			object data = js.ReadObject(response.GetResponseStream());
			DonVi[] dv_arr = data as DonVi[];
			dgv.DataSource= dv_arr;
		}

		private void btn_11_7_Click(object sender, EventArgs e)
		{
			HttpWebRequest request = HttpWebRequest.CreateHttp($"{link}get_dv_by_madv?madv={txt_madv_11_7.Text}");
			WebResponse response = request.GetResponse();
			DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DonVi));
			object data = js.ReadObject(response.GetResponseStream());
			List<DonVi> dv_lst = new List<DonVi>();
			dv_lst.Add(data as DonVi);
			dgv.DataSource = dv_lst;
		}
	}
}
