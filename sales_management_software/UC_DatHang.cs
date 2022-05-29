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
    public partial class UC_DatHang : UserControl
    {
        List<SAN_PHAM_DTO> listSP;

        public UC_DatHang()
        {
            InitializeComponent();
            dataGridViewDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDonHang.ReadOnly = true;
        }

        private void UC_DatHang_Load(object sender, EventArgs e)
        {
            Showdata_gridview();
        }

        private void dataGridViewDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSanPham.ReadOnly = true;
                DataGridViewRow row = this.dataGridViewDonHang.Rows[e.RowIndex];
                txtMaSanPham.Text = row.Cells[0].Value.ToString();
                txtTenSanPham.Text = row.Cells[1].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();

                textBox1.Text = row.Cells[3].Value.ToString().Trim(); // Số lượng
                textBox2.Text = row.Cells[4].Value.ToString().Trim(); // mã NCC
                textBox3.Text = row.Cells[5].Value.ToString().Trim(); // mã loại
                textBox4.Text = row.Cells[6].Value.ToString().Trim(); // mã thông số
                textBox5.Text = row.Cells[7].Value.ToString().Trim(); // ảnh sản phẩm
            }

        }

        private void Showdata_gridview()
        {
            listSP = SAN_PHAM_BLL.EF_GetAll();
            dataGridViewDonHang.DataSource = listSP;
            dataGridViewDonHang.Columns["deleted"].Visible = false;
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) - int.Parse(txtSoLuong.Text) > 0)
            {

                List<DON_HANG_DTO> listdh = DON_HANG_BLL.EF_GetAll();
                // Lấy giá trị mã sản phẩm cuối cùng
                if (listdh.Count - 1 >= 0)
                {
                    string val = Convert.ToString(listdh[listdh.Count - 1].madh.ToString());
                    // Lấy chỉ số của sản phẩm cuối
                    int index = Convert.ToInt32(val.Remove(0, 2)) + 1;
                    txtMaDonHang.Text = "DH" + index.ToString("000");
                }
                else
                    txtMaDonHang.Text = "DH001";

                Sale_ManagementEntities data = new Sale_ManagementEntities();

                data.Insert_donhang(txtMaDonHang.Text, txtMaKhachHang.Text, dateTimePickerNgayDat.Value, dateTimePickerNgayGiao.Value,
                    txtDiaChiGiao.Text, false, txtMaSanPham.Text, txtTenSanPham.Text, int.Parse(txtDonGia.Text), int.Parse(txtSoLuong.Text));
                MessageBox.Show("Đã đặt hàng");

                data.Update_sp(txtMaSanPham.Text.Trim(), txtTenSanPham.Text, int.Parse(txtDonGia.Text), ( int.Parse(textBox1.Text) - int.Parse(txtSoLuong.Text) ),
                    textBox2.Text, textBox3.Text, false, textBox5.Text, textBox4.Text);
                data.SaveChanges();
                Showdata_gridview();
            }
        }

    }
}
