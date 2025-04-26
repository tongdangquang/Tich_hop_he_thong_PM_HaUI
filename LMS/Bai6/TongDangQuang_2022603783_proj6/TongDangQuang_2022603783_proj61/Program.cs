using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TongDangQuang_2022603783_proj6
{
	internal class Program
	{
		// ghi file json
		static void WriteToFile(List<NhanVien> nv_lst, string filepath)
		{
			string json = JsonConvert.SerializeObject(nv_lst, Formatting.Indented);
			File.WriteAllText(filepath, json);
			Console.WriteLine("Ghi file thành công!");
		}

		// đọc file json
		static void ReadFromFile(string filepath)
		{
			if (!File.Exists(filepath))
			{
				Console.WriteLine("File không tồn tại!");
				return;
			}

			string json = File.ReadAllText(filepath);
			List<NhanVien> nv_lst = JsonConvert.DeserializeObject<List<NhanVien>>(json);
			Console.WriteLine("Danh sách nhân viên từ file: ");
			Console.WriteLine($"{"MÃ NV",-10}{"HỌ TÊN",-20}{"TUỔI",-10}{"ĐIỆN THOẠI",-15}{"LƯƠNG",-15}");
			foreach (NhanVien nv in nv_lst)
				Console.WriteLine($"{nv.manv,-10}{nv.hoten,-20}{nv.tuoi,-10}{nv.dienthoai,-15}{nv.luong,-15}");
		}

		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			string filepath = "nhanvien.json";
			List<NhanVien> nv_lst = new List<NhanVien>
			{
				new NhanVien{manv = "NV01", hoten = "Nguyễn Văn A", tuoi = 20, dienthoai = "012345", luong = 1000},
				new NhanVien{manv = "NV02", hoten = "Nguyễn Văn B", tuoi = 25, dienthoai = "012346", luong = 2000},
				new NhanVien{manv = "NV03", hoten = "Nguyễn Văn C", tuoi = 30, dienthoai = "012347", luong = 3000},
				new NhanVien{manv = "NV04", hoten = "Nguyễn Văn D", tuoi = 35, dienthoai = "012348", luong = 4000},
				new NhanVien{manv = "NV05", hoten = "Nguyễn Văn E", tuoi = 40, dienthoai = "012349", luong = 5000}
			};


			WriteToFile(nv_lst, filepath);

			ReadFromFile(filepath);
		}
	}
}
