using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sales_management_software.Rpt;

namespace sales_management_software
{
    public partial class UC_report : UserControl
    {
        List<SAN_PHAM_DTO> sp;
        List<LOAI_SAN_PHAM_DTO> lsp;

        public UC_report()
        {
            InitializeComponent();
        }

        private void UC_report_Load(object sender, EventArgs e)
        {
            lsp = LOAI_SAN_PHAM_BLL.EF_GetAll();
            comboBox1.DataSource = lsp;
            comboBox1.DisplayMember = "tenloai";
            comboBox1.ValueMember = "maloai";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(panel2.Location.X, button3.Location.Y + 38);

            sp = SAN_PHAM_BLL.EF_GetAll();
            Rpt_theoNhom rpt = new Rpt_theoNhom();
            rpt.SetDataSource(sp);

            FormReport frm = new FormReport();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(panel2.Location.X, button4.Location.Y + 38);

            sp = SAN_PHAM_BLL.EF_GetAllWithMaLoai(comboBox1.SelectedValue.ToString().Trim());
            Rpt_theoLoai rpt = new Rpt_theoLoai();
            rpt.SetDataSource(sp);
            rpt.SetParameterValue(0, (((LOAI_SAN_PHAM_DTO)comboBox1.SelectedItem).tenloai).ToString().ToUpper());

            FormReport frm = new FormReport();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(panel2.Location.X, button5.Location.Y + 38);

            sp = SAN_PHAM_BLL.EF_GetAll();
            Rpt_ALLsp rpt = new Rpt_ALLsp();
            rpt.SetDataSource(sp);

            FormReport frm = new FormReport();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();

        }


    }
}
