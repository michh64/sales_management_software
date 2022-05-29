using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sales_management_software
{
    public partial class UC_HoaDon : UserControl
    {
        List<DON_HANG_DTO> listDH;

        public UC_HoaDon()
        {
            InitializeComponent();
            dataGridViewHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHoaDon.ReadOnly = true;
        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            Showdata_gridview();
        }
        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtmasanpham.ReadOnly = true;
                DataGridViewRow row = this.dataGridViewHoaDon.Rows[e.RowIndex];
                txtmadonhang.Text = row.Cells[0].Value.ToString();
                txtmakhachhang.Text = row.Cells[1].Value.ToString();
                //dateTimePickerngaydat.Value = row.Cells[2].Value.ToString();
                txtmasanpham.Text = row.Cells[6].Value.ToString();
                txttensanpham.Text = row.Cells[7].Value.ToString();
                txtdongia.Text = row.Cells[8].Value.ToString();
                txtsoluong.Text = row.Cells[9].Value.ToString();
                txtgiamgia.Text = (int.Parse(txtdongia.Text) * int.Parse(txtsoluong.Text) / 10).ToString();
            }

        }


        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            List<HOA_DON_DTO> listhd = HOA_DON_BLL.EF_GetAll();
            // Lấy giá trị mã sản phẩm cuối cùng
            if (listhd.Count - 1 >= 0)
            {
                string val = Convert.ToString(listhd[listhd.Count - 1].mahd.ToString());
                // Lấy chỉ số của sản phẩm cuối
                int index = Convert.ToInt32(val.Remove(0, 2)) + 1;
                txtmahoadon.Text = "HD" + index.ToString("000");
            }
            else
                txtmahoadon.Text = "HD001";

            Sale_ManagementEntities data = new Sale_ManagementEntities();

            data.Insert_hoadon(txtmahoadon.Text, txtmasanpham.Text, txttensanpham.Text, int.Parse(txtdongia.Text), 
                int.Parse(txtgiamgia.Text), int.Parse(txtsoluong.Text), int.Parse(txtthanhtien.Text), false, txtmadonhang.Text, dateTimePickerngaydat.Value, txtmakhachhang.Text, txttenkhachhang.Text);
            MessageBox.Show("In hóa đơn thành công");
            data.SaveChanges();

            InHoaDon();
        }

        private void Showdata_gridview()
        {
            listDH = DON_HANG_BLL.EF_GetAll();
            dataGridViewHoaDon.DataSource = listDH;
            dataGridViewHoaDon.Columns["deleted"].Visible = false;
            dataGridViewHoaDon.Columns["diachigiao"].Visible = false;
            dataGridViewHoaDon.Columns["ngaygiao"].Visible = false;
        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            int temp = 0;
            if (int.TryParse(txtdongia.Text, out temp) == true && int.TryParse(txtgiamgia.Text, out temp) == true)
            {
                txtthanhtien.Text = (int.Parse(txtdongia.Text) * int.Parse(txtsoluong.Text) - int.Parse(txtgiamgia.Text)).ToString();
            }
            else
                txtthanhtien.Text = "Lỗi";
        }

        private void InHoaDon()
        {
            panel1.Dock = DockStyle.Fill;
            panel1.Visible = true;

            label19.Text = txtmakhachhang.Text;
            label8.Text = txttenkhachhang.Text;
            label20.Text = dateTimePickerngaydat.Value.ToString();

            label21.Text = txtmadonhang.Text;
            label22.Text = txtmahoadon.Text;

            label4.Text = txttensanpham.Text;
            label16.Text = txtdongia.Text + "đ";
            label6.Text = txtsoluong.Text;

            label16.TextAlign = ContentAlignment.MiddleCenter;
            label6.TextAlign = ContentAlignment.MiddleCenter;


            label24.Text = (int.Parse(txtthanhtien.Text) + int.Parse(txtgiamgia.Text)).ToString() + "đ";
            label17.Text = txtgiamgia.Text + "đ";
            label15.Text = txtthanhtien.Text + "đ";
            
            label24.TextAlign = ContentAlignment.MiddleRight;
            label17.TextAlign = ContentAlignment.MiddleRight;
            label15.TextAlign = ContentAlignment.MiddleRight;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.None;
            panel1.Visible = false;
        }
    }
}
