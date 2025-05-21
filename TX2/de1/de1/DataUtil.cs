using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace de1
{
	internal class DataUtil
	{
		string filename;
		XmlDocument doc;
		XmlElement root;

		public DataUtil()
		{
			filename = "BangGiaXe.xml";
			doc = new XmlDocument();
			if (!File.Exists(filename))
			{
				XmlElement banggiaxe = doc.CreateElement("banggiaxe");
				doc.AppendChild(banggiaxe);
				doc.Save(filename);
			}
			doc.Load(filename);
			root = doc.DocumentElement;
		}

		public List<Xe> Get_xe()
		{
			List<Xe> xe_lst = new List<Xe>();
			XmlNodeList nodes = doc.SelectNodes("//dongxe");

			foreach (XmlNode node in nodes)
			{
				Xe x = new Xe();
				x.tenhangxe = node.ParentNode.Attributes["ten"].Value;
				x.tendongxe = node.Attributes["ten"].Value;
				x.phienban = node["phienban"].InnerText;
				x.dongco = node["dongco"].InnerText;
				x.gia = int.Parse(node["gia"].InnerText);
				xe_lst.Add(x);
			}
			return xe_lst;
		}

		public XmlNode Find_xe(Xe x)
		{
			XmlNode xe = doc.SelectSingleNode($"/banggiaxe/hangxe[@ten = '{x.tenhangxe}']/dongxe[@ten = '{x.tendongxe}']");
			if (xe != null)
				return xe;
			return null;
		}

		public bool Add_xe(Xe x)
		{
			// trường hợp hãng xe và dòng xe đã tồn tại
			if (Find_xe(x) != null)
				return false;

			// trường hợp hãng xe tồn tại
			XmlNode th2 = doc.SelectSingleNode($"/banggiaxe/hangxe[@ten = '{x.tenhangxe}']");
			if (th2 != null)
			{
				XmlElement dongxe = doc.CreateElement("dongxe");
				dongxe.SetAttribute("ten", x.tendongxe);
				XmlElement phienban = doc.CreateElement("phienban");
				phienban.InnerText = x.phienban;
				XmlElement dongco = doc.CreateElement("dongco");
				dongco.InnerText = x.dongco;
				XmlElement gia = doc.CreateElement("gia");
				gia.InnerText = x.gia.ToString();

				dongxe.AppendChild(phienban);
				dongxe.AppendChild(dongco);
				dongxe.AppendChild(gia);
				th2.AppendChild(dongxe);

				doc.Save(filename);
			}
			else // trường hợp hãng xe không tồn tại
			{
				XmlElement hangxe = doc.CreateElement("hangxe");
				hangxe.SetAttribute("ten", x.tenhangxe);
				XmlElement dongxe = doc.CreateElement("dongxe");
				dongxe.SetAttribute("ten", x.tendongxe);
				XmlElement phienban = doc.CreateElement("phienban");
				phienban.InnerText = x.phienban;
				XmlElement dongco = doc.CreateElement("dongco");
				dongco.InnerText = x.dongco;
				XmlElement gia = doc.CreateElement("gia");
				gia.InnerText = x.gia.ToString();

				dongxe.AppendChild(phienban);
				dongxe.AppendChild(dongco);
				dongxe.AppendChild(gia);
				hangxe.AppendChild(dongxe);
				root.AppendChild(hangxe);

				doc.Save(filename);
			}
			return true;
		}

		public bool Delete_xe(Xe x)
		{
			XmlNode xe = Find_xe(x);
			if (xe != null)
			{
				XmlNode hangxe = xe.ParentNode;
				hangxe.RemoveChild(xe);
				doc.Save(filename);
				return true;
			}
			return false;
		}

		public List<Xe> Get_by_hangxe(string tenhangxe)
		{
			List<Xe> xe_lst = new List<Xe>();
			XmlNodeList nodes = doc.SelectNodes($"//hangxe[@ten = '{tenhangxe}']/dongxe");
			foreach (XmlNode node in nodes)
			{
				Xe x = new Xe();
				x.tenhangxe = node.ParentNode.Attributes["ten"].Value;
				x.tendongxe = node.Attributes["ten"].Value;
				x.phienban = node["phienban"].InnerText;
				x.dongco = node["dongco"].InnerText;
				x.gia = int.Parse(node["gia"].InnerText);
				xe_lst.Add(x);
			}
			return xe_lst;
		}
	}
}
