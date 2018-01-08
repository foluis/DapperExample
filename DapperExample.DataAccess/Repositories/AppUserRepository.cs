using DapperExample.DataAccess.Interfaces;
using DapperExample.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperExample.DataAccess.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly IBaseRepository _base;

        public AppUserRepository(IBaseRepository baseRepo)
        {
            _base = baseRepo;
        }

        public async Task<IEnumerable<AppUser>> GetAllUsers()
        {
            IEnumerable<AppUser> appUser = new List<AppUser>();

            try
            {
                using (var connection = _base.GetConnection())
                {
                    appUser = await connection.QueryAsync<AppUser>("[dbo].[GetAllUsers]", CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                var error = e.ToString();
            }
           
            return appUser;
        }

        public async Task<IEnumerable<AppUser>> GetAppUsers(int pageNum, int pageSize, string sortColumnName, string sortOrder)
        {
            using (var connection = _base.GetConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@pageNum", pageNum);
                parameters.Add("@pageSize", pageSize);
                parameters.Add("@sortColumnName", sortColumnName);
                parameters.Add("@SortOrder", sortOrder);

                var appUser = await connection.QueryAsync<AppUser>("[dbo].[ObtenerPresupuestos]", parameters, null, null, CommandType.StoredProcedure);
                return appUser;
            }
        }
    }
}
