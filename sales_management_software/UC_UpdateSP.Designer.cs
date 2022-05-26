namespace sales_management_software
{
    partial class UC_UpdateSP
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
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.btt_Udate = new System.Windows.Forms.Button();
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
            this.cb_maloai = new System.Windows.Forms.ComboBox();
            this.cb_mancc = new System.Windows.Forms.ComboBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(626, 96);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(100, 20);
            this.txt_soluong.TabIndex = 100;
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // btt_Udate
            // 
            this.btt_Udate.Location = new System.Drawing.Point(595, 211);
            this.btt_Udate.Name = "btt_Udate";
            this.btt_Udate.Size = new System.Drawing.Size(133, 23);
            this.btt_Udate.TabIndex = 99;
            this.btt_Udate.Text = "Update";
            this.btt_Udate.UseVisualStyleBackColor = true;
            this.btt_Udate.Click += new System.EventHandler(this.btt_Udate_Click);
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(362, 163);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(141, 20);
            this.txt_dongia.TabIndex = 98;
            this.txt_dongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dongia_KeyPress);
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(362, 128);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(141, 20);
            this.txt_tensp.TabIndex = 97;
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(362, 102);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.ReadOnly = true;
            this.txt_masp.Size = new System.Drawing.Size(141, 20);
            this.txt_masp.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "Số Lượng";
            // 
            // maloai
            // 
            this.maloai.AutoSize = true;
            this.maloai.Location = new System.Drawing.Point(559, 128);
            this.maloai.Name = "maloai";
            this.maloai.Size = new System.Drawing.Size(45, 13);
            this.maloai.TabIndex = 93;
            this.maloai.Text = "Mã Loại";
            // 
            // mancc
            // 
            this.mancc.AutoSize = true;
            this.mancc.Location = new System.Drawing.Point(559, 163);
            this.mancc.Name = "mancc";
            this.mancc.Size = new System.Drawing.Size(47, 13);
            this.mancc.TabIndex = 92;
            this.mancc.Text = "Mã NCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Mã sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 205);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cb_maloai
            // 
            this.cb_maloai.FormattingEnabled = true;
            this.cb_maloai.Location = new System.Drawing.Point(630, 125);
            this.cb_maloai.Name = "cb_maloai";
            this.cb_maloai.Size = new System.Drawing.Size(96, 21);
            this.cb_maloai.TabIndex = 104;
            // 
            // cb_mancc
            // 
            this.cb_mancc.FormattingEnabled = true;
            this.cb_mancc.Location = new System.Drawing.Point(630, 163);
            this.cb_mancc.Name = "cb_mancc";
            this.cb_mancc.Size = new System.Drawing.Size(96, 21);
            this.cb_mancc.TabIndex = 105;
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(362, 201);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(60, 17);
            this.check1.TabIndex = 106;
            this.check1.Text = "Đã xoá";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // UC_UpdateSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.check1);
            this.Controls.Add(this.cb_mancc);
            this.Controls.Add(this.cb_maloai);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.btt_Udate);
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
            this.Name = "UC_UpdateSP";
            this.Size = new System.Drawing.Size(1020, 620);
            this.Load += new System.EventHandler(this.UC_UpdateSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Button btt_Udate;
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
        private System.Windows.Forms.ComboBox cb_maloai;
        private System.Windows.Forms.ComboBox cb_mancc;
        private System.Windows.Forms.CheckBox check1;
    }
}
