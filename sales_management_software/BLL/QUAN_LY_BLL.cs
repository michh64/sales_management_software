using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class QUAN_LY_BLL
    {
        public static List<QUAN_LY_DTO> EF_GetAll()
        {
            return QUAN_LY_DAL.EF_GetAll();
        }
    }
}
