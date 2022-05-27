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
            panel3.Visible = false;
            tabControl1.SelectedIndex = 3;
            button10_Click(sender, e);
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

            UC_ListSP uc = new UC_ListSP();
            ShowUCtoContent(uc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button2.Location.Y + 7);

            UC_KhachHang uc = new UC_KhachHang();
            ShowUCtoContent(uc);

        }

        // Check Transfer Data form other form
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "00")
            {
                panel3.Dock = DockStyle.None;
                panel3.SendToBack();
                panel3.Visible = false;

                button24_Click(sender, e);
                tabControl1.SelectedIndex = 0;
            }

            if (textBox1.Text == "01")
            {
                panel3.Dock = DockStyle.None;
                panel3.SendToBack();
                panel3.Visible = false;

                button1_Click(sender, e);
                tabControl1.SelectedIndex = 1;
            }

            if (textBox1.Text == "02")
            {
                panel3.Dock = DockStyle.None;
                panel3.SendToBack();
                panel3.Visible = false;

                button7_Click(sender, e);
                tabControl1.SelectedIndex = 2;
            }

            if (textBox1.Text == "03")
            {
                panel3.Dock = DockStyle.None;
                panel3.SendToBack();
                panel3.Visible = false;

                button10_Click(sender, e);
                tabControl1.SelectedIndex = 3;
            }

        }

        private void ShowUCtoContent (UserControl uc)
        {
            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }
        
        
        // button đăng nhâp
        private void button8_Click(object sender, EventArgs e)
        {
            panel10.Location = new Point(panel10.Location.X, button8.Location.Y + 7);

            textBox1.Text = "05";

            UC_Login uc = new UC_Login();

            uc.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Visible = true;
            panel3.BringToFront();
            panel3.Dock = DockStyle.Fill;

            panel3.Controls.Add(uc);


        }

        #region ClickButton
        private void button24_Click(object sender, EventArgs e)
        {
            panel12.Location = new Point(panel12.Location.X, button24.Location.Y + 7);

            UC_ListSP uc = new UC_ListSP();
            ShowUCtoContent(uc);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel12.Location = new Point(panel12.Location.X, button23.Location.Y + 7);

        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel12.Location = new Point(panel12.Location.X, button22.Location.Y + 7);

        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel12.Location = new Point(panel12.Location.X, button21.Location.Y + 7);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel12.Location = new Point(panel12.Location.X, button20.Location.Y + 7);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel12.Location = new Point(panel12.Location.X, button19.Location.Y + 7);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel12.Location = new Point(panel12.Location.X, button12.Location.Y + 7);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button15.Location.Y + 7);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button14.Location.Y + 7);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button13.Location.Y + 7);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel8.Location = new Point(panel8.Location.X, button7.Location.Y + 7);

            UC_ListSP uc = new UC_ListSP();
            ShowUCtoContent(uc);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel8.Location = new Point(panel8.Location.X, button6.Location.Y + 7);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel10.Location = new Point(panel10.Location.X, button10.Location.Y + 7);

            UC_ListSP uc = new UC_ListSP();
            ShowUCtoContent(uc);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel8.Location = new Point(panel8.Location.X, button5.Location.Y + 7);
            textBox1.Text = "03";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button3.Location.Y + 7);
            textBox1.Text = "03";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel12.Location = new Point(panel12.Location.X, button9.Location.Y + 7);
            textBox1.Text = "03";
        }
        #endregion

    }
}
