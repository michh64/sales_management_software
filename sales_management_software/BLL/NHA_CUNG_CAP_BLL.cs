using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class NHA_CUNG_CAP_BLL
    {
        public static List<NHA_CUNG_CAP_DTO> EF_GetAll()
        {
            return NHA_CUNG_CAP_DAL.EF_GetAll();
        }
    }
}
