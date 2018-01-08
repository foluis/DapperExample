using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperExample.DataAccess.Interfaces
{
    public interface IBaseRepository
    {
        string ConnectionString { get; }

        IDbConnection GetConnection();
    }
}
