using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class LoaiSanPhamBLL
    {
        public static List<LoaiSanPhamDTO> EF_GetAll()
        {
            return LoaiSanPhamDAL.EF_GetAll();
        }
    }
}
