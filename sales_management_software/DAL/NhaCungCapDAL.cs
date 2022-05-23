using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class NhaCungCapDAL
    {
        public static List<NhaCungCapDTO> EF_GetAll()
        {
            QLBH_techEntities1 data = new QLBH_techEntities1();
            var truyvan = data.NC_NhaCC();
            List<NhaCungCapDTO> dsLSP = new List<NhaCungCapDTO>();
            foreach (var s in truyvan)
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO();
                ncc.TenCongTy = s.TenCongTy;
                ncc.MaNCC = s.MaNCC;
                dsLSP.Add(ncc);
            }

            return dsLSP;
        }
    }
}
