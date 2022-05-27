using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class QUAN_LY_DAL
    {
        public static List<QUAN_LY_DTO> EF_GetAll()
        {
            Sale_ManagementEntities data = new Sale_ManagementEntities();
            var truyvan = data.Select_ql();
            List<QUAN_LY_DTO> dsQL = new List<QUAN_LY_DTO>();
            foreach (var s in truyvan)
            {
                QUAN_LY_DTO ql = new QUAN_LY_DTO();
                ql.maql = s.maql;
                ql.tenql = s.tenql;
                ql.username = s.username;
                ql.pass = s.pass;
                dsQL.Add(ql);
            }

            return dsQL;
        }

    }
}
