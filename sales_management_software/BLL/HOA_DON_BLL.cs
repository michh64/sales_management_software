using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class HOA_DON_BLL
    {
        public static List<HOA_DON_DTO> EF_GetAll()
        {
            return HOA_DON_DAL.EF_GetAll();
        }
    }
}
