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
    public partial class FormCungCap : Form
    {
        //tinlam
        List<NHA_CUNG_CAP_DTO> listNCC;
        public FormCungCap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //thêm nhà cung cấp
            string maNCC = txt_maNCC.Text;
            string tencty = txt_tencty.Text;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            bool check = false;
            Sale_ManagementEntities data =new Sale_ManagementEntities();
            data.Insert_ncc(maNCC, tencty, diachi, sdt, check);
            data.SaveChanges();
            listNCC = NHA_CUNG_CAP_BLL.EF_GetAll();
            dataGridView1.DataSource = listNCC;
            Reset();
        }
        public void Reset()
        {
            txt_maNCC.Text = "";
            txt_tencty.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            checkBox1.Checked = false;
        }
        private void FormCungCap_Load(object sender, EventArgs e)
        {
            listNCC = NHA_CUNG_CAP_BLL.EF_GetAll();
            dataGridView1.DataSource = listNCC;
        }
    }
}
