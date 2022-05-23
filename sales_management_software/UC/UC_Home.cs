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
    public partial class UC_Home : UserControl
    {
        bool selected = false;
        List<Button> funcBtn = new List<Button>();


        public UC_Home()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            funcBtn.Add(button1);
            funcBtn.Add(button2);
            funcBtn.Add(button3);
            Form1 fm1 = new Form1();
            fm1.DefaultFuncBtn(funcBtn.ToArray());
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.handleClick(button1);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            handleClick(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            handleClick(button3);

        }
        private void handleClick(Button btn)
        {
            ClearClicked();
            if (!selected)
            {
                btn.BackColor = Color.Gray;

                selected = !selected;
            }
            else
            {
                btn.BackColor = Color.DodgerBlue;
                selected = !selected;

            }
        }
        private void ClearClicked()
        {
            foreach(Button btn in funcBtn)
            {
                if(btn.BackColor == Color.Gray)
                {
                    selected = !selected;
                    btn.BackColor = Color.DodgerBlue;
                }
            }
        }
        
    }
}
