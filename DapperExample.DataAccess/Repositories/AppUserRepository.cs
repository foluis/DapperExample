using DapperExample.DataAccess.Interfaces;
using DapperExample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DapperExample.DataAccess.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        public Task<IEnumerable<AppUser>> GetAppUsers(int pageNum, int pageSize, string sortColumnName, string sortOrder)
        {
            //using (var connection = _base.GetConnection())
            //{
            //    var parameters = new DynamicParameters();
            //    parameters.Add("@pageNum", pageNum);
            //    parameters.Add("@pageSize", pageSize);
            //    parameters.Add("@sortColumnName", sortColumnName);
            //    parameters.Add("@SortOrder", sortOrder);

            //    var budgetsDtoList = await connection.QueryAsync<PresupuestoDTO>("[dbo].[ObtenerPresupuestos]", parameters, null, null, CommandType.StoredProcedure);
            //    return _mapper.Map<IEnumerable<PresupuestoDTO>, IEnumerable<Budget>>(budgetsDtoList);
            //}
            return null;
        }
    }
}
