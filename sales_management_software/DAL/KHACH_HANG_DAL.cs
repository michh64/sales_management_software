using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class KHACH_HANG_DAL
    {
        public static List<KHACH_HANG_DTO> EF_GetAll()
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            var truyvan = data.Select_KhachHang();
            List<KHACH_HANG_DTO> dsLSP = new List<KHACH_HANG_DTO>();
            foreach (var s in truyvan)
            {
                KHACH_HANG_DTO ldp = new KHACH_HANG_DTO();
                ldp.makh = s.makh;
                ldp.tenkh = s.tenkh;
                ldp.sdt = s.sdt;
                ldp.diachi = s.diachi;
                ldp.deleted = (bool)s.deleted;
                dsLSP.Add(ldp);
            }

            return dsLSP;
        }
    }
}
