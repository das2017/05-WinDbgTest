using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using WindbgTest.Utils;
using Dapper;

namespace WindbgTest
{
    public class CityDBQuery
    {
        /// <summary>
        /// 获取城市信息
        /// </summary>
        /// <returns>返回城市列表</returns>
        public IEnumerable<CityEntity> GetCityList()
        {
            using (IDbConnection connection = Common.OpenConnection())
            {
                const string query =
@"SELECT CityNameC, CityCode, AirportCode FROM dbo.TblCity WITH(NOLOCK) WHERE CityCode = 'SHA'";
                return connection.Query<CityEntity>(query);
            }
        }      
    }
}
