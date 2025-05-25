using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();

        private void Display(List<Sach> s_lst)
        {
            dgv.DataSource = s_lst;
            dgv.Columns["masach"].HeaderText = "Mã sách";
            dgv.Columns["tensach"].HeaderText = "Tên sách";
            dgv.Columns["sotrang"].HeaderText = "Số trang";
            dgv.Columns["hoten"].HeaderText = "Tác giả";
            dgv.Columns["diachi"].HeaderText = "Địa chỉ";
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgv.Columns[0].Width = 140;
            dgv.Columns[1].Width = 140;
            dgv.Columns[2].Width = 140;
            dgv.Columns[3].Width = 140;
            dgv.Columns[4].Width = 140;
            
            if (s_lst.Count == 0)
                MessageBox.Show("Không có dữ liệu!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Clear()
        {
            txt_masach.Text = string.Empty;
            txt_tensach.Text = string.Empty;
            txt_sotrang.Text = string.Empty;
            txt_hoten.Text = string.Empty;
            txt_diachi.Text = string.Empty;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sach s = dgv.CurrentRow.DataBoundItem as Sach;
            txt_masach.Text = s.masach;
            txt_tensach.Text = s.tensach;
            txt_sotrang.Text = s.sotrang.ToString();
            txt_hoten.Text = s.hoten;
            txt_diachi.Text = s.diachi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display(data.Get_sach());
        }

        private bool Check_data()
        {
            if (txt_masach.Text == "" || txt_tensach.Text == "" || txt_sotrang.Text == "" ||
                txt_hoten.Text == "" || txt_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu trước khi thêm!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }    
            return true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (Check_data())
            {

                Sach s = new Sach();
                s.masach = txt_masach.Text;
                s.tensach = txt_tensach.Text;
                s.sotrang = int.Parse(txt_sotrang.Text);
                s.hoten = txt_hoten.Text;
                s.diachi = txt_diachi.Text;
                if (data.Add_sach(s))
                {
                    MessageBox.Show("Thêm thông tin sách thành công!", "Thêm",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    Display(data.Get_sach());
                }
                else
                    MessageBox.Show("Thông tin đã tồn tại!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (Check_data())
            {
                DialogResult r = MessageBox.Show("Bạn chắc chắn muốn xóa cuốn sách này?", "Xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Sach s = new Sach();
                    s.masach = txt_masach.Text;
                    s.tensach = txt_tensach.Text;
                    s.sotrang = int.Parse(txt_sotrang.Text);
                    s.hoten = txt_hoten.Text;
                    s.diachi = txt_diachi.Text;
                    if (data.Delete_sach(s))
                    {
                        MessageBox.Show("Xóa thông tin sách thành công!", "Xóa",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        Display(data.Get_sach());
                    }    
                    else
                        MessageBox.Show("Thông tin không tồn tại!", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }    
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (Check_data())
            {
                Sach s = new Sach();
                s.masach = txt_masach.Text;
                s.tensach = txt_tensach.Text;
                s.sotrang = int.Parse(txt_sotrang.Text);
                s.hoten = txt_hoten.Text;
                s.diachi = txt_diachi.Text;
                if (data.Update_sach(s))
                {
                    MessageBox.Show("Sửa thông tin sách thành công!", "Sửa",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    Display(data.Get_sach());
                }
                else
                    MessageBox.Show("Thông tin không tồn tại!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
