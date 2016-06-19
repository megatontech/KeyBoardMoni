using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyBoardUsage.Utils
{
    public class Config
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string DatabaseFile = "";

        public static string DataSource
        {
            get
            {
                return string.Format("data source={0}", DatabaseFile);
            }
        }
    }
}
