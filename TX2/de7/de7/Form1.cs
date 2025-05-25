using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de7
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
            dgv.Columns["ma"].HeaderText = "Mã sách";
            dgv.Columns["ten"].HeaderText = "Tên sách";
            dgv.Columns["sotrang"].HeaderText = "Số trang";
            dgv.Columns["hoten"].HeaderText = "Họ tên tác giả";
            dgv.Columns["diachi"].HeaderText = "Địa chỉ";

            dgv.Columns[0].Width = 130;
            dgv.Columns[1].Width = 150;
            dgv.Columns[2].Width = 150;
            dgv.Columns[3].Width = 150;
            dgv.Columns[4].Width = 150;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            if (s_lst.Count == 0)
                MessageBox.Show("Không có dữ liệu", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Clear()
        {
            txt_ma.Text = string.Empty;
            txt_ten.Text = string.Empty;
            txt_sotrang.Text = string.Empty;
            txt_hoten.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            txt_from.Text = string.Empty;
            txt_to.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sach s = dgv.CurrentRow.DataBoundItem as Sach;
            txt_ma.Text = s.ma;
            txt_ten.Text = s.ten;
            txt_sotrang.Text = s.sotrang.ToString();
            txt_hoten.Text = s.hoten;
            txt_diachi.Text = s.diachi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display(data.Get_sach());
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_ma.Text == "" || txt_ten.Text == "" || txt_sotrang.Text == "" ||
                txt_hoten.Text == "" || txt_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu trước khi thêm!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            
            try
            {
                Sach s = new Sach();
                s.ma = txt_ma.Text;
                s.ten = txt_ten.Text;
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
                    MessageBox.Show("Trùng mã sách!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu trước khi thêm!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_sotrang.Focus();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sách trước khi xóa!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin cuốn sách này?", "Xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Sach s = new Sach();
                s.ma = txt_ma.Text;
                s.ten = txt_ten.Text;
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
                    MessageBox.Show("Thông tin cuốn sách không tồn tại!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (txt_from.Text == "" || txt_to.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin trước khi tìm!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            try
            {
                int from = int.Parse(txt_from.Text);
                int to = int.Parse(txt_to.Text);
                List<Sach> s_lst = data.Find_by_sotrang(from, to);
                if (s_lst.Count > 0)
                {
                    Display(s_lst);
                    MessageBox.Show("Tìm thông tin sách thành công!", "Tìm",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
                else
                    MessageBox.Show("Không có dữ liệu!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu trước khi tìm!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
