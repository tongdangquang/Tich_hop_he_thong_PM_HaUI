using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TongDangQuang_2022603783;

namespace TongDangQuang_2022603783_proj71
{
	internal class DataUtil
	{
		XmlDocument doc;
		XmlElement root;
		string filename;

        public DataUtil()
        {
			filename = "Nganhang.xml";
            doc = new XmlDocument();
			if (!File.Exists(filename))
			{
				XmlElement nganhang = doc.CreateElement("nganhang");
				doc.AppendChild(nganhang);
				doc.Save(filename);
			}
			doc.Load(filename);
			root = doc.DocumentElement;
        }

		public List<Taikhoan> GetTaiKhoan()
		{
			List<Taikhoan> tk_lst = new List<Taikhoan>();
			XmlNodeList nodes = root.SelectNodes("taikhoan");
			foreach (XmlNode node in nodes)
			{
				Taikhoan tk = new Taikhoan();
				tk.sotaikhoan = node["sotaikhoan"].InnerText;
				tk.tentaikhoan = node["tentaikhoan"].InnerText;
				tk.diachi = node["diachi"].InnerText;
				tk.dienthoai = node["dienthoai"].InnerText;
				tk.sotien = node["sotien"].InnerText;
				tk_lst.Add(tk);
			}
			return tk_lst;
		}

		public Taikhoan Tim_kiem(string stk)
		{
			Taikhoan t = GetTaiKhoan().Find(tk => tk.sotaikhoan == stk);
			if (t != null)
				return t;
			return null;
		}

		public bool Them(Taikhoan t)
		{
			if (Tim_kiem(t.sotaikhoan) == null)
			{
				XmlElement tk = doc.CreateElement("taikhoan");

				XmlElement stk = doc.CreateElement("sotaikhoan");
				stk.InnerText = t.sotaikhoan;

				XmlElement ttk = doc.CreateElement("tentaikhoan");
				ttk.InnerText = t.tentaikhoan;

				XmlElement dc = doc.CreateElement("diachi");
				dc.InnerText = t.diachi;

				XmlElement dt = doc.CreateElement("dienthoai");
				dt.InnerText = t.dienthoai;

				XmlElement st = doc.CreateElement("sotien");
				st.InnerText = t.sotien;

				tk.AppendChild(stk);
				tk.AppendChild(ttk);
				tk.AppendChild(dc);
				tk.AppendChild(dt);
				tk.AppendChild(st);
				root.AppendChild(tk);

				doc.Save(filename);
				return true;
			}
			return false;
		}

		public bool Capnhat(Taikhoan t)
		{
			XmlNode old_taikhoan = doc.SelectSingleNode($"/nganhang/taikhoan[sotaikhoan = '{t.sotaikhoan}']");
			if (new_taikhoan != null)
			{
				XmlElement tk = doc.CreateElement("taikhoan");

				XmlElement stk = doc.CreateElement("sotaikhoan");
				stk.InnerText = t.sotaikhoan;

				XmlElement ttk = doc.CreateElement("tentaikhoan");
				ttk.InnerText = t.tentaikhoan;

				XmlElement dc = doc.CreateElement("diachi");
				dc.InnerText = t.diachi;

				XmlElement dt = doc.CreateElement("dienthoai");
				dt.InnerText = t.dienthoai;

				XmlElement st = doc.CreateElement("sotien");
				st.InnerText = t.sotien;

				tk.AppendChild(stk);
				tk.AppendChild(ttk);
				tk.AppendChild(dc);
				tk.AppendChild(dt);
				tk.AppendChild(st);
				root.ReplaceChild(tk, old_taikhoan);
				doc.Save(filename);
				return true;
			}
			return false;
		}

		public bool Xoa(Taikhoan t)
		{
			XmlNode tk = doc.SelectSingleNode($"/nganhang/taikhoan[sotaikhoan = '{t.sotaikhoan}']");
			if (tk != null)
			{
				root.RemoveChild(tk);
				doc.Save(filename);
				return true;
			}
			return false;
		}
    }
}
