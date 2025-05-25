using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace de5
{
	internal class DataUtil
	{
		string filename;
		XmlDocument doc;
		XmlElement root;

		public DataUtil()
		{
			filename = "../../BaiHat.xml";
			doc = new XmlDocument();
			if (!File.Exists(filename))
			{
				XmlElement amnhac = doc.CreateElement("amnhac");
				doc.AppendChild(amnhac);
				doc.Save(filename);
			}
			doc.Load(filename);
			root = doc.DocumentElement;
		}

		public List<Baihat> Get_bh()
		{
			List<Baihat> bh_lst = new List<Baihat>();
			XmlNodeList nodes = doc.SelectNodes("//baihat");
			foreach (XmlNode node in nodes)
			{
				Baihat bh = new Baihat();
				bh.mabai = node.Attributes["mabai"].Value;
				bh.theloai = node.Attributes["theloai"].Value;
				bh.tenbai = node["tenbai"].InnerText;
				bh.casi = node["casi"].InnerText;
				bh.tacgia = node["tacgia"].InnerText;
				bh_lst.Add(bh);
			}
			return bh_lst;
		}

		public XmlNode Find(Baihat bh)
		{
			XmlNode node = doc.SelectSingleNode($"//baihat[@mabai = '{bh.mabai}']");
			if (node != null)
				return node;
			return null;
		}

		public bool Add_bh(Baihat bh)
		{
			if (Find(bh) == null)
			{
				XmlElement baihat, tenbai, casi, tacgia;

				baihat = doc.CreateElement("baihat");
				baihat.SetAttribute("mabai", bh.mabai);
				baihat.SetAttribute("theloai", bh.theloai);
				tenbai = doc.CreateElement("tenbai");
				tenbai.InnerText = bh.tenbai;
				casi = doc.CreateElement("casi");
				casi.InnerText = bh.casi;
				tacgia = doc.CreateElement("tacgia");
				tacgia.InnerText = bh.tacgia;

				baihat.AppendChild(tenbai);
				baihat.AppendChild(casi);
				baihat.AppendChild(tacgia);
				root.AppendChild(baihat);
				doc.Save(filename);
				return true;
			}
			return false;
		}

		public bool Update_bh(Baihat bh)
		{
			XmlNode node = Find(bh);
			if (node != null)
			{
				node.Attributes["theloai"].Value = bh.theloai;
				node["tenbai"].InnerText = bh.tenbai;
				node["casi"].InnerText = bh.casi;
				node["tacgia"].InnerText = bh.tacgia;
				doc.Save(filename);
				return true;
			}
			return false;
		}

		public bool Delete_bh(Baihat bh)
		{
			XmlNode node = Find(bh);
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
