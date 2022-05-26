
namespace sales_management_software
{
    partial class UserControl_KhachHang
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.txtNhapTuKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(618, 50);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(114, 157);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(96, 23);
            this.btnDatHang.TabIndex = 11;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(354, 157);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(106, 23);
            this.btnThanhToan.TabIndex = 12;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Location = new System.Drawing.Point(584, 157);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(129, 23);
            this.btnXuatHoaDon.TabIndex = 13;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLichSu
            // 
            this.btnLichSu.Location = new System.Drawing.Point(813, 157);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(144, 23);
            this.btnLichSu.TabIndex = 14;
            this.btnLichSu.Text = "Lịch sử mua hàng";
            this.btnLichSu.UseVisualStyleBackColor = true;
            // 
            // txtNhapTuKhoa
            // 
            this.txtNhapTuKhoa.Location = new System.Drawing.Point(426, 50);
            this.txtNhapTuKhoa.Name = "txtNhapTuKhoa";
            this.txtNhapTuKhoa.Size = new System.Drawing.Size(171, 22);
            this.txtNhapTuKhoa.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nhập từ khóa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 286);
            this.dataGridView1.TabIndex = 17;
            // 
            // UserControl_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNhapTuKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLichSu);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "UserControl_KhachHang";
            this.Size = new System.Drawing.Size(1019, 544);
            this.Load += new System.EventHandler(this.UserControl_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.TextBox txtNhapTuKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
