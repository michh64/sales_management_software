using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class NHAN_VIEN_DAL
    {
        public static List<NHAN_VIEN_DTO> EF_GetAll()
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            var truyvan = data.select_nv().ToList();
            List<NHAN_VIEN_DTO> dsNV = new List<NHAN_VIEN_DTO>();
            foreach (var s in truyvan)
            {
                NHAN_VIEN_DTO dp = new NHAN_VIEN_DTO();
                dp.manv = s.manv;
                dp.matkhau = s.matkhau;
                dp.hotennv = s.hotennv;
                dp.sdt = s.sdt;
                dp.diachi = s.diachi;
                dp.deleted = (bool)s.deleted;
                dsNV.Add(dp);
            }
            return dsNV;
        }

    }
}
