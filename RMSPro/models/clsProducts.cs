using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSPro.models
{
    class clsProducts
    {
        public int PRODUCTID { get; set; }
        public string PRODUCTNAMEKH { get; set; }
        public string PRODUCTNAMEEN { get; set; }
        public int BARCODE { get; set; }
        public int PRICE { get; set; }
        public int COST { get; set; }

        public int CATEGORYID { get; set; }

        //Select
        public DataTable GetDate()
        {
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter("select * from products_tbl", clsGlobal.con);

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
        //Search
        public DataTable GetDate(string q)
        {
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter("select * from products_tbl where lower(productnamekh) || lower(productnameen)  like '%' || lower( :q) || '%'", clsGlobal.con);
            da.SelectCommand.Parameters.Add(":q", q);

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
            OracleCommand cmd = new OracleCommand("PRODUCTS_TBL_tapi.ins", clsGlobal.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_PRODUCTNAMEEN", PRODUCTNAMEEN);
            cmd.Parameters.Add("p_COST", COST);
            cmd.Parameters.Add("p_PRODUCTNAMEKH", PRODUCTNAMEKH);
            cmd.Parameters.Add("p_PRICE", PRICE);
            cmd.Parameters.Add("p_CATEGORYID", CATEGORYID);
            cmd.Parameters.Add("p_BARCODE", BARCODE);
            

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
        //Update
        public bool Update()
        {
            bool check = false;
            OracleCommand cmd = new OracleCommand("PRODUCTS_TBL_tapi.upd", clsGlobal.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_PRODUCTNAMEEN", PRODUCTNAMEEN);
            cmd.Parameters.Add("p_COST", COST);
            cmd.Parameters.Add("p_PRODUCTNAMEKH", PRODUCTNAMEKH);
            cmd.Parameters.Add("p_PRICE", PRICE);
            cmd.Parameters.Add("p_CATEGORYID", CATEGORYID);
            cmd.Parameters.Add("p_BARCODE", BARCODE);
            cmd.Parameters.Add("p_PRODUCTID", PRODUCTID);
            

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
        //Delete
        public bool Delete()
        {
            bool check = false;
            OracleCommand cmd = new OracleCommand("PRODUCTS_TBL_tapi.del", clsGlobal.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_PRODUCTID", PRODUCTID);


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
