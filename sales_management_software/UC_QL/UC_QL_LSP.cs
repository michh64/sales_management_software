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
    public partial class UC_QL_LSP : UserControl
    {
        public UC_QL_LSP()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        List<LOAI_SAN_PHAM_DTO> listLSP;

        private void UC_QL_LSP_Load(object sender, EventArgs e)
        {
            Showdata_gridview();
            dataGridView1.ReadOnly = true;
        }

        private void Showdata_gridview()
        {
            listLSP = LOAI_SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.Columns.Add("maloai", "Mã loại");
            dataGridView1.Columns.Add("tensp", "Tên loại");

            for (int i = 0; i < listLSP.Count; i++)
            {
                dataGridView1.Rows.Add(listLSP[i].maloai, listLSP[i].tenloai);
            }
        }

        private void reset()
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(button1.Location.X, panel2.Location.Y);

            textBox2.Enabled = true;
            textBox1.Enabled = true;
            button4.Text = "Thêm loại sản phẩm";
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(button2.Location.X, panel2.Location.Y);

            textBox2.Enabled = true;
            textBox1.Enabled = true;
            button4.Text = "Sửa loại sản phẩm";
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(button3.Location.X, panel2.Location.Y);

            textBox2.Enabled = false;
            textBox1.Enabled = false;
            button4.Text = "Xóa loại sản phẩm";
            reset();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && panel2.Location.X != button1.Location.X)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            SAN_PHAM_DTO sp = new SAN_PHAM_DTO();

            // Thêm
            if (panel2.Location.X != button1.Location.X)
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    string maloai = textBox1.Text.ToString().ToUpper();
                    string tenloai = textBox2.Text;
                    data.Insert_lsp(maloai, tenloai, false);
                    data.SaveChanges();

                    Showdata_gridview();
                    reset();
                }
            }

            // Sửa
            if (panel2.Location.X != button2.Location.X)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        string maloai = textBox1.ToString().ToUpper();
                        string tenloai = textBox2.Text;

                        data.update_lsp(maloai, tenloai, false);
                        data.SaveChanges();

                        Showdata_gridview();
                        MessageBox.Show("Update thành công");
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập đầy đủ");
                    }
                }
                else
                {
                    MessageBox.Show("Update không thành công");

                }
            }

            // Xóa
            if (panel2.Location.X != button3.Location.X)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        string maloai = textBox1.Text;
                        string tenloai = textBox2.Text;
                        data.update_lsp(maloai, tenloai, true);
                        data.SaveChanges();
                        Showdata_gridview();
                        MessageBox.Show("Xoá thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập đầy đủ");
                    }
                }
                else
                {
                    MessageBox.Show("Xoá không thành công");

                }
            }


        }

    }

}
