using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConcetToSql
    {
        private readonly string connectionString;

        public ConcetToSql()
        {
           connectionString = "Data Source=P1041047\\SQLEXPRESS14;Initial Catalog=Usu;User ID=sa;Password=samu1803@";

         //connectionString = "Data Source=DISCOVERY-PC;Initial Catalog=Usu;User ID=sa;Password=samu1803@";
        }
        protected SqlConnection GetConnection() { return new SqlConnection(connectionString); }
        
    }
}
