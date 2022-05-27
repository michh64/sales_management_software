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

        List<KHACH_HANG_DTO> dsKH = KHACH_HANG_BLL.EF_GetAll();
        List<QUAN_LY_DTO> dsQL = QUAN_LY_BLL.EF_GetAll();


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
            string usernametxt = textBox2.Text;
            string passwordtxt = textBox3.Text;
            textBox2.Text = "";
            textBox3.Text = "";

            // khách
            if (label1.Visible == true)
            {
                for (int i = 0; i < dsKH.Count; i++)
                {
                    if (usernametxt == dsKH[i].username && passwordtxt == dsKH[i].password)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        GUI.Instance.accKhachHang = dsKH[i];
                        GUI.Instance.check.Text = "02";
                        return;
                    }
                }
            }
            // quản lý
            else
            {
                for (int i = 0; i < dsQL.Count; i++)
                {
                    if (usernametxt == dsQL[i].username && passwordtxt == dsQL[i].pass)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        GUI.Instance.accQuanLy = dsQL[i];
                        GUI.Instance.check.Text = "01";
                        return;
                    }
                }

            }

            // Nhập sai
            if (CountWrong == 2)
            {
                MessageBox.Show("Bạn đã nhập sai 3 lần liên tiếp!");
                GUI.Instance.check.Text = "03";
            }
            else
            {
                CountWrong++;
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
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

        private void button2_Click(object sender, EventArgs e)
        {
            GUI.Instance.check.Text = "03";
        }
    }
}
