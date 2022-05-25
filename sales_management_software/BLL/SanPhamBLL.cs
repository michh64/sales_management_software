using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class SanPhamBLL
    {
        public static List<SAN_PHAM_DTO> EF_GetAll()
        {
            return SAN_PHAM_DAL.EF_GetAll();
        }
        public static bool EF_AddNew(SAN_PHAM_DTO sp)
        {
            return SAN_PHAM_DAL.EF_AddNew(sp);
        }
    }
}
