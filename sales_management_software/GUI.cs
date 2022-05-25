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
        public int check = 0;
        //private Color mainBackColor = Color.DodgerBlue;
        //private Color mainForeColor = Color.White;

        public GUI()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            RemoveAllUserControl();
            UC_NhanVien uc = new UC_NhanVien();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveAllUserControl();
            UC_KhachHang uc = new UC_KhachHang();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_Login uc = new UC_Login();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
            panel3.Dock = DockStyle.Fill;

            Thread thrd = new Thread(LoginControl);
            thrd.IsBackground = true;
            thrd.Start();

        }

        void LoginControl()
        {
            while (check == 0)
            {
            }

            panel3.Dock = DockStyle.None;
            panel3.Visible = false;
        }    
    }
}
