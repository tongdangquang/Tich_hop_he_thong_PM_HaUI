using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace de4
{
	internal class DataUtil
	{
		string filename;
		XmlDocument doc;
		XmlElement root;

        public DataUtil()
        {
			filename = "../../lophoc.xml";
			doc = new XmlDocument();
			if (!File.Exists(filename))
			{
				XmlElement lophoc = doc.CreateElement("lophoc");
				doc.AppendChild(lophoc);
				doc.Save(filename);
			}
			doc.Load(filename);
			root = doc.DocumentElement;
		}

		public List<Sinhvien> Get_sv()
		{
			List<Sinhvien> sv_lst =	new List<Sinhvien>();
			XmlNodeList nodes = doc.SelectNodes("//sinhvien");
			foreach (XmlNode node in nodes)
			{
				Sinhvien sv = new Sinhvien();
				sv.masv = node.Attributes["masv"].Value;
				sv.tuoi = node.Attributes["tuoi"].Value;
				sv.hoten = node["hoten"].InnerText;
				sv.diachi = node["diachi"].InnerText;
				XmlNode monhoc = node["monhoc"];
				sv.tenmon = monhoc["tenmon"].InnerText;
				sv.diem = monhoc["diem"].InnerText;
				sv_lst.Add(sv);
			}
			return sv_lst;
		}

		public XmlNode Find(Sinhvien sv)
		{
			XmlNode node = doc.SelectSingleNode($"//sinhvien[@masv = '{sv.masv}']");
			if (node != null)
				return node;
			return null;
		}

		public bool Add_sv(Sinhvien sv)
		{
			if (Find(sv) == null)
			{
				XmlElement sinhvien, hoten, diachi, monhoc, tenmon, diem;

				sinhvien = doc.CreateElement("sinhvien");
				sinhvien.SetAttribute("masv", sv.masv); 
				sinhvien.SetAttribute("tuoi", sv.tuoi);
				hoten = doc.CreateElement("hoten"); hoten.InnerText = sv.hoten;
				diachi = doc.CreateElement("diachi"); diachi.InnerText = sv.diachi;
				monhoc = doc.CreateElement("monhoc");
				tenmon = doc.CreateElement("tenmon"); tenmon.InnerText = sv.tenmon;
				diem = doc.CreateElement("diem"); diem.InnerText = sv.diem;

				monhoc.AppendChild(tenmon);
				monhoc.AppendChild(diem);
				sinhvien.AppendChild(hoten);
				sinhvien.AppendChild(diachi);
				sinhvien.AppendChild(monhoc);
				root.AppendChild(sinhvien);
				doc.Save(filename);
				return true;
			}
			return false;
		}

		public bool Delete_sv(Sinhvien sv)
		{
			XmlNode node = Find(sv);
			if (node != null)
			{
				root.RemoveChild(node);
				doc.Save(filename);
				return true;
			}
			return false;
		}
    }
}
