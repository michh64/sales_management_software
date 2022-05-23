using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace sales_management_software
{
    class SanPhamDAL
    {
        public static List<SanPhamDTO> EF_GetAll()
        {
            QLBH_techEntities1 data = new QLBH_techEntities1();
            var truyvan = data.sp_Select();
            List<SanPhamDTO> dsSP = new List<SanPhamDTO>();
            foreach(var s in truyvan)
            {
                SanPhamDTO dp = new SanPhamDTO();
                dp.MaSP = s.MaSP;
                dp.MaLSP = s.MaLSP;
                dp.MaNCC=s.MaNCC;
                dp.TenSP = s.TenSP;
                dp.DonGia = s.DonGia;
                dp.MaLSP = s.MaLSP;
                dp.MaKho = s.MaKho;
                dp.TrangThai = (bool)s.TrangThai;
                dsSP.Add(dp);
            }
            return dsSP;
        }
        public static bool EF_AddNew(SanPhamDTO dto)
        {
            QLBH_techEntities1 data = new QLBH_techEntities1();
                string[] arrr = new string[7];
                arrr[0] = dto.MaSP;
                arrr[1] = dto.TenSP;
                arrr[2] = dto.DonGia;
                arrr[3] = dto.MaNCC;
                arrr[4] = dto.MaKho;
                arrr[5] = dto.MaLSP;
                arrr[6] = dto.TrangThai.ToString();
                data.sp_Insert(arrr[0], arrr[1], arrr[2], arrr[3], arrr[4], arrr[5], Boolean.Parse(arrr[6]));
            return data.SaveChanges() > 0 ? true : false;
        }
       
    }
}
