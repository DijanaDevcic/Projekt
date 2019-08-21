using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

static class SqlStatic
{
	public static SqlConnection GetSqlConnection()
    {
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"DataSource=URI=file:MojaBaza.db");
        }
    }
}
