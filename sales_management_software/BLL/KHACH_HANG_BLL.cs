using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
   public class KHACH_HANG_BLL
    {
        public static List<KHACH_HANG_DTO> EF_GetAll()
        {
            return KHACH_HANG_DAL.EF_GetAll();
        }
    }
}
