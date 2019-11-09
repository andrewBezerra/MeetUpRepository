using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ESCOLA.INFRA
{
    public class MyDB : IDB
    {
        public IDbConnection GetConnection()
        {
            return new MySqlConnection(@"SERVER=ANDREW-SURFACE\ANDREWSQL; Database=ESCOLA; UID=sa;PWD=123");
        }
    }
}
