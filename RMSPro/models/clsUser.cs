using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSPro.models
{
    class clsUser
    {
        public int USERID { get; set; }
        public int EMPLOYEEID { get; set; }
        public string USERNAME { get; set; }
        public int PASSWORD { get; set; }
        public int EXPIREDDATE { get; set; }
        public int ISACTIVE { get; set; }

        public DataTable GetDate()
        {
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter("select * from user_tbl", clsGlobal.con);

            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }

            return dt;
        }
        //Insert
        public bool Insert()
        {
            bool check = false;
            OracleCommand cmd = new OracleCommand("USER_TBL_tapi.ins", clsGlobal.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_EMPLOYEEID", EMPLOYEEID);
            cmd.Parameters.Add("p_PASSWORD", PASSWORD);
            cmd.Parameters.Add("p_EXPIREDDATE", EXPIREDDATE);
            cmd.Parameters.Add("p_USERID", USERID);
            cmd.Parameters.Add("p_USERNAME", USERNAME);
            cmd.Parameters.Add("p_ISACTIVE", ISACTIVE);

            try
            {
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {
                check = true;
            }

            return check;
        }

    }
}
