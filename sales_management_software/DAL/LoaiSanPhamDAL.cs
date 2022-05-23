using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class LoaiSanPhamDAL
    {
        public static List<LoaiSanPhamDTO> EF_GetAll()
        {
            QLBH_techEntities1 data = new QLBH_techEntities1();
            var truyvan = data.lsp_Select();
            List<LoaiSanPhamDTO> dsLSP = new List<LoaiSanPhamDTO>();
            foreach (var s in truyvan)
            {
                LoaiSanPhamDTO ldp = new LoaiSanPhamDTO();
                ldp.MaLSP = s.MaLSP;
                ldp.TenLSP = s.TenLSP;
                dsLSP.Add(ldp);
            }

            return dsLSP;
        }
    }
}
