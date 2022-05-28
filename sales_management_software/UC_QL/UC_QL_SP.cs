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
    public partial class UC_QL_SP : UserControl
    {
        public UC_QL_SP()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        List<SAN_PHAM_DTO> listsp;
        List<LOAI_SAN_PHAM_DTO> listLSP;
        List<NHA_CUNG_CAP_DTO> listNCC;
        List<THONG_SO_KY_THUAT_DTO> listTS;

        private void UC_QL_SP_Load(object sender, EventArgs e)
        {
            Showdata_gridview();
            //thongso
            LoadCombobox(comboBox1, 1);

            //loaisp
            LoadCombobox(comboBox2, 2);

            //nhacungcap
            LoadCombobox(comboBox3, 3);

            dataGridView1.ReadOnly = true;

            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
        }

        private void Showdata_gridview()
        {
            listsp = SAN_PHAM_BLL.EF_GetAll();
            dataGridView1.Columns.Add("masp", "Mã sản phẩm");
            dataGridView1.Columns.Add("tensp", "Tên sản phẩm");
            dataGridView1.Columns.Add("dongia", "Đơn giá");
            dataGridView1.Columns.Add("soluong", "Số lượng");
            dataGridView1.Columns.Add("maloai", "Mã loại");
            dataGridView1.Columns.Add("maNCC", "Mã nhà cung cấp");
            for (int i = 0; i < listsp.Count; i++)
            {
                dataGridView1.Rows.Add(listsp[i].masp, listsp[i].tensp, listsp[i].dongia, listsp[i].soluong, listsp[i].maloai, listsp[i].maNCC);
            }
            //dataGridView1.DataSource = listsp;
        }

        private void LoadCombobox (ComboBox cb, int type)
        {
            // tạm thơi
            if (type == 1)
            {
                listTS = THONG_SO_KY_THUAT_BLL.EF_GetAll();
                cb.DataSource = listTS;
                cb.DisplayMember = "mats";
                cb.ValueMember = "mats";
            }

            if (type == 2)
            {
                listLSP = LOAI_SAN_PHAM_BLL.EF_GetAll();
                cb.DataSource = listLSP;
                cb.DisplayMember = "tenloai";
                cb.ValueMember = "maloai";
            }
            if (type == 3)
            {
                listNCC = NHA_CUNG_CAP_BLL.EF_GetAll();
                cb.DataSource = listNCC;
                cb.DisplayMember = "tencty";
                cb.ValueMember = "maNCC";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();

            // sửa
            if (panel4.Location.X == button2.Location.X)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (textBox1.Text != "")
                    {
                        string tensp = textBox2.Text;
                        int dongia = int.Parse(textBox3.Text);
                        int soluong = int.Parse(textBox4.Text);
                        string mats = comboBox1.SelectedValue.ToString().ToUpper();
                        string maloai = comboBox2.SelectedValue.ToString().ToUpper();
                        string maNCC = comboBox3.SelectedValue.ToString().ToUpper();
                        string anhsp = SpecFunctions.ImageToBase64(pictureBox1.Image);

                        data.Update_sp(textBox2.Text, tensp, dongia, soluong, maNCC, maloai, false, anhsp, mats);
                        data.SaveChanges();
                        listsp = SAN_PHAM_BLL.EF_GetAll();
                        dataGridView1.DataSource = listsp;
                        MessageBox.Show("Update thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập đầy đủ");
                    }
                }
                else
                {
                    MessageBox.Show("Update không thành công");

                }
            }
            //Thêm

            if (panel4.Location.X == button1.Location.X)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.SelectedValue.ToString() != "" && comboBox2.SelectedValue.ToString() != "" && comboBox3.SelectedValue.ToString() != "" && pictureBox1.Image != null)
                {                 
                    // Lấy giá trị mã sản phẩm cuối cùng
                    string value = Convert.ToString(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value);

                    // Lấy chỉ số của sản phẩm cuối
                    int index = Convert.ToInt32(value.Remove(0, 2)) + 1;

                    textBox4.Text = "SP" + index.ToString("000");

                    //them sp
                    string masp = textBox4.Text;
                    string tensp = textBox3.Text;
                    int dongia = int.Parse(textBox2.Text);
                    int soluong = int.Parse(textBox1.Text);
                    string mats = comboBox1.Text.ToUpper();
                    string maloai = comboBox2.Text.ToUpper();
                    string ncc = comboBox3.Text.ToUpper();
                    string anhsp = SpecFunctions.ImageToBase64(pictureBox1.Image);
                    bool check = false;
                    data.Insert_sp(masp, tensp, dongia, soluong, ncc, maloai, check, anhsp, mats);
                    data.SaveChanges();

                    MessageBox.Show("Thêm sản phẩm thành công");

                    Showdata_gridview();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    pictureBox1.Image = null;
                }
            }
            //xóa
            if (panel4.Location.X == button3.Location.X)
            {
                SAN_PHAM_DTO sp = new SAN_PHAM_DTO();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (textBox1.Text != "")
                    {
                        string masp = textBox1.Text;
                        string tensp = textBox2.Text;
                        int dongia = int.Parse(textBox3.Text);
                        int soluong = int.Parse(textBox4.Text);
                        string mats = comboBox1.SelectedValue.ToString();
                        string maloai = comboBox2.SelectedValue.ToString();
                        string maNCC = comboBox3.SelectedValue.ToString();
                        string anhsp = SpecFunctions.ImageToBase64(pictureBox1.Image);

                        data.Update_sp(masp, tensp, dongia, soluong, maloai, maNCC, true, anhsp, mats);
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

        private void reset ()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(button1.Location.X, panel4.Location.Y); 

            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            pictureBox1.Enabled = true;
            button4.Text = "Thêm sản phẩm";
            reset();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(button2.Location.X, panel4.Location.Y);

            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            pictureBox1.Enabled = true;
            button4.Text = "Sửa sản phẩm";
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(button3.Location.X, panel4.Location.Y);

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            pictureBox1.Enabled = false;
            button4.Text = "Xóa sản phẩm";
            reset();
        }

        private void Noti(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải nhập số", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Noti(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            Noti(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Noti(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Noti(e);
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && panel4.Location.X != button1.Location.X)
            {
                //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //masp
                textBox1.Text = listsp[e.RowIndex].masp.ToString();

                //tensp
                textBox2.Text = listsp[e.RowIndex].tensp.ToString();

                //dongia
                textBox3.Text = listsp[e.RowIndex].dongia.ToString();

                // soluong
                textBox4.Text = listsp[e.RowIndex].soluong.ToString();

                // mats
                comboBox1.SelectedValue = listsp[e.RowIndex].mats;

                // maloai
                comboBox2.SelectedValue = listsp[e.RowIndex].maloai;

                // mancc
                comboBox3.SelectedValue = listsp[e.RowIndex].maNCC;

                // anhsp
                pictureBox1.Image = SpecFunctions.Base64toImage(listsp[e.RowIndex].anhsp);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn hình ảnh";
            ofd.Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                img = SpecFunctions.resizeImage(img, new Size(128, 128));
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

    }
}
