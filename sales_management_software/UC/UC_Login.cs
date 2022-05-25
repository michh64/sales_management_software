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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var nv in dsNV)
            {
                if(textBox2.Text == nv.manv && textBox3.Text == nv.matkhau)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    GUI.Instance.check = 1;
                    IsLogin = true;
                }
            }

            if (IsLogin == false)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
        }
    }
}
