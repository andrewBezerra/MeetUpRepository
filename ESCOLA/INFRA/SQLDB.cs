using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ESCOLA.INFRA
{
    public class SQLDB : IDB
    {
        public IDbConnection GetConnection()
        {
            return new SqlConnection(@"SERVER=ANDREW-SURFACE\ANDREWSQL; INITIAL CATALOG=ESCOLA; USER ID=sa;PASSWORD=123");

        }
    }
}
