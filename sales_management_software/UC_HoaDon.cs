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
        List<HOA_DON_DTO> listHD;

        public UC_HoaDon()
        {
            InitializeComponent();
        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            //Showdata_Gridview();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void Showdata_Gridview()
        {
            listHD = HOA_DON_BLL.EF_GetAll();
            dataGridViewHoaDon.Columns.Add("mahd", "Mã hóa đơn");
            dataGridViewHoaDon.Columns.Add("masp", "Mã sản phẩm");
            dataGridViewHoaDon.Columns.Add("tensp", "Tên sản phẩm");
            dataGridViewHoaDon.Columns.Add("dongia", "Đơn giá");
            dataGridViewHoaDon.Columns.Add("giamgia", "Giảm giá");
            dataGridViewHoaDon.Columns.Add("soluong", "Số lượng");
            dataGridViewHoaDon.Columns.Add("tongtien", "Thành tiền");

            for (int i = 0; i < listHD.Count; i++)
            {
                dataGridViewHoaDon.Rows.Add(listHD[i].mahd, listHD[i].masp, listHD[i].tensp, listHD[i].dongia, listHD[i].giamgia, listHD[i].soluong, listHD[i].tongtien);
            }
        }*/
    }
}
