using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class DON_HANG_DAL
    {
        public static List<DON_HANG_DTO> EF_GetAll()
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();

            var truyvan = data.select_donhang();
            List<DON_HANG_DTO> dsLSP = new List<DON_HANG_DTO>();
            foreach (var s in truyvan)
            {
                DON_HANG_DTO ldp = new DON_HANG_DTO();
                ldp.madh = s.madh;
                ldp.makh = s.makh;
                ldp.ngaydat = (DateTime)s.ngaydat;
                ldp.ngaygiao = (DateTime) s.ngaygiao;
                ldp.diachigiao = s.diachigiao;
                ldp.deleted = (bool)s.deleted;
                ldp.masp = s.masp;
                ldp.tensp = s.tensp;
                ldp.dongia = (int)s.dongia;
                ldp.soluong = (int)s.soluong;
                dsLSP.Add(ldp);
            }

            return dsLSP;
        }
    }
}
