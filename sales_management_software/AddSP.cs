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
    public partial class AddSP : Form
    {
        List<SAN_PHAM_DTO> listsp;
        public AddSP()
        {
            InitializeComponent();
        }

        private void btt_Luu_Click(object sender, EventArgs e)
        {
            int countrow = dataGridView1.Rows.Count;
            
            // Lấy giá trị mã sản phẩm cuối cùng
            string value = Convert.ToString(dataGridView1.Rows[countrow - 1].Cells[0].Value);

            // Lấy chỉ số của sản phẩm cuối
            int index = Convert.ToInt32(value.Remove(0, 2)) + 1;

            txt_masp.Text = "SP" + index.ToString("000");
            MessageBox.Show(txt_masp.Text);

            //them sp
            string masp = txt_masp.Text;
            string tensp=txt_tensp.Text;
            int dongia = int.Parse(txt_dongia.Text);
            int soluong=int.Parse(txt_soluong.Text);
            string ncc = txt_ncc.Text.ToUpper();
            string maloai = txt_maloai.Text.ToUpper();
            bool check = false;
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            data.Insert_sp(masp,tensp,dongia,soluong,ncc,maloai,check);
            data.SaveChanges();
            listsp = SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.DataSource = listsp;
            Reset();
        }
        public void Reset()
        {
            txt_masp.Text = "";
            txt_tensp.Text = "";
            txt_dongia.Text = "";
            txt_soluong.Text = "";
            txt_ncc.Text = "";
            txt_maloai.Text = "";
            checkBox1.Checked = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            List<SAN_PHAM_DTO> listsanpham;
            listsanpham = SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.DataSource = listsanpham;
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
