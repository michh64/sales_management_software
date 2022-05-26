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
    public partial class Uc_QL_KHACHHANG : UserControl
    {
        List<KHACH_HANG_DTO> listKH;
        public Uc_QL_KHACHHANG()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Uc_QL_KHACHHANG_Load(object sender, EventArgs e)
        {
            listKH = KHACH_HANG_BLL.EF_GetAll();
            dataGridView1.DataSource = listKH;
        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            string MAKH = txt_makh.Text;
            string TENKH = txt_tenkh.Text;
            string SDT = txt_sdt.Text;
            string DIACHI = txt_diachi.Text;
            bool check = false;
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            data.Insert_KhacHang(MAKH, TENKH, SDT, DIACHI, check);
            data.SaveChanges();
            listKH = KHACH_HANG_BLL.EF_GetAll();
            dataGridView1.DataSource = listKH;
        }

        private void btt_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (txt_makh.Text != "" && txt_tenkh.Text != "" && txt_sdt.Text!="" && txt_diachi.Text!="")
                {
                    Sale_ManagementEntities data = new Sale_ManagementEntities();
                    string makh = txt_makh.Text;
                    string tenkh = txt_tenkh.Text;
                    string sdt = txt_sdt.Text;
                    string diachi = txt_diachi.Text;
                    bool deleted = false;
                    data.Update_KHACHHANG(makh ,tenkh, sdt, diachi, deleted);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_makh.ReadOnly = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_makh.Text = row.Cells[0].Value.ToString();
                txt_tenkh.Text = row.Cells[1].Value.ToString();
                txt_sdt.Text = row.Cells[2].Value.ToString();
                txt_diachi.Text = row.Cells[3].Value.ToString();
                checkBox1.Checked = Convert.ToBoolean(row.Cells[4].Value);


            }
        }
    }
}
