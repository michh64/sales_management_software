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
    public partial class UC_KH : UserControl
    {
        public UC_KH()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        List<SAN_PHAM_DTO> list_sanpham;


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Sale_ManagementEntities sale = new Sale_ManagementEntities();
            string tukhoa = txtNhapTuKhoa.Text;
            dataGridView1.DataSource = sale.Search_sp(tukhoa);
        }


        private void UC_QL_KH_Load(object sender, EventArgs e)
        {
            list_sanpham = SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.DataSource = list_sanpham;
            dataGridView1.ReadOnly = true;
        }

    }
}
