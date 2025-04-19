using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DOM
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			XmlDocument doc = new XmlDocument();
			doc.Load("ThuVien.xml");

			XmlElement root = doc.DocumentElement;
			Console.WriteLine("Thư viện: " + root.GetAttribute("tentv"));

			XmlNode nhaxb = root.SelectSingleNode("nhaxb");
			Console.WriteLine("Nhà xuất bản: " + nhaxb.Attributes["tennxb"].Value);

			XmlNodeList sachList = nhaxb.SelectNodes("sach");
			foreach (XmlNode sach in sachList)
			{
				Console.WriteLine("\nMã sách: " + sach.Attributes["masach"].Value);
				Console.WriteLine("Tên sách: " + sach["tensach"].InnerText);
				Console.WriteLine("Thể loại: " + sach["theloai"].InnerText);
				Console.WriteLine("Số trang: " + sach["sotrang"].InnerText);
			}
		}
	}
}
