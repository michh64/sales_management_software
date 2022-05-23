using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class NhaCungCapBLL
    {
        public static List<NhaCungCapDTO> EF_GetAll()
        {
            return NhaCungCapDAL.EF_GetAll();
        }
    }
}
