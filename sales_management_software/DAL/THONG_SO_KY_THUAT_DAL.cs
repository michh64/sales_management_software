using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class THONG_SO_KY_THUAT_DAL
    {
        public static List<THONG_SO_KY_THUAT_DTO> EF_GetAll()
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            var truyvan = data.Select_tskt().ToList();
            List<THONG_SO_KY_THUAT_DTO> dsTS = new List<THONG_SO_KY_THUAT_DTO>();
            foreach (var s in truyvan)
            {
                THONG_SO_KY_THUAT_DTO ts = new THONG_SO_KY_THUAT_DTO();
                ts.mats = s.mats;
                ts.camera = s.camera;
                ts.chipset = s.chipset;
                ts.manhinh = s.manhinh;
                ts.ram = s.ram;
                ts.memory = s.memory;
                ts.pin = s.pin;
                ts.deleted = (bool)s.deleted;
                dsTS.Add(ts);
            }
            return dsTS;
        }

    }
}
