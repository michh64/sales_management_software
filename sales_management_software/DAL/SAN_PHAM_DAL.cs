using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace sales_management_software
{
    class SAN_PHAM_DAL
    {
        public static List<SAN_PHAM_DTO> EF_GetAll()
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            var truyvan = data.Select_sp().ToList();
            List<SAN_PHAM_DTO> dsSP = new List<SAN_PHAM_DTO>();
            foreach(var s in truyvan)
            {
                SAN_PHAM_DTO dp = new SAN_PHAM_DTO();
                dp.masp = s.masp;
                dp.tensp = s.tensp;
                dp.dongia=(int)s.dongia;
                dp.maNCC = s.maNCC;
                dp.maloai = s.maloai;
                dp.soluong = (int)s.soluong;
                dp.anhsp = s.anhsp;
                dp.mats = s.mats;
                dp.deleted = (bool)s.deleted;
                dsSP.Add(dp);
            }
            return dsSP;
        }
        public static bool EF_AddNew(SAN_PHAM_DTO dto)
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            data.Insert_sp(dto.maloai, dto.tensp, (int)dto.dongia, (int)dto.soluong, dto.maNCC, dto.maloai, (bool)dto.deleted);
            return data.SaveChanges() > 0 ? true : false;
        }
       
    }
}
