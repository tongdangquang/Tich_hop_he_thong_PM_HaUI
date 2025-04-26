using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DOM
{
	internal class Program
	{
		static string path = "ThuVien.xml";
		// Hiển thị file xml (đọc file xml)
		static void Hienthi(XmlDocument doc)
		{
			XmlElement root = doc.DocumentElement; // lấy ra phần tử gốc của xml bằng phương thức DocumentElement
			Console.WriteLine($"Thư viện: {root.GetAttribute("tentv")}"); // lấy thuộc tính của thẻ xml (GetAttribute() dùng cho XmlElement)

			XmlNodeList nhaxb_lst = root.SelectNodes("nhaxb");

			foreach (XmlNode nhaxb in nhaxb_lst)
			{
				Console.WriteLine($"\tTên nhà xuất bản: {nhaxb.Attributes["tennxb"].Value}"); // lấy ra thuộc tính của thẻ xml (Attributes[] dùng cho XmlNode)
				XmlNodeList sach_lst = nhaxb.SelectNodes("sach");

				Console.WriteLine($"\t{"MÃ SÁCH",-10}{"TÊN SÁCH",-30}{"THỂ LOẠI",-20}{"SỐ TRANG",-10}{"TÁC GIẢ",-20}{"ĐỊA CHỈ",-15}{"ĐIỆN THOẠI",-15}");
				foreach (XmlNode sach in sach_lst)
				{
					XmlNode tacgia = sach["tacgia"];
					Console.WriteLine($"\t{sach.Attributes["masach"].Value, -10}" +
						$"{sach["tensach"].InnerText,-30}" +
						$"{sach["theloai"].InnerText,-20}" +
						$"{sach["sotrang"].InnerText,-10}" +
						$"{tacgia["hoten"].InnerText,-20}" +
						$"{tacgia["diachi"].InnerText,-15}" +
						$"{tacgia["dienthoai"].InnerText,-15}");
				}
				Console.WriteLine();
			}
		}

		// thêm
		static void Them(XmlDocument doc)
		{
			XmlElement root = doc.DocumentElement;

			Console.Write("Nhập tên nhà xuất bản: ");
			string tennxb = Console.ReadLine().Trim();
			XmlNode nhaxb = root.SelectSingleNode($"nhaxb[@tennxb = '{tennxb}']");
			if (nhaxb != null)
			{
				// nhập thông tin sách từ bàn phím
				Console.Write("Nhập mã sách: "); string masach = Console.ReadLine();
				Console.Write("Nhập tên sách: "); string tensach = Console.ReadLine();
				Console.Write("Nhập thể loại: "); string theloai = Console.ReadLine();
				Console.Write("Nhập số trang: "); string sotrang = Console.ReadLine();
				Console.Write("Nhập họ tên tác giả: "); string hoten = Console.ReadLine();
				Console.Write("Nhập địa chỉ: "); string diachi = Console.ReadLine();
				Console.Write("Nhập điện thoại: "); string dienthoai = Console.ReadLine();

				// tạo phần tử sách 
				XmlElement sach = doc.CreateElement("sach");
				sach.SetAttribute("masach", masach);
				XmlElement ten = doc.CreateElement("tensach");
				ten.InnerText = tensach;
				XmlElement tl = doc.CreateElement("theloai");
				tl.InnerText = theloai;
				XmlElement st = doc.CreateElement("sotrang");
				st.InnerText = sotrang;

				// tạo phần tử tác giả
				XmlElement tacgia = doc.CreateElement("tacgia");
				XmlElement ht = doc.CreateElement("hoten");
				ht.InnerText = hoten;
				XmlElement dc = doc.CreateElement("diachi");
				dc.InnerText = diachi;
				XmlElement dt = doc.CreateElement("dienthoai");
				dt.InnerText = dienthoai;

				// thêm các phần tử con vào thẻ <tacgia>
				tacgia.AppendChild(ht);
				tacgia.AppendChild(dc);
				tacgia.AppendChild(dt);

				// thêm các phần tử con vào thẻ <sach>
				sach.AppendChild(ten);
				sach.AppendChild(tl);
				sach.AppendChild(st);
				sach.AppendChild(tacgia);

				// thêm <sach> vào nhà xuất bản
				nhaxb.AppendChild(sach);

				doc.Save(path);

				Console.WriteLine("Thêm sách thành công!");
			}
			else
			{
				Console.WriteLine("Tên nhà xuất bản không tồn tại!");
			}
		}

		// sửa
		static void Sua(XmlDocument doc)
		{
			Console.Write("Nhập mã sách bạn muốn cập nhật: "); string ms = Console.ReadLine().Trim();
			XmlNode sach = doc.SelectSingleNode($"/TV/nhaxb/sach[@masach= '{ms}']");
			if (sach != null)
			{
				Console.Write("Nhập tên sách: "); string tensach = Console.ReadLine();
				Console.Write("Nhập thể loại: "); string theloai = Console.ReadLine();
				Console.Write("Nhập số trang: "); string sotrang = Console.ReadLine();
				Console.Write("Nhập họ tên tác giả: "); string hoten = Console.ReadLine();
				Console.Write("Nhập địa chỉ: "); string diachi = Console.ReadLine();
				Console.Write("Nhập điện thoại: "); string dienthoai = Console.ReadLine();

				sach.ChildNodes[0].InnerText = tensach;
				sach.ChildNodes[1].InnerText = theloai;
				sach.ChildNodes[2].InnerText = sotrang;
				sach.ChildNodes[3].ChildNodes[0].InnerText = hoten;
				sach.ChildNodes[3].ChildNodes[1].InnerText = diachi;
				sach.ChildNodes[3].ChildNodes[2].InnerText = dienthoai;

				Console.WriteLine($"Cập nhật thông tin sách {ms} thành công!");
			}
			else
			{
				Console.WriteLine("Mã sách không tồn tại!");
			}
		}

		// tìm kiếm
		static void Tim(XmlDocument doc)
		{
			Console.Write("Nhập mã sách bạn muốn tìm: "); string ms = Console.ReadLine().Trim();
			XmlNode sach = doc.SelectSingleNode($"/TV/nhaxb/sach[@masach='{ms}']");
			if (sach != null)
			{
				Console.WriteLine($"Thông tin cuốn sách có mã {ms}: ");
				Console.WriteLine($"Nhà xuất bản: {sach.ParentNode.Attributes["tennxb"].Value}");
				Console.WriteLine($"Mã sách     : {sach.Attributes["masach"].Value}");
				Console.WriteLine($"Tên sách    : {sach["tensach"].InnerText}");
				Console.WriteLine($"Thể loại    : {sach["theloai"].InnerText}");
				Console.WriteLine($"Số trang    : {sach["sotrang"].InnerText}");
				Console.WriteLine($"Tác giả     : ");
				XmlNode tacgia = sach["tacgia"];
				Console.WriteLine($"\tHọ tên    : {tacgia["hoten"].InnerText}"); 
				Console.WriteLine($"\tĐịa chỉ   : {tacgia["diachi"].InnerText}");
				Console.WriteLine($"\tĐiện thoại: {tacgia["dienthoai"].InnerText}");
			}
			else
			{
				Console.WriteLine("Mã sách không tồn tại!");
			}
		}

		// xóa 
		static void Xoa(XmlDocument doc)
		{
			Console.Write("Nhập mã sách bạn muốn xóa: "); string ms = Console.ReadLine().Trim();
			XmlNode sach = doc.SelectSingleNode($"/TV/nhaxb/sach[@masach='{ms}']");
			if (sach != null)
			{
				XmlNode nhaxb = sach.ParentNode;
				nhaxb.RemoveChild(sach);
				doc.Save(path);
				Console.WriteLine($"Xóa cuốn sách có mã {ms} thành công!");
			}
			else
			{
				Console.WriteLine("Mã sách không tồn tại!");
			}
		}

		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			XmlDocument doc = new XmlDocument(); // tạo đối tượng DOM
			doc.Load(path); // tải file xml lên chương trình

			while (true)
			{
				Console.WriteLine("QUẢN LÝ THƯ VIỆN");
				Console.WriteLine("1. Xem thư viện");
				Console.WriteLine("2. Thêm sách vào thư viện");
				Console.WriteLine("3. Cập nhật thông tin sách");
				Console.WriteLine("4. Tìm kiếm sách");
				Console.WriteLine("5. Xóa sách");
				Console.WriteLine("6. Thoát");
				Console.Write("\nNhập lựa chọn của bạn: "); string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						Hienthi(doc);
						Console.WriteLine("=========================================");
						break;
					case "2":
						Them(doc);
						Console.WriteLine("=========================================");
						break;
					case "3":
						Sua(doc);
						Console.WriteLine("=========================================");
						break;
					case "4":
						Tim(doc);
						Console.WriteLine("=========================================");
						break;
					case "5":
						Xoa(doc);
						Console.WriteLine("=========================================");
						break;
				}
				if (choice == "6")
					break;
			}
		}
	}
}
