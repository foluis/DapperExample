using DapperExample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DapperExample.DataAccess.Interfaces
{
    public interface IAppUserRepository
    {
        Task<IEnumerable<AppUser>> GetAppUsers(int pageNum, int pageSize, string sortColumnName, string sortOrder);
    }
}
