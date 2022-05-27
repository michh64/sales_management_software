
namespace sales_management_software
{
    partial class UC_Report
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Danh sách tất cả sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Danh sách sản phẩm theo loại";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Danh sách sản phẩm theo group";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // UC_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UC_Report";
            this.Size = new System.Drawing.Size(973, 628);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
