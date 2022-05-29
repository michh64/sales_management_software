using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class HOA_DON_DAL
    {
        public static List<HOA_DON_DTO> EF_GetAll()
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            var truyvan = data.select_hoadon();
            List<HOA_DON_DTO> dsLSP = new List<HOA_DON_DTO>();
            foreach (var s in truyvan)
            {
                HOA_DON_DTO ldp = new HOA_DON_DTO();
                ldp.mahd = s.mahd;
                ldp.madh = s.madh;
                ldp.masp = s.masp;
                ldp.tensp = s.tensp;
                ldp.dongia = (int)s.dongia;
                ldp.giamgia = (int)s.giamgia;
                ldp.soluong = (int)s.soluong;
                ldp.tongtien = (int)s.tongtien;
                ldp.deleted = (bool)s.deleted;
                ldp.ngaydat = (DateTime)s.ngaydat;
                ldp.makh = s.makh;
                ldp.tenkh = s.tenkh;

                dsLSP.Add(ldp);
            }

            return dsLSP;
        }
    }
}
