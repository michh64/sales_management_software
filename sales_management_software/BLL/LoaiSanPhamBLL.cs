using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class LoaiSanPhamBLL
    {
        public static List<LOAI_SAN_PHAM_DTO> EF_GetAll()
        {
            return LOAI_SAN_PHAM_DAL.EF_GetAll();
        }
    }
}
