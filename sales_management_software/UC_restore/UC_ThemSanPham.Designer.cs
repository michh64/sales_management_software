namespace sales_management_software
{
    partial class UC_ThemSanPham
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_ncc = new System.Windows.Forms.TextBox();
            this.txt_maloai = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.btt_Luu = new System.Windows.Forms.Button();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maloai = new System.Windows.Forms.Label();
            this.mancc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(358, 241);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 87;
            this.checkBox1.Text = "Đã xóa";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_ncc
            // 
            this.txt_ncc.Location = new System.Drawing.Point(626, 202);
            this.txt_ncc.Name = "txt_ncc";
            this.txt_ncc.Size = new System.Drawing.Size(100, 20);
            this.txt_ncc.TabIndex = 86;
            // 
            // txt_maloai
            // 
            this.txt_maloai.Location = new System.Drawing.Point(626, 171);
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Size = new System.Drawing.Size(100, 20);
            this.txt_maloai.TabIndex = 85;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(626, 140);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(100, 20);
            this.txt_soluong.TabIndex = 84;
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // btt_Luu
            // 
            this.btt_Luu.Location = new System.Drawing.Point(591, 250);
            this.btt_Luu.Name = "btt_Luu";
            this.btt_Luu.Size = new System.Drawing.Size(133, 23);
            this.btt_Luu.TabIndex = 83;
            this.btt_Luu.Text = "Lưu";
            this.btt_Luu.UseVisualStyleBackColor = true;
            this.btt_Luu.Click += new System.EventHandler(this.btt_Luu_Click);
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(358, 202);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(141, 20);
            this.txt_dongia.TabIndex = 82;
            this.txt_dongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dongia_KeyPress);
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(358, 167);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(141, 20);
            this.txt_tensp.TabIndex = 81;
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(358, 141);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.ReadOnly = true;
            this.txt_masp.Size = new System.Drawing.Size(141, 20);
            this.txt_masp.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Số Lượng";
            // 
            // maloai
            // 
            this.maloai.AutoSize = true;
            this.maloai.Location = new System.Drawing.Point(555, 167);
            this.maloai.Name = "maloai";
            this.maloai.Size = new System.Drawing.Size(45, 13);
            this.maloai.TabIndex = 77;
            this.maloai.Text = "Mã Loại";
            // 
            // mancc
            // 
            this.mancc.AutoSize = true;
            this.mancc.Location = new System.Drawing.Point(555, 202);
            this.mancc.Name = "mancc";
            this.mancc.Size = new System.Drawing.Size(47, 13);
            this.mancc.TabIndex = 76;
            this.mancc.Text = "Mã NCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Mã sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 205);
            this.dataGridView1.TabIndex = 73;
            // 
            // UC_ThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_ncc);
            this.Controls.Add(this.txt_maloai);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.btt_Luu);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maloai);
            this.Controls.Add(this.mancc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UC_ThemSanPham";
            this.Size = new System.Drawing.Size(1020, 620);
            this.Load += new System.EventHandler(this.UC_ThemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_ncc;
        private System.Windows.Forms.TextBox txt_maloai;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Button btt_Luu;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label maloai;
        private System.Windows.Forms.Label mancc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
