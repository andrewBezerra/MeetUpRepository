using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ESCOLA.INFRA
{
    public interface IDB
    {
        IDbConnection GetConnection();
    }
}
