using System;
using System.Xml;

namespace Read_XML_File
{
	internal class Method_1
	{
		// Đọc file với trường hợp đã biết cấu trúc file XML
		public void Read_XML_1()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("CHƯƠNG TRÌNH ĐỌC FILE XML");

			XmlDocument doc = new XmlDocument();
			doc.Load("ThuVien.xml");
			XmlElement root = doc.DocumentElement;
			XmlNodeList lst = root.SelectNodes("cuonsach");
			Console.WriteLine($"Danh sách có {lst.Count} cuốn sách:");
			for (int i = 0; i < lst.Count; i++)
			{
				Console.WriteLine($"\nCuốn sách thứ {i + 1}");
				Console.WriteLine($"Tên sách  : {lst[i].SelectSingleNode("tensach").InnerText}");
				Console.WriteLine($"Số trang  : {lst[i].SelectSingleNode("sotrang").InnerText}");
				Console.WriteLine($"Tác giả	  : {lst[i].SelectSingleNode("tacgia/hoten").InnerText}");
				Console.WriteLine($"Điện thoại: {lst[i].SelectSingleNode("tacgia/dienthoai").InnerText}");
				Console.WriteLine($"Giá tiền  : {lst[i].SelectSingleNode("giatien").InnerText}");
				Console.WriteLine("-----------------------------------------------");
			}
		}
	}
}