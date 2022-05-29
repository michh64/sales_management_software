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
    public partial class UC_QL_KH : UserControl
    {
        public UC_QL_KH()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        List<KHACH_HANG_DTO> listKH;

        private void UC_QL_KH_Load(object sender, EventArgs e)
        {
            Showdata_gridview();
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_makh.ReadOnly = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_makh.Text = row.Cells[0].Value.ToString();
                txt_tenkh.Text = row.Cells[1].Value.ToString();
                txt_sdt.Text = row.Cells[2].Value.ToString();
                txt_diachi.Text = row.Cells[3].Value.ToString();
                textBox1.Text = row.Cells[5].Value.ToString();
                textBox2.Text = row.Cells[6].Value.ToString();
            }

        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            string MAKH = txt_makh.Text;
            string TENKH = txt_tenkh.Text;
            string SDT = txt_sdt.Text;
            string DIACHI = txt_diachi.Text;
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool check = false;
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            data.Insert_kh(MAKH, TENKH, SDT, DIACHI, check, username, password);
            data.SaveChanges();
            listKH = KHACH_HANG_BLL.EF_GetAll();
            dataGridView1.DataSource = listKH;
        }

        private void btt_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (txt_makh.Text != "" && txt_tenkh.Text != "" && txt_sdt.Text != "" && txt_diachi.Text != "")
                {
                    Sale_ManagementEntities data = new Sale_ManagementEntities();
                    string makh = txt_makh.Text;
                    string tenkh = txt_tenkh.Text;
                    string sdt = txt_sdt.Text;
                    string diachi = txt_diachi.Text;
                    string username = textBox1.Text;
                    string password = textBox2.Text;

                    bool check = false;
                    data.Update_kh(makh, tenkh, sdt, diachi, check, username, password);
                    data.SaveChanges();
                    listKH = KHACH_HANG_BLL.EF_GetAll();
                    dataGridView1.DataSource = listKH;
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

        private void btt_xoa_Click(object sender, EventArgs e)
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            SAN_PHAM_DTO sp = new SAN_PHAM_DTO();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (txt_makh.Text != "" && txt_tenkh.Text != "" && txt_sdt.Text != "" && txt_diachi.Text != "")
                {
                    string makh = txt_makh.Text;
                    string tenkh = txt_tenkh.Text;
                    string sdt = txt_sdt.Text;
                    string diachi = txt_diachi.Text;
                    string username = textBox1.Text;
                    string password = textBox2.Text;
                    data.Update_kh(makh, tenkh, sdt, diachi, true, username, password);
                    data.SaveChanges();
                    Showdata_gridview();
                    MessageBox.Show("Xoá thành công");
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Xoá không thành công");

            }
        }

        private void Showdata_gridview()
        {
            listKH = KHACH_HANG_BLL.EF_GetAll();
            dataGridView1.DataSource = listKH;
            dataGridView1.Columns["deleted"].Visible = false;
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Sale_ManagementEntities sale = new Sale_ManagementEntities();
            string tukhoa = txtNhapTuKhoa.Text;
            dataGridView1.DataSource = sale.Search_kh(tukhoa);
        }


    }
}
