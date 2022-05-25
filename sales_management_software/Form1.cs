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
    public partial class Form1 : Form
    {
        private Color mainBackColor = Color.DodgerBlue;
        private Color mainForeColor = Color.White;
        public Form1()
        {
            InitializeComponent();
        }
        // Click
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultColorMenuItem();
            this.SelectedMenuItem(homeToolStripMenuItem);
            //
            RemoveAllUserControl();
            UC_Home uc = new UC_Home();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
            homeToolStripMenuItem.BackColor = Color.Gray;
        }
        
        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultColorMenuItem();
            this.SelectedMenuItem(nhanVienToolStripMenuItem);
            //
            RemoveAllUserControl();
            UC_NhanVien uc = new UC_NhanVien();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);

        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultColorMenuItem();
            this.SelectedMenuItem(khachHangToolStripMenuItem);


            RemoveAllUserControl();
            UC_KhachHang uc = new UC_KhachHang();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);

        }
        private void RemoveAllUserControl()
        {
            foreach (Control ctl in panel1.Controls)
            {
                panel1.Controls.Remove(ctl);
            }
        }
        private void DefaultColorMenuItem()
        {
            foreach (ToolStripMenuItem itm in menuStrip1.Items)
            {
                if(itm.BackColor != Color.White) 
                {
                    itm.BackColor = Color.White;
                }
            }
        }
        private void SelectedMenuItem(ToolStripMenuItem itm)
        {
            itm.BackColor = Color.Gray;
        }
        public static void SelectedFuncBtn(Button btn)
        {
            btn.BackColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);


           
        }
        public void DefaultFuncBtn(params Button[] btns )
        {
            for(int i=0;i<btns.Length;i++)
            {
                btns[i].BackColor = Color.DodgerBlue;
                btns[i].ForeColor = Color.White;
            }
            
        }
       


    }
}
