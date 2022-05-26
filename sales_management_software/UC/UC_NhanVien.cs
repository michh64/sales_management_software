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
    public partial class UC_NhanVien : UserControl
    {
        List<SAN_PHAM_DTO> listsanpham;
        List<LOAI_SAN_PHAM_DTO> listLSP;
        List<NHA_CUNG_CAP_DTO> lisNCC;

        public UC_NhanVien()
        {
            InitializeComponent();
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            //sanpham
            listsanpham = SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.DataSource = listsanpham;
            //loaisp
            listLSP = LOAI_SAN_PHAM_BLL.EF_GetAll();
            cb_maloai.DataSource = listLSP;
            cb_maloai.DisplayMember = "tenloai";
            cb_maloai.ValueMember = "maloai";
            //nhacungcap
            lisNCC = NHA_CUNG_CAP_BLL.EF_GetAll();
            cb_mancc.DataSource= lisNCC;
            cb_mancc.DisplayMember = "tencty";
            cb_mancc.ValueMember = "maNCC";

        }

        private void btt_Luu_Click(object sender, EventArgs e)
        {
            SAN_PHAM_DTO dto = new SAN_PHAM_DTO();
            dto.masp = txt_masp.Text;
            dto.dongia = int.Parse(txt_dongia.Text);
            dto.tensp = txt_tensp.Text;
            
        }
    }
}
