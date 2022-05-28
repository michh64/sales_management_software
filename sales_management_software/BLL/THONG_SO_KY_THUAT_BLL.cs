using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class THONG_SO_KY_THUAT_BLL
    {
        public static List<THONG_SO_KY_THUAT_DTO> EF_GetAll()
        {
            return THONG_SO_KY_THUAT_DAL.EF_GetAll();
        }
    }
}
