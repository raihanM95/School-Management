using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SmartSchool
{
    public class DataManage
    {
        public int count;
        string connectstr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public DataTable GetDataTable(string query)
        {
            SqlConnection con = new SqlConnection(connectstr);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());

            return dt;
        }

        public int Execute(string query)
        {
            SqlConnection con = new SqlConnection(connectstr);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException ex)
            {
                
                return 0;
            }
        }
    }
}