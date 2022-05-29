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
    public partial class UC_QL_NCC : UserControl
    {
        List<NHA_CUNG_CAP_DTO> listNCC;

        public UC_QL_NCC()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void UC_QL_NCC_Load(object sender, EventArgs e)
        {
            Showdata_gridview();
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(button1.Location.X, panel2.Location.Y);

            txt_maNCC.Enabled = true;
            txt_tencty.Enabled = true;
            txt_sdt.Enabled = true;
            txt_diachi.Enabled = true;

            button4.Text = "Thêm nhà cung cấp";
            Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(button2.Location.X, panel2.Location.Y);

            txt_maNCC.Enabled = true;
            txt_tencty.Enabled = true;
            txt_sdt.Enabled = true;
            txt_diachi.Enabled = true;

            button4.Text = "Sửa nhà cung cấp";
            Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(button3.Location.X, panel2.Location.Y);

            txt_maNCC.Enabled =  false;
            txt_tencty.Enabled = false;
            txt_sdt.Enabled =    false;
            txt_diachi.Enabled = false;

            button4.Text = "Xóa nhà cung cấp";
            Reset();

        }

        public void Reset()
        {
            txt_maNCC.Text = "";
            txt_tencty.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
        }

        private void Showdata_gridview()
        {
            listNCC = NHA_CUNG_CAP_BLL.EF_GetAll();
            dataGridView1.DataSource = listNCC;
            dataGridView1.Columns["deleted"].Visible = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && panel2.Location.X != button1.Location.X)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_maNCC.Text = row.Cells[0].Value.ToString();
                txt_tencty.Text = row.Cells[1].Value.ToString();
                txt_diachi.Text = row.Cells[2].Value.ToString();
                txt_sdt.Text = row.Cells[3].Value.ToString();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();

            // Thêm
            if (panel2.Location.X == button1.Location.X)
            {
                if (txt_maNCC.Text != "" && txt_tencty.Text != "" && txt_diachi.Text != "" && txt_sdt.Text != "")
                {
                    //thêm nhà cung cấp
                    string maNCC = txt_maNCC.Text;
                    string tencty = txt_tencty.Text;
                    string diachi = txt_diachi.Text;
                    string sdt = txt_sdt.Text;

                    data.Insert_ncc(maNCC, tencty, diachi, sdt, false);

                    data.SaveChanges();

                    Showdata_gridview();
                    Reset();
                }
            }

            // Sửa NCC
            if (panel2.Location.X == button2.Location.X)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (txt_maNCC.Text != "" && txt_tencty.Text != "" && txt_diachi.Text != "" && txt_sdt.Text != "")
                    {
                        string maNCC = txt_maNCC.Text.ToUpper();
                        string tencty = txt_tencty.Text;
                        string sdt = txt_sdt.Text;
                        string diachi = txt_diachi.Text;

                        data.Update_ncc(txt_maNCC.Text, tencty, diachi, sdt, false);
                        data.SaveChanges();

                        Showdata_gridview();
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

            if (panel2.Location.X == button3.Location.X)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string maNCC = txt_maNCC.Text;
                    string tencty = txt_tencty.Text;
                    string sdt = txt_sdt.Text;
                    string diachi = txt_diachi.Text;
                    data.Update_ncc(maNCC, tencty, sdt, diachi, true);

                    data.SaveChanges();
                    Showdata_gridview();
                    MessageBox.Show("Xoá thành công");
                }
                else
                {
                    MessageBox.Show("Xoá không thành công");
                }
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Sale_ManagementEntities sale = new Sale_ManagementEntities();
            string tukhoa = txtNhapTuKhoa.Text;
            dataGridView1.DataSource = sale.Search_ncc(tukhoa);
        }


    }
}
