using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TongDangQuang_2022603783_proj8
{
	internal class DataUtil
	{
		XmlDocument doc;
		XmlElement root;
		string filename;

        public DataUtil()
        {
			filename = "congty.xml";
			doc = new XmlDocument();
			if (!File.Exists(filename))
			{
				XmlElement congty = doc.CreateElement("congty");
				doc.AppendChild(congty);
				doc.Save(filename);
			}
			doc.Load(filename);
			root = doc.DocumentElement;
        }

		public List<Nhanvien> GetNhanvien()
		{
			List<Nhanvien> nv_lst = new List<Nhanvien>();
			XmlNodeList nodes = root.SelectNodes("nhanvien");
			foreach (XmlNode node in nodes)
			{
				Nhanvien nv = new Nhanvien();
				nv.manv = node.Attributes["manv"].Value;
				nv.hoten = node["hoten"].InnerText;
				nv.tuoi = int.Parse(node["tuoi"].InnerText);
				nv.luong = int.Parse(node["luong"].InnerText);
				XmlElement diachi = node["diachi"];
				nv.xa = diachi["xa"].InnerText;
				nv.huyen = diachi["huyen"].InnerText;
				nv.tinh = diachi["tinh"].InnerText;
				nv.dienthoai = node["dienthoai"].InnerText;
				nv_lst.Add(nv);
			}
			return nv_lst;
		}

		public XmlNode Tim(string manv)
		{
			XmlNode nv = doc.SelectSingleNode($"/congty/nhanvien[@manv = '{manv}']");
			if (nv != null)
				return nv;
			return null;
		}

		public bool Them(Nhanvien nv)
		{
			if (Tim(nv.manv) == null)
			{
				XmlElement nhanvien = doc.CreateElement("nhanvien");
				nhanvien.SetAttribute("manv", nv.manv);
				XmlElement hoten = doc.CreateElement("hoten");
				hoten.InnerText = nv.hoten;
				XmlElement tuoi = doc.CreateElement("tuoi");
				tuoi.InnerText = nv.tuoi.ToString();
				XmlElement luong = doc.CreateElement("luong");
				luong.InnerText = nv.luong.ToString();
				XmlElement diachi = doc.CreateElement("diachi");
				XmlElement xa = doc.CreateElement("xa");
				xa.InnerText = nv.xa;
				XmlElement huyen = doc.CreateElement("huyen");
				huyen.InnerText = nv.huyen;
				XmlElement tinh = doc.CreateElement("tinh");
				tinh.InnerText = nv.tinh;
				XmlElement dienthoai = doc.CreateElement("dienthoai");
				dienthoai.InnerText = nv.dienthoai;

				diachi.AppendChild(xa);
				diachi.AppendChild(huyen);
				diachi.AppendChild(tinh);
				nhanvien.AppendChild(hoten);
				nhanvien.AppendChild(tuoi);
				nhanvien.AppendChild(luong);
				nhanvien.AppendChild(diachi);
				nhanvien.AppendChild(dienthoai);
				root.AppendChild(nhanvien);

				doc.Save(filename);
				return true;
			}
			return false;
		}

		public bool Sua(Nhanvien nv)
		{
			XmlNode old_nv = Tim(nv.manv);
			if (old_nv != null)
			{
				XmlElement new_nv = doc.CreateElement("nhanvien");
				new_nv.SetAttribute("manv", nv.manv);
				XmlElement hoten = doc.CreateElement("hoten");
				hoten.InnerText = nv.hoten;
				XmlElement tuoi = doc.CreateElement("tuoi");
				tuoi.InnerText = nv.tuoi.ToString();
				XmlElement luong = doc.CreateElement("luong");
				luong.InnerText = nv.luong.ToString();
				XmlElement diachi = doc.CreateElement("diachi");
				XmlElement xa = doc.CreateElement("xa");
				xa.InnerText = nv.xa;
				XmlElement huyen = doc.CreateElement("huyen");
				huyen.InnerText = nv.huyen;
				XmlElement tinh = doc.CreateElement("tinh");
				tinh.InnerText = nv.tinh;
				XmlElement dienthoai = doc.CreateElement("dienthoai");
				dienthoai.InnerText = nv.dienthoai;

				diachi.AppendChild(xa);
				diachi.AppendChild(huyen);
				diachi.AppendChild(tinh);
				new_nv.AppendChild(hoten);
				new_nv.AppendChild(tuoi);
				new_nv.AppendChild(luong);
				new_nv.AppendChild(diachi);
				new_nv.AppendChild(dienthoai);

				root.ReplaceChild(new_nv, old_nv);
				doc.Save(filename);
				return true;
			}
			return false;
		}

		public bool Xoa(string manv)
		{
			XmlNode node = Tim(manv);
			if (node != null)
			{
				root.RemoveChild(node);
				doc.Save(filename);
				return true;
			}
			return false;
		}

		public List<Nhanvien> Tim_theo_ma(string manv)
		{
			List <Nhanvien> nv_lst = new List<Nhanvien>();
			XmlNodeList nodes = doc.SelectNodes($"//nhanvien[@manv = '{manv}']");
			foreach (XmlNode node in nodes)
			{
				Nhanvien nv = new Nhanvien();
				nv.manv = node.Attributes["manv"].Value;
				nv.hoten = node["hoten"].InnerText;
				nv.tuoi = int.Parse(node["tuoi"].InnerText);
				nv.luong = int.Parse(node["luong"].InnerText);
				XmlElement diachi = node["diachi"];
				nv.xa = diachi["xa"].InnerText;
				nv.huyen = diachi["huyen"].InnerText;
				nv.tinh = diachi["tinh"].InnerText;
				nv.dienthoai = node["dienthoai"].InnerText;
				nv_lst.Add(nv);
			}
			return nv_lst;
		}

		public List<Nhanvien> Tim_theo_luong(int luong)
		{
			List<Nhanvien> nv_lst = new List<Nhanvien>();
			XmlNodeList nodes = doc.SelectNodes($"//nhanvien[luong > {luong}]");
			foreach (XmlNode node in nodes)
			{
				Nhanvien nv = new Nhanvien();
				nv.manv = node.Attributes["manv"].Value;
				nv.hoten = node["hoten"].InnerText;
				nv.tuoi = int.Parse(node["tuoi"].InnerText);
				nv.luong = int.Parse(node["luong"].InnerText);
				XmlElement diachi = node["diachi"];
				nv.xa = diachi["xa"].InnerText;
				nv.huyen = diachi["huyen"].InnerText;
				nv.tinh = diachi["tinh"].InnerText;
				nv.dienthoai = node["dienthoai"].InnerText;
				nv_lst.Add(nv);
			}
			return nv_lst;
		}

		public List<Nhanvien> Tim_theo_tinh(string tinh)
		{
			List<Nhanvien> nv_lst = new List<Nhanvien>();
			XmlNodeList nodes = doc.SelectNodes($"//nhanvien[diachi/tinh = '{tinh}']");
			foreach (XmlNode node in nodes)
			{
				Nhanvien nv = new Nhanvien();
				nv.manv = node.Attributes["manv"].Value;
				nv.hoten = node["hoten"].InnerText;
				nv.tuoi = int.Parse(node["tuoi"].InnerText);
				nv.luong = int.Parse(node["luong"].InnerText);
				XmlElement diachi = node["diachi"];
				nv.xa = diachi["xa"].InnerText;
				nv.huyen = diachi["huyen"].InnerText;
				nv.tinh = diachi["tinh"].InnerText;
				nv.dienthoai = node["dienthoai"].InnerText;
				nv_lst.Add(nv);
			}
			return nv_lst;
		}
	}
}
