using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class KhoDAL
    {
        public static List<KhoDTO> EF_GetAll()
        {
            QLBH_techEntities data = new QLBH_techEntities();
            var truyvan = data.kho_Select();
            List<KhoDTO> dsKho = new List<KhoDTO>();
            foreach (var s in truyvan)
            {
                KhoDTO ks = new KhoDTO();
                ks.MaKho = s.MaKho;
                ks.MaSP = s.MaSP;
                ks.TrangThai = (Boolean)s.TrangThai;
                ks.SoLuongTonKho= (int)s.SoLuongTonKho;
                dsKho.Add(ks);
            }

            return dsKho;
        }
    }
}
