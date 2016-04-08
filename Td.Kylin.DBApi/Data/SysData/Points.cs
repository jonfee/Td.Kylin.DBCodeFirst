using System;
using System.Collections.Generic;
using Td.Kylin.Entity;

namespace Td.Kylin.DBApi.Data.SysData
{
    /// <summary>
    /// 系统积分配置
    /// </summary>
    public class Points
    {
        static Points()
        {
            _list = null;
        }

        private static List<System_PointsConfig> _list;

        /// <summary>
        /// 配置集合
        /// </summary>
        public static List<System_PointsConfig> List
        {
            get
            {
                if (null == _list)
                {
                    InitPointsConfig();
                }

                return _list;
            }
        }

        static void InitPointsConfig()
        {
            _list = new List<System_PointsConfig>();

            _list.Add(GetConfig(EnumLibrary.PointsActivityType.Register, 30, 30, EnumLibrary.PointsMaxLimitUnit.Times, false));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.UploadHeadPhoto, 20, 20, EnumLibrary.PointsMaxLimitUnit.Times, false));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.FinishInfomation, 20, 20, EnumLibrary.PointsMaxLimitUnit.Times, false));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.RealNameCertification, 30, 30, EnumLibrary.PointsMaxLimitUnit.Times, false));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.SignIn, 10, 10, EnumLibrary.PointsMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.ClickLike, 1, 30, EnumLibrary.PointsMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.PublishTopic, 5, 50, EnumLibrary.PointsMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.ReplyTopic, 1, 30, EnumLibrary.PointsMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.InviteUserRegister, 30, 30, EnumLibrary.PointsMaxLimitUnit.Times, true));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.TopicStick, 30, 0, EnumLibrary.PointsMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.ShareData, 10, 100, EnumLibrary.PointsMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.Feedback, 5, 100, EnumLibrary.PointsMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.CreateResume, 20, 20, EnumLibrary.PointsMaxLimitUnit.Times, false));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.OrderFinish, 20, 20, EnumLibrary.PointsMaxLimitUnit.Times, true));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.Evaluate, 5, 5, EnumLibrary.PointsMaxLimitUnit.Times, true));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.FinishReceiptAddress, 5, 5, EnumLibrary.PointsMaxLimitUnit.Times, false));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.AddFriend, 1, 10, EnumLibrary.PointsMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.PointsActivityType.StoreUp, 1, 10, EnumLibrary.PointsMaxLimitUnit.Day, true));
        }

        static System_PointsConfig GetConfig(EnumLibrary.PointsActivityType type, int score, int maxScore, EnumLibrary.PointsMaxLimitUnit unit, bool isRepeatable)
        {
            return new System_PointsConfig
            {
                ActivityType = (int)type,
                MaxLimit = maxScore,
                MaxUnit = (int)unit,
                Repeatable = isRepeatable,
                Score = score,
                UpdateTime = DateTime.Now
            };
        }
    }
}
