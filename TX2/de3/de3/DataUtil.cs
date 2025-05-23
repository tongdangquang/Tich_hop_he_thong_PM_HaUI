using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace de3
{
	internal class DataUtil
	{
		string filename;
		XmlDocument doc;
		XmlElement root;
        public DataUtil()
        {
			filename = "DangKyLamThem.xml";
			doc = new XmlDocument();
			if (!File.Exists(filename))
			{
				XmlElement DangKyLamThem = doc.CreateElement("DangKyLamThem");
				doc.AppendChild(DangKyLamThem);
				doc.Save(filename);
			}
			doc.Load(filename);
			root = doc.DocumentElement;
        }

		// lấy dữ liệu
		public List<Nhanvien> Get_nv()
		{
			List<Nhanvien> nv_lst = new List<Nhanvien>();
			XmlNodeList nodes = doc.SelectNodes("//NhanVien");
			foreach (XmlNode node in nodes)
			{
				Nhanvien nv = new Nhanvien();
				nv.ngay = node.ParentNode.Attributes["Ngay"].Value;
				nv.ma = node.Attributes["Ma"].Value;
				nv.loai = node["LoaiLamThem"].InnerText;
				nv.sogio = node["SoGio"].InnerText;
				nv.trangthai = node["TrangThai"].InnerText;
				nv_lst.Add(nv);
			}
			return nv_lst;
		}

		public XmlNode Find(Nhanvien nv)
		{
			XmlNode node = doc.SelectSingleNode($"//NgayLamViec[@Ngay = '{nv.ngay}']/NhanVien[@Ma = '{nv.ma}']");
			if (node != null)
				return node;
			return null;
		}
		// thêm dữ liệu
		public bool Add_nv(Nhanvien nv)
		{
			// trường hợp dữ liệu đã tồn tại
			if (Find(nv) != null)
				return false;

			XmlNode th2 = doc.SelectSingleNode($"//NgayLamViec[@Ngay = '{nv.ngay}']");
			// trường hợp tồn tại ngày
			if (th2 != null)
			{
				XmlElement nhanvien = doc.CreateElement("NhanVien");
				nhanvien.SetAttribute("Ma", nv.ma);
				XmlElement loai = doc.CreateElement("LoaiLamThem");
				loai.InnerText = nv.loai;
				XmlElement sogio = doc.CreateElement("SoGio");
				sogio.InnerText = nv.sogio.ToString();
				XmlElement trangthai = doc.CreateElement("TrangThai");
				trangthai.InnerText = nv.trangthai;
				
				nhanvien.AppendChild(loai);
				nhanvien.AppendChild(sogio);
				nhanvien.AppendChild(trangthai);
				th2.AppendChild(nhanvien);
				doc.Save(filename);
			}
			// trường hợp không tồn tại ngày
			else
			{
				XmlElement th3 = doc.CreateElement("NgayLamViec");
				th3.SetAttribute("Ngay", nv.ngay);
				XmlElement nhanvien = doc.CreateElement("NhanVien");
				nhanvien.SetAttribute("Ma", nv.ma);
				XmlElement loai = doc.CreateElement("LoaiLamThem");
				loai.InnerText = nv.loai;
				XmlElement sogio = doc.CreateElement("SoGio");
				sogio.InnerText = nv.sogio;
				XmlElement trangthai = doc.CreateElement("TrangThai");
				trangthai.InnerText = nv.trangthai;

				nhanvien.AppendChild(loai);
				nhanvien.AppendChild(sogio);
				nhanvien.AppendChild(trangthai);
				th3.AppendChild(nhanvien);
				root.AppendChild(th3);
				doc.Save(filename);
			}
			return true;
		}

		public bool Delete_nv(Nhanvien nv)
		{
			XmlNode node = Find(nv);
			if (node != null)
			{
				XmlNode node_parent = node.ParentNode;
				node_parent.RemoveChild(node);
				return true;
			}
			return false;
		}

		//public List<Nhanvien> Get_by_ngay(string ngay)
		//{
		//	List<Nhanvien> nv_lst = Get_nv().Where(x => x.ngay == ngay).ToList();
		//	return nv_lst;
		//}
	}
}
