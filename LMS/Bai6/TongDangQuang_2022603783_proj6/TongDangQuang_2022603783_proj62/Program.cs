using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TongDangQuang_2022603783_proj62
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			XmlDocument doc = new XmlDocument();
			doc.Load("SanPham.xml");

			XmlElement root = doc.DocumentElement;
			XmlNodeList sanpham_lst = root.SelectNodes("sanpham");

			//XmlNodeList sanpham_lst = doc.GetElementsByTagName("sanpham"); // có thể lấy ra danh sách sản phẩm bằng cách này
			Console.WriteLine($"{"MA SP",-10}{"TEN SP",-20}{"SO LUONG",-20}");
			foreach (XmlNode node in sanpham_lst)
			{
				Console.WriteLine($"{node["masp"].InnerText,-10}{node["tensp"].InnerText,-20}{node["soluong"].InnerText, -20}");
			}
		}
	}
}
