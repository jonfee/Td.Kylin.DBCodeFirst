using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.Kylin.DBApi.Core;
using Td.Kylin.Entity;

namespace Td.Kylin.DBApi.Data.SysData
{
    /// <summary>
    /// 系统用户等级配置
    /// </summary>
    public class Level
    {
        static Level()
        {
            _list = null;
        }

        private static List<System_Level> _list;

        /// <summary>
        /// 配置集合
        /// </summary>
        public static List<System_Level> List
        {
            get
            {
                if (null == _list)
                {
                    InitLevelConfig();
                }

                return _list;
            }
        }

        static void InitLevelConfig()
        {
            _list = new List<System_Level>();

            _list.Add(GetLevel("Lv1", 0));
            _list.Add(GetLevel("Lv2", 51));
            _list.Add(GetLevel("Lv3", 201));
            _list.Add(GetLevel("Lv4", 501));
            _list.Add(GetLevel("Lv5", 1001));
            _list.Add(GetLevel("Lv6", 2001));
            _list.Add(GetLevel("Lv7", 5001));
            _list.Add(GetLevel("Lv8", 8001));
            _list.Add(GetLevel("Lv9", 12001));
            _list.Add(GetLevel("Lv10", 16001));
            _list.Add(GetLevel("Lv11", 20001));
            _list.Add(GetLevel("Lv12", 25001));
            _list.Add(GetLevel("Lv13", 35001));
            _list.Add(GetLevel("Lv14", 50001));
            _list.Add(GetLevel("Lv15", 80001));
            _list.Add(GetLevel("Lv16", 120001));
            _list.Add(GetLevel("Lv17", 200001));
            _list.Add(GetLevel("Lv18", 500001));
            _list.Add(GetLevel("Lv19", 1500001));
            _list.Add(GetLevel("Lv20", 5000001));
        }

        static System_Level GetLevel(string name, int minScore)
        {
            return new System_Level
            {
                CreateTime = DateTime.Now,
                Enable = true,
                Icon = string.Empty,
                LevelID = IDProvider.NewId(),
                Min = minScore,
                Name = name
            };
        }
    }
}
