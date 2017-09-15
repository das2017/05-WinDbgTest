using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindbgTest.Utils
{
    /// <summary>
    /// 城市实体
    /// </summary>
    [Serializable]
    public class CityEntity
    {
        /// <summary>
        /// 城市中文名称
        /// </summary>
        public string CityNameC { get; set; }

        /// <summary>
        /// 机场三字码
        /// </summary>
        public string AirportCode { get; set; }

        /// <summary>
        /// 城市三字码
        /// </summary>
        public string CityCode { get; set; }
    }
}
