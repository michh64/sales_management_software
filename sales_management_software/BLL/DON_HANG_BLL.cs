using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class DON_HANG_BLL
    {
        public static List<DON_HANG_DTO> EF_GetAll()
        {
            return DON_HANG_DAL.EF_GetAll();
        }

    }
}
