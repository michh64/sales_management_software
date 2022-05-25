using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class LOAI_SAN_PHAM_DAL
    {
        public static List<LOAI_SAN_PHAM_DTO> EF_GetAll()
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            var truyvan = data.Select_lsp();
            List<LOAI_SAN_PHAM_DTO> dsLSP = new List<LOAI_SAN_PHAM_DTO>();
            foreach (var s in truyvan)
            {
                LOAI_SAN_PHAM_DTO ldp = new LOAI_SAN_PHAM_DTO();
                ldp.maloai = s.maloai;
                ldp.tenloai = s.tenloai;
                dsLSP.Add(ldp);
            }

            return dsLSP;
        }
    }
}
