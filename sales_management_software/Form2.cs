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
    public partial class Form2 : Form
    {
        List<SAN_PHAM_DTO> listsp;
        public Form2()
        {
            InitializeComponent();
        }

        private void btt_Luu_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dataGridView1.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridView1.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                txt_masp.Text = "SP00" + (chuoi2 + 1).ToString();

            }
            else if (chuoi2 + 1 < 100)
            {
                txt_masp.Text = "SP0" + (chuoi2 + 1).ToString();
            }

            //them sp
            string masp = txt_masp.Text;
            string tensp=txt_tensp.Text;
            int dongia = int.Parse(txt_dongia.Text);
            int soluong=int.Parse(txt_soluong.Text);
            string ncc = txt_ncc.Text;
            string maloai = txt_maloai.Text;
            bool check = false;
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            data.Insert_sp(masp,tensp,dongia,soluong,ncc,maloai,check);
            data.SaveChanges();
            listsp = SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.DataSource = listsp;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<SAN_PHAM_DTO> listsanpham;
            listsanpham = SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.DataSource = listsanpham;
        }
    }
}
