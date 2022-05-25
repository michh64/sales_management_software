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
            var truyvan = data.Select_nv().ToList();
            List<SAN_PHAM_DTO> dsSP = new List<SAN_PHAM_DTO>();
            foreach (var s in truyvan)
            {
                SAN_PHAM_DTO dp = new SAN_PHAM_DTO();
                dp.masp = s.masp;
                dp.tensp = s.tensp;
                dp.dongia = (int)s.dongia;
                dp.maNCC = s.maNCC;
                dp.maloai = s.maloai;
                dp.soluong = (int)s.soluong;
                dp.deleted = (bool)s.deleted;
                dsSP.Add(dp);
            }
            return dsSP;
        }

    }
}
