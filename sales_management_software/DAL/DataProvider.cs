using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    class DataProvider
    {
        static string con_string = @"(local); Initial Catalog = QLBH_tech; 
               Integrated Security=True";

        // tao ket noi
        public static SqlConnection open()
        {
            SqlConnection conn = new SqlConnection(con_string);
            conn.Open();
            return conn;
        }

        //truy van csdl bang cau lenh KHONG tham so truyen vao
        public static SqlDataReader ExecuteReader(string strCauTruyVan, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strCauTruyVan, conn);
            SqlDataReader reader = com.ExecuteReader();
            return reader;
        }

        //truy van csdl bang cau lenh CO tham so truyen vao
        public static SqlDataReader ExecuteReader(string strCauTruyVan, SqlParameter[] pars, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strCauTruyVan, conn);
            com.Parameters.AddRange(pars);
            SqlDataReader reader = com.ExecuteReader();
            return reader;
        }

        //thuc thi lenh nonQuery k tham so
        public static bool ExecuteNonQuery(string strCauTruyVan, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strCauTruyVan, conn);
            bool result = (com.ExecuteNonQuery() != 0);
            return result;

        }
        //thuc thi lenh nonQuery co tham so

        public static bool ExecuteNonQuery(string strCauTruyVan, SqlParameter[] pars, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strCauTruyVan, conn);
            com.Parameters.AddRange(pars);
            bool result = (com.ExecuteNonQuery() != 0);
            return result;


        }
    }
}
