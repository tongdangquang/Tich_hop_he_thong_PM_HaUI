using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TongDangQuang_2022603783_proj63
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			XmlDocument doc = new XmlDocument();
			doc.Load("CongTy.xml");

			XmlNodeList nv_lst = doc.GetElementsByTagName("nhanvien");
			Console.WriteLine($"{"MA NV",-10}" +
					$"{"HO TEN",-20}" +
					$"{"TUOI",-10}" +
					$"{"LUONG",-10}" +
					$"{"DIA CHI",-40}" +
					$"{"DIEN THOAI",-20}");
			foreach (XmlNode nv in nv_lst)
			{
				XmlNode diachi = nv["diachi"];
				//XmlNode diachi = nv.SelectSingleNode("diachi");
				Console.WriteLine($"{nv.Attributes["manv"].Value, -10}" +
					$"{nv["hoten"].InnerText, -20}" +
					$"{nv["tuoi"].InnerText, -10}" +
					$"{nv["luong"].InnerText, -10}" +
					$"{diachi["xa"].InnerText + ", " + diachi["huyen"].InnerText + ", " + diachi["tinh"].InnerText, -40}" +
					$"{nv["dienthoai"].InnerText, -20}");
			}
		}
	}
}
