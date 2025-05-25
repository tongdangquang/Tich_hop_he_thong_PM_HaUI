using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace de7
{
    internal class DataUtil
    {
        string filename;
        XmlDocument doc;
        XmlElement root;
        public DataUtil()
        {
            filename = "../../sach.xml";
            doc = new XmlDocument();
            if (!File.Exists(filename))
            {
                XmlElement thuvien = doc.CreateElement("thuvien");
                doc.AppendChild(thuvien);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        }

        // lấy danh sách sách
        public List<Sach> Get_sach()
        {
            List<Sach> s_lst = new List<Sach>();
            XmlNodeList nodes = doc.SelectNodes("//sach");
            foreach (XmlNode node in nodes) 
            {
                Sach s = new Sach();
                s.ma = node.Attributes["masach"].Value;
                s.ten = node["tensach"].InnerText;
                s.sotrang = int.Parse(node["sotrang"].InnerText);
                XmlNode tacgia = node["tacgia"];
                s.hoten = tacgia.Attributes["hoten"].Value;
                s.diachi = tacgia["diachi"].InnerText;
                s_lst.Add(s);
            }
            return s_lst;
        }

        // tìm sách
        public XmlNode Find_sach(Sach s)
        {
            XmlNode node = doc.SelectSingleNode($"//sach[@masach = '{s.ma}']");
            if (node != null)
                return node;
            return null;
        }

        // thêm sách
        public bool Add_sach(Sach s)
        {
            if (Find_sach(s) == null)
            {
                XmlElement sach, tensach, sotrang, tacgia, diachi;
                sach = doc.CreateElement("sach"); sach.SetAttribute("masach", s.ma);
                tensach = doc.CreateElement("tensach"); tensach.InnerText = s.ten;
                sotrang = doc.CreateElement("sotrang"); sotrang.InnerText = s.sotrang.ToString();
                tacgia = doc.CreateElement("tacgia"); tacgia.SetAttribute("hoten", s.hoten);
                diachi = doc.CreateElement("diachi"); diachi.InnerText = s.diachi;

                tacgia.AppendChild(diachi);
                sach.AppendChild(tensach);
                sach.AppendChild(sotrang);
                sach.AppendChild(tacgia);

                root.AppendChild(sach);
                doc.Save(filename);
                return true;
            }
            return false;
        }

        // xóa sách
        public bool Delete_sach(Sach s)
        {
            XmlNode node = Find_sach(s);
            if (node != null)
            {
                root.RemoveChild(node);
                doc.Save(filename);
                return true;
            }    
            return false;
        }

        // tìm theo trang
        public List<Sach> Find_by_sotrang(int a, int b)
        {
            return Get_sach().Where(s => (a <= s.sotrang && s.sotrang <= b)).ToList();
        }
    }
}
