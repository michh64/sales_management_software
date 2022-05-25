using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class KHO_HANG_DAL
    {
        public static List<KHO_HANG_DTO> EF_GetAll()
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            var truyvan = data.Select_kho();
            List<KHO_HANG_DTO> dsKho = new List<KHO_HANG_DTO>();
            foreach (var s in truyvan)
            {
                KHO_HANG_DTO ks = new KHO_HANG_DTO();
                ks.makho = s.makho;
                ks.deleted = (Boolean)s.deleted;
                ks.soluongtonkho=(int)s.soluongtonkho;
                dsKho.Add(ks);
            }

            return dsKho;
        }
    }
}
