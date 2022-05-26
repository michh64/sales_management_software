using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace sales_management_software
{
    public partial class GUI : Form
    {
        public static GUI Instance;
        public TextBox check;
        //private Color mainBackColor = Color.DodgerBlue;
        //private Color mainForeColor = Color.White;

        public GUI()
        {
            InitializeComponent();
            Instance = this;
            check = textBox1;

            // Chạy thử một hàm để kết nối trước với Entity. Tăng tốc độ xử lý những hàm sau
            LOAI_SAN_PHAM_BLL.EF_GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void RemoveAllUserControl()
        {
            foreach (Control ctl in panel1.Controls)
            {
                panel1.Controls.Remove(ctl);
            }
        }


        public void DefaultFuncBtn(params Button[] btns )
        {
            for(int i=0;i<btns.Length;i++)
            {
                btns[i].BackColor = Color.DodgerBlue;
                btns[i].ForeColor = Color.White;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button1.Location.Y + 7);

            RemoveAllUserControl();
            UC_NhanVien uc = new UC_NhanVien();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button2.Location.Y + 7);
            RemoveAllUserControl();
            UC_KhachHang uc = new UC_KhachHang();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                panel3.Dock = DockStyle.None;
                panel3.Visible = false;
                button1_Click(sender, e);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel10.Location = new Point(panel10.Location.X, button8.Location.Y + 7);

            UC_Login uc = new UC_Login();
            uc.Dock = DockStyle.Fill;
            panel3.BringToFront();
            panel3.Controls.Add(uc);
            panel3.Dock = DockStyle.Fill;


        }
    }
}
