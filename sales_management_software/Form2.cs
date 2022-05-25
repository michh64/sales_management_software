﻿using System;
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
        List<SAN_PHAM_DTO> list;
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
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
            {
                txt_maloai.Text = "SP00" + (chuoi2 + 1).ToString();

            }
            else if (chuoi2 + 1 < 100)
            {
                txt_maloai.Text = "SP0" + (chuoi2 + 1).ToString();
            }
            SAN_PHAM_DTO sp = new SAN_PHAM_DTO(txt_masp.Text, txt_tensp.Text, int.Parse(txt_dongia.Text),int.Parse(txt_soluong.Text),txt_ncc.Text, txt_maloai.Text, checkBox1.Checked);
            bool s = SAN_PHAM_BLL.EF_AddNew(sp);
            if (s == false)
            {
                MessageBox.Show("Them thanh cong");

            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            list = SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.DataSource = list;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<SAN_PHAM_DTO> listsanpham;
            listsanpham = SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.DataSource = listsanpham;
        }
    }
}