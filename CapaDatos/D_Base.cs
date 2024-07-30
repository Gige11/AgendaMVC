using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class D_Base
    {
        protected SqlConnection oCnn = new SqlConnection();
        protected SqlCommand oCmd = new SqlCommand();
        protected SqlDataAdapter oDA;
        protected DataTable oDT;
        protected string sSQL = "";
    }
}
