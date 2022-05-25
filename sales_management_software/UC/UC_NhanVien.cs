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
            funcBtn.Add(btt_themsp);
            funcBtn.Add(button2);
            funcBtn.Add(button3);
            GUI fm1 = new GUI();
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
            SAN_PHAM_DTO dto = new SAN_PHAM_DTO();
            dto.masp = txt_masp.Text;
            dto.dongia = int.Parse(txt_dongia.Text);
            dto.tensp = txt_tensp.Text;
            
        }
    }
}
