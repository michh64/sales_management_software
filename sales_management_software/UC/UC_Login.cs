using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_management_software
{
    public partial class UC_Login : UserControl
    {
        public bool IsLogin { get; set; }

        List<NHAN_VIEN_DTO> dsNV = NHAN_VIEN_BLL.EF_GetAll();
        public UC_Login()
        {
            InitializeComponent();
            CountWrong = 0;

            label1.Visible = true;
            label4.Visible = false;
            button1.Text = "Người dùng nội bộ";
        }

        static int CountWrong = 0;

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Visible == true)
            {

                foreach (var nv in dsNV)
                {
                    if (textBox2.Text == nv.manv && textBox3.Text == nv.matkhau)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        GUI.Instance.check.Text = "02";
                        IsLogin = true;
                    }
                }

                if (IsLogin == false)
                {
                    if (CountWrong == 2)
                    {
                        MessageBox.Show("Bạn đã nhập sai 3 lần liên tiếp!");
                        GUI.Instance.check.Text = "03";
                    }
                    else
                    {
                        CountWrong++;
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                        textBox2.Text = "";
                        textBox3.Text = "";
                    }
                }
            }
            else

            if ( (textBox2.Text == "quanli" || textBox2.Text == "quanly" ) && textBox3.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công");
                GUI.Instance.check.Text = "00";
                //IsLogin = true;
            }
            else
            
            if (textBox2.Text == "nhanvien" && textBox3.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công");
                GUI.Instance.check.Text = "01";
                //IsLogin = true;
            }
            else

            if (textBox2.Text == "khachhang" && textBox3.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công");
                GUI.Instance.check.Text = "02";
                //IsLogin = true;
            }
            else
            {
                if (CountWrong == 2)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần liên tiếp!");
                    GUI.Instance.check.Text = "03";
                }
                else
                {
                    CountWrong++;
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                    textBox2.Text = "";
                    textBox3.Text = "";
                }

            }
            
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button7_Click(sender, e);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox3.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Visible == false)
            {
                label1.Visible = true;
                label4.Visible = false;
                button1.Text = "Người dùng nội bộ";
            }
            else
            {
                label1.Visible = false;
                label4.Visible = true;
                button1.Text = "Khách hàng đăng nhập";
            }    
        }
    }
}
