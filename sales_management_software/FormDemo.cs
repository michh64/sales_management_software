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
    public partial class FormDemo : Form
    {
        public FormDemo()
        {
            InitializeComponent();
        }

        private void FormDemo_Load(object sender, EventArgs e)
        {
           UC_UpdateNCC uc=new UC_UpdateNCC();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
