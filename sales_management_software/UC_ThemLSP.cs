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
    public partial class UC_ThemLSP : UserControl
    {
        public UC_ThemLSP()
        {
            InitializeComponent();
        }
        List<LOAI_SAN_PHAM_DTO> listLSP;
        public void Reset()
        {
            txt_maloai.Text = "";
            txt_tenloai.Text = "";
            checkBox1.Checked = false;
        }

        private void UC_ThemLSP_Load(object sender, EventArgs e)
        {
            listLSP = LOAI_SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.DataSource = listLSP;
            dataGridView1.ReadOnly = true;
        }

        private void btt_luu_Click(object sender, EventArgs e)
        {
            string maloai = txt_maloai.Text;
            string tenloai = txt_tenloai.Text;
            bool check = false;
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            data.Insert_lsp(maloai, tenloai, check);
            data.SaveChanges();
            listLSP = LOAI_SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.DataSource = listLSP;
            Reset();
        }
    }
}
