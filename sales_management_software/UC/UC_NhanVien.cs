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
        bool selected = false;
        List<Button> funcBtn = new List<Button>();
        List<SanPhamDTO> listsanpham;
        List<LoaiSanPhamDTO> listLSP;
        List<NhaCungCapDTO> lisNCC;
        List<KhoDTO> listKho;
        public UC_NhanVien()
        {
            InitializeComponent();
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            //sanpham
            listsanpham = SanPhamBLL.EF_GetAll();
            dataGridView1.DataSource = listsanpham;
            //loaisp
            listLSP = LoaiSanPhamBLL.EF_GetAll();
            cb_maloai.DataSource = listLSP;
            cb_maloai.DisplayMember = "TenLSP";
            cb_maloai.ValueMember = "MaLSP";
            //nhacungcap
            lisNCC = NhaCungCapBLL.EF_GetAll();
            cb_mancc.DataSource= lisNCC;
            cb_mancc.DisplayMember = "TenCongTy";
            cb_mancc.ValueMember = "MaNCC";
            //kho
            listKho = KhoBLL.EF_GetAll();
            cb_makho.DataSource = listKho;
            cb_makho.DisplayMember = "MaKho";
            cb_makho.ValueMember = "MaKho";
            funcBtn.Add(btt_themsp);
            funcBtn.Add(button2);
            funcBtn.Add(button3);
            Form1 fm1 = new Form1();
            fm1.DefaultFuncBtn(funcBtn.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.handleClick(btt_themsp);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            handleClick(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            handleClick(button3);

        }
        private void handleClick(Button btn)
        {
            ClearClicked();
            if (!selected)
            {
                btn.BackColor = Color.Gray;

                selected = !selected;
            }
            else
            {
                btn.BackColor = Color.DodgerBlue;
                selected = !selected;

            }
        }
        private void ClearClicked()
        {
            foreach (Button btn in funcBtn)
            {
                if (btn.BackColor == Color.Gray)
                {
                    selected = !selected;
                    btn.BackColor = Color.DodgerBlue;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btt_Luu_Click(object sender, EventArgs e)
        {
            SanPhamDTO dto = new SanPhamDTO();
            dto.MaSP = txt_masp.Text;
            dto.DonGia = txt_dongia.Text;
            dto.TenSP = txt_tensp.Text;
            
        }
    }
}
