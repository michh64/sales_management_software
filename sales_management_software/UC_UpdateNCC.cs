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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void UC_UpdateNCC_Load(object sender, EventArgs e)
        {
            listNCC = NHA_CUNG_CAP_BLL.EF_GetAll();
            cb_maNCC.DataSource= listNCC;
            cb_maNCC.ValueMember = "maNCC";
           dataGridView1.DataSource= listNCC;
            dataGridView1.ReadOnly = true;
        }

        private void btt_Udate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (cb_maNCC.Text != "" && txt_tencty.Text != "" && txt_diachi.Text != "" && txt_sdt.Text != "" )
                {
                    Sale_ManagementEntities data = new Sale_ManagementEntities();
                    string maNCC = cb_maNCC.SelectedValue.ToString().ToUpper();
                    string tencty = txt_tencty.Text;
                    string sdt = txt_sdt.Text;       
                    string diachi = txt_diachi.Text;
                    bool deleted = false;
                    data.Update_NCC(cb_maNCC.Text, tencty, diachi, sdt, deleted);
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
            else
            {
                MessageBox.Show("Update không thành công");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //cb_maNCC.SelectedValue = true;            
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                cb_maNCC.Text = row.Cells[0].Value.ToString();
                txt_tencty.Text = row.Cells[1].Value.ToString();
                txt_diachi.Text = row.Cells[2].Value.ToString();
                txt_sdt.Text = row.Cells[3].Value.ToString();            
                check1.Checked = Convert.ToBoolean(row.Cells[4].Value);
            }
        }
        private void txt_diachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = false;
               
            }
        }
        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải nhập số", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
