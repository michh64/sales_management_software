
namespace sales_management_software
{
    partial class UC_QL_KHACHANG
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btt_them = new System.Windows.Forms.Button();
            this.btt_sua = new System.Windows.Forms.Button();
            this.btt_xoa = new System.Windows.Forms.Button();
            this.btt_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Location = new System.Drawing.Point(58, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Khách Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btt_thoat);
            this.groupBox2.Controls.Add(this.btt_xoa);
            this.groupBox2.Controls.Add(this.btt_sua);
            this.groupBox2.Controls.Add(this.btt_them);
            this.groupBox2.Location = new System.Drawing.Point(58, 488);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 176);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(166, 55);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(186, 22);
            this.txt_makh.TabIndex = 0;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(166, 119);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(186, 22);
            this.txt_tenkh.TabIndex = 1;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(511, 52);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(186, 22);
            this.txt_sdt.TabIndex = 2;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(511, 122);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(186, 22);
            this.txt_diachi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đại chỉ:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(166, 172);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Đã xóa";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tồn tại";
            // 
            // btt_them
            // 
            this.btt_them.Location = new System.Drawing.Point(49, 33);
            this.btt_them.Name = "btt_them";
            this.btt_them.Size = new System.Drawing.Size(117, 29);
            this.btt_them.TabIndex = 0;
            this.btt_them.Text = "Thêm";
            this.btt_them.UseVisualStyleBackColor = true;
            this.btt_them.Click += new System.EventHandler(this.btt_them_Click);
            // 
            // btt_sua
            // 
            this.btt_sua.Location = new System.Drawing.Point(235, 33);
            this.btt_sua.Name = "btt_sua";
            this.btt_sua.Size = new System.Drawing.Size(117, 29);
            this.btt_sua.TabIndex = 1;
            this.btt_sua.Text = "Sửa";
            this.btt_sua.UseVisualStyleBackColor = true;
            this.btt_sua.Click += new System.EventHandler(this.btt_sua_Click);
            // 
            // btt_xoa
            // 
            this.btt_xoa.Location = new System.Drawing.Point(454, 33);
            this.btt_xoa.Name = "btt_xoa";
            this.btt_xoa.Size = new System.Drawing.Size(117, 29);
            this.btt_xoa.TabIndex = 2;
            this.btt_xoa.Text = "Xóa";
            this.btt_xoa.UseVisualStyleBackColor = true;
            // 
            // btt_thoat
            // 
            this.btt_thoat.Location = new System.Drawing.Point(642, 33);
            this.btt_thoat.Name = "btt_thoat";
            this.btt_thoat.Size = new System.Drawing.Size(117, 29);
            this.btt_thoat.TabIndex = 3;
            this.btt_thoat.Text = "Thoát";
            this.btt_thoat.UseVisualStyleBackColor = true;
            // 
            // UC_QL_KHACHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_QL_KHACHANG";
            this.Size = new System.Drawing.Size(956, 604);
            this.Load += new System.EventHandler(this.UC_QL_KHACHANG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btt_thoat;
        private System.Windows.Forms.Button btt_xoa;
        private System.Windows.Forms.Button btt_sua;
        private System.Windows.Forms.Button btt_them;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
