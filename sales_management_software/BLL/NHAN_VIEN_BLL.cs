using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class NHAN_VIEN_BLL
    {
        public static List<NHAN_VIEN_DTO> EF_GetAll()
        {
            return NHAN_VIEN_DAL.EF_GetAll();
        }
    }
}
