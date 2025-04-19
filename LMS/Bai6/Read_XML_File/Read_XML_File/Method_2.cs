using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Read_XML_File
{
	internal class Method_2
	{
		// Đọc file với trường hợp không biết cấu trúc file XML
		public void Read_XML_2()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("CHƯƠNG TRÌNH ĐỌC FILE XML");
			XmlDocument doc = new XmlDocument();
			doc.Load("ThuVien.xml");

			XmlElement root = doc.DocumentElement;
			PrintNode(root);
		}

		public void PrintNode(XmlNode node)
		{
			Console.WriteLine($"{node.Name}: {node.Value}");
			XmlNodeList child_nodes = node.ChildNodes;
			if (child_nodes.Count > 0)
			{
				Console.WriteLine($"Mở node {node.Name}");
				foreach (XmlNode item in child_nodes)
				{
					PrintNode(item);
				}
				Console.WriteLine($"Đóng node {node.Name}");
				Console.WriteLine();
			}
		}

	}
}
