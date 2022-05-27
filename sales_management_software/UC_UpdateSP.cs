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
    public partial class UC_UpdateSP : UserControl
    {
        List<SAN_PHAM_DTO> listsp;
        List<LOAI_SAN_PHAM_DTO> listLSP;
        List<NHA_CUNG_CAP_DTO> lisNCC;
        public UC_UpdateSP()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void UC_UpdateSP_Load(object sender, EventArgs e)
        {
            listsp = SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.DataSource = listsp;
            //loaisp
            listLSP = LOAI_SAN_PHAM_BLL.EF_GetAll();
            cb_maloai.DataSource = listLSP;
            cb_maloai.DisplayMember = "tenloai";
            cb_maloai.ValueMember = "maloai";
            //nhacungcap
            lisNCC = NHA_CUNG_CAP_BLL.EF_GetAll();
            cb_mancc.DataSource = lisNCC;
            cb_mancc.DisplayMember = "tencty";
            cb_mancc.ValueMember = "maNCC";
            dataGridView1.ReadOnly = true;
        }

        private void btt_Udate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (txt_masp.Text != "" && txt_tensp.Text != "" && txt_dongia.Text != "" && txt_soluong.Text != "" && cb_mancc.SelectedValue.ToString() != "" && cb_maloai.SelectedValue.ToString() != "")
                {
                    Sale_ManagementEntities data = new Sale_ManagementEntities();
                    string tensp = txt_tensp.Text;
                    int dongia = int.Parse(txt_dongia.Text);
                    int soluong = int.Parse(txt_soluong.Text);
                    string maNCC = cb_mancc.SelectedValue.ToString().ToUpper();
                    string maloai = cb_maloai.SelectedValue.ToString().ToUpper();
                    bool deleted = false;
                    data.Update_sp(txt_masp.Text, tensp, dongia, soluong, maNCC, maloai, deleted);
                    data.SaveChanges();
                    listsp = SAN_PHAM_BLL.EF_GetAll();
                    dataGridView1.DataSource = listsp;
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
                txt_masp.ReadOnly = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_masp.Text = row.Cells[0].Value.ToString();
                txt_tensp.Text = row.Cells[1].Value.ToString();
                txt_dongia.Text = row.Cells[2].Value.ToString();
                txt_soluong.Text = row.Cells[3].Value.ToString();
                cb_mancc.SelectedValue = row.Cells[4].Value.ToString();
                cb_maloai.SelectedValue = row.Cells[5].Value.ToString();
                check1.Checked = Convert.ToBoolean(row.Cells[6].Value);


            }
        }

        private void txt_dongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải nhập số", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải nhập số", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
