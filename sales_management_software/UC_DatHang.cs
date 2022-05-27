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
        List<KHACH_HANG_DTO> listKH;
        //List<NHAN_VIEN_DTO> listNV;
        public UC_DatHang()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSanPham.ReadOnly = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtMaSanPham.Text = row.Cells[0].Value.ToString();
                txttensanpham.Text = row.Cells[1].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();
            }
        }

        private void UC_DatHang_Load(object sender, EventArgs e)
        {
            KHACH_HANG_DTO kh = new KHACH_HANG_DTO();
            txtMaKhachHang.Text = kh.makh;
            listKH = KHACH_HANG_BLL.EF_GetAll();


            Showdata_gridview();
        }

        private void Showdata_gridview()
        {
            listSP = SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.Columns.Add("masp", "Mã sản phẩm");
            dataGridView1.Columns.Add("tensp", "Tên sản phẩm");
            dataGridView1.Columns.Add("dongia", "Đơn giá");
            dataGridView1.Columns.Add("soluong", "Số lượng");

            for (int i = 0; i < listSP.Count; i++)
            {
                dataGridView1.Rows.Add(listSP[i].masp, listSP[i].tensp, listSP[i].dongia, listSP[i].soluong);
            }
        }

        private void labelSoLuong_Click(object sender, EventArgs e)
        {

        }
    }
}
