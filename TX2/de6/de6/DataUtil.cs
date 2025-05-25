using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace de6
{
    internal class DataUtil
    {
        string filename;
        XmlDocument doc;
        XmlElement root;

        public DataUtil()
        {
            filename = "../../thuvien.xml";
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

        // lấy dữ liệu
        public List<Sach> Get_sach()
        {
            List<Sach> s_lst = new List<Sach>();
            XmlNodeList nodes = doc.SelectNodes("//sach");
            foreach (XmlNode node in nodes)
            {
                Sach s = new Sach();
                s.masach = node.Attributes["masach"].Value;
                s.tensach = node["tensach"].InnerText;
                s.sotrang = int.Parse(node["sotrang"].InnerText);
                XmlNode tacgia = node["tacgia"];
                s.hoten = tacgia["hoten"].InnerText;
                s.diachi = tacgia["diachi"].InnerText;
                s_lst.Add(s);
            } 
            return s_lst;
        }

        // tìm sách
        public XmlNode Find(Sach s)
        {
            XmlNode node = doc.SelectSingleNode($"//sach[@masach = '{s.masach}']");
            if (node != null)
                return node;
            return null;
        }

        // thêm sách
        public bool Add_sach(Sach s)
        {
            if (Find(s) == null)
            {
                XmlElement sach, tensach, sotrang, tacgia, hoten, diachi;

                sach = doc.CreateElement("sach");
                sach.SetAttribute("masach", s.masach);
                tensach = doc.CreateElement("tensach");
                tensach.InnerText = s.tensach;
                sotrang = doc.CreateElement("sotrang");
                sotrang.InnerText = s.sotrang.ToString();
                tacgia = doc.CreateElement("tacgia");
                hoten = doc.CreateElement("hoten");
                hoten.InnerText = s.hoten;
                diachi = doc.CreateElement("diachi");
                diachi.InnerText = s.diachi;

                tacgia.AppendChild(hoten);
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

        // sửa sách
        public bool Update_sach(Sach s)
        {
            XmlNode node = Find(s);
            if (node != null)
            {
                node["tensach"].InnerText = s.tensach;
                node["sotrang"].InnerText = s.sotrang.ToString();
                XmlNode tacgia = node["tacgia"];
                tacgia["hoten"].InnerText = s.hoten;
                tacgia["diachi"].InnerText = s.diachi;

                doc.Save(filename);
                return true;
            }
            return false;
        }

        // xoá sách
        public bool Delete_sach(Sach s)
        {
            XmlNode node = Find(s);
            if (node != null)
            {
                root.RemoveChild(node);
                return true;
            }
            return false;
        }
    }
}
