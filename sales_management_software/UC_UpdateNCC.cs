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

    public partial class UC_UpdateNCC : UserControl
    {
        List<NHA_CUNG_CAP_DTO> listNCC;
        public UC_UpdateNCC()
        {
            InitializeComponent();
        }

        private void UC_UpdateNCC_Load(object sender, EventArgs e)
        {
            listNCC = NHA_CUNG_CAP_DAL.EF_GetAll();
            cb_maNCC.DataSource = listNCC;
            cb_maNCC.DisplayMember = "tencty";
            cb_maNCC.ValueMember = "maNCC";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (cb_maNCC.SelectedValue.ToString() != "" && cb_maloai.SelectedValue.ToString() != "")
                {
                    Sale_ManagementEntities data = new Sale_ManagementEntities();
                    string maNCC = cb_maNCC.SelectedValue.ToString().ToUpper();
                    string maloai = cb_maloai.SelectedValue.ToString().ToUpper();
                    bool deleted = false;
                    data.Update_NCC(maNCC, maloai, deleted);
                    data.SaveChanges();
                    listNCC = NHA_CUNG_CAP_BLL.EF_GetAll();
                    dataGridView1.DataSource = listNCC;
                    MessageBox.Show("Update thành công");
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
    }
}
