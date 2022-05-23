using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class SanPhamBLL
    {
        public static List<SanPhamDTO> EF_GetAll()
        {
            return SanPhamDAL.EF_GetAll();
        }
        public static bool EF_AddNew(SanPhamDTO sp)
        {
            return SanPhamDAL.EF_AddNew(sp);
        }
    }
}
