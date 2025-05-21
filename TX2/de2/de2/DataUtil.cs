using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace de2
{
	internal class DataUtil
	{
		string filename;
		XmlDocument doc;
		XmlElement root;

        public DataUtil()
        {
			filename = "DuBaoThoiTiet.xml";
			doc = new XmlDocument();
			if (!File.Exists(filename))
			{
				XmlElement dubaothoitiet = doc.CreateElement("dubaothoitiet");
				doc.AppendChild(dubaothoitiet);
				doc.Save(filename);
			}
			doc.Load(filename);
			root = doc.DocumentElement;
        }

		public List<Khuvuc> Get_khuvuc()
		{
			List<Khuvuc> kv_lst = new List<Khuvuc>();
			XmlNodeList nodes = doc.SelectNodes("//khuvuc");
			foreach (XmlNode node in nodes)
			{
				Khuvuc kv = new Khuvuc();
				kv.ngay = node.ParentNode.Attributes["ngay"].Value;
				kv.ma = node.Attributes["ma"].Value;
				kv.kieutt = node["kieuthoitiet"].InnerText;
				kv.ndmax = double.Parse(node["nhietdocaonhat"].InnerText);
				kv.ndmin = double.Parse(node["nhietdothapnhat"].InnerText);
				kv_lst.Add(kv);
			}
			return kv_lst;
 		}

		public XmlNode Find_node(Khuvuc kv)
		{
			XmlNode node = doc.SelectSingleNode($"//thoitiet[@ngay = '{kv.ngay}']/khuvuc[@ma = '{kv.ma}']");
			if (node != null) 
				return node;
			return null;
		}

		public bool Add_kv(Khuvuc kv)
		{
			// trường hợp tồn tại ngày và mã khu vực
			if (Find_node(kv) != null)
				return false;

			// trường hợp tồn tại ngày nhưng không có mã khu vực
			XmlNode thoitiet = doc.SelectSingleNode($"//thoitiet[@ngay = '{kv.ngay}']");
			if (thoitiet != null)
			{
				XmlElement khuvuc = doc.CreateElement("khuvuc");
				khuvuc.SetAttribute("ma", kv.ma);
				XmlElement kieuthoitiet = doc.CreateElement("kieuthoitiet");
				kieuthoitiet.InnerText = kv.kieutt;
				XmlElement nhietdocaonhat = doc.CreateElement("nhietdocaonhat");
				nhietdocaonhat.InnerText = kv.ndmax.ToString();
				XmlElement nhietdothapnhat = doc.CreateElement("nhietdothapnhat");
				nhietdothapnhat.InnerText = kv.ndmin.ToString();

				khuvuc.AppendChild(kieuthoitiet);
				khuvuc.AppendChild(nhietdocaonhat);
				khuvuc.AppendChild(nhietdothapnhat);
				thoitiet.AppendChild(khuvuc);
				doc.Save(filename);
			}
			else // trường hợp không tồn tại ngày  
			{
				XmlElement new_thoitiet = doc.CreateElement("thoitiet");
				new_thoitiet.SetAttribute("ngay", kv.ngay);
				XmlElement khuvuc = doc.CreateElement("khuvuc");
				khuvuc.SetAttribute("ma", kv.ma);
				XmlElement kieuthoitiet = doc.CreateElement("kieuthoitiet");
				kieuthoitiet.InnerText = kv.kieutt;
				XmlElement nhietdocaonhat = doc.CreateElement("nhietdocaonhat");
				nhietdocaonhat.InnerText = kv.ndmax.ToString();
				XmlElement nhietdothapnhat = doc.CreateElement("nhietdothapnhat");
				nhietdothapnhat.InnerText = kv.ndmin.ToString();

				khuvuc.AppendChild(kieuthoitiet);
				khuvuc.AppendChild(nhietdocaonhat);
				khuvuc.AppendChild(nhietdothapnhat);
				new_thoitiet.AppendChild(khuvuc);
				root.AppendChild(new_thoitiet);
				doc.Save(filename);
			}
			return true;
		}

		public bool Delete_kv(Khuvuc kv)
		{
			XmlNode node = Find_node(kv);
			if (node != null)
			{
				XmlNode thoitiet = node.ParentNode;
				thoitiet.RemoveChild(node);
				doc.Save(filename);
				return true;
			}
			return false;
		}

		public List<Khuvuc> Get_by_ngay(string ngay)
		{
			List<Khuvuc> kv_lst = new List<Khuvuc>();
			XmlNodeList nodes = doc.SelectNodes($"//thoitiet[@ngay = '{ngay}']/khuvuc");
			foreach (XmlNode node in nodes)
			{
				Khuvuc kv = new Khuvuc();
				kv.ngay = node.ParentNode.Attributes["ngay"].Value;
				kv.ma = node.Attributes["ma"].Value;
				kv.kieutt = node["kieuthoitiet"].InnerText;
				kv.ndmax = double.Parse(node["nhietdocaonhat"].InnerText);
				kv.ndmin = double.Parse(node["nhietdothapnhat"].InnerText);
				kv_lst.Add(kv);
			}
			return kv_lst;
		}
    }
}
