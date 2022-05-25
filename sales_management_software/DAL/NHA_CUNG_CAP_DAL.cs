using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class NHA_CUNG_CAP_DAL
    {
        public static List<NHA_CUNG_CAP_DTO> EF_GetAll()
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            var truyvan = data.Select_ncc();
            List<NHA_CUNG_CAP_DTO> dsLSP = new List<NHA_CUNG_CAP_DTO>();
            foreach (var s in truyvan)
            {
                NHA_CUNG_CAP_DTO ncc = new NHA_CUNG_CAP_DTO();
                ncc.tencty = s.tencty;
                ncc.maNCC = s.maNCC;
                dsLSP.Add(ncc);
            }

            return dsLSP;
        }
    }
}
