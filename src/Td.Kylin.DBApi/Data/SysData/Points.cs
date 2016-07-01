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

            _list.Add(GetConfig(EnumLibrary.UserActivityType.Register, 30, 30, EnumLibrary.ScoreMaxLimitUnit.Times, false));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.UploadHeadPhoto, 20, 20, EnumLibrary.ScoreMaxLimitUnit.Times, false));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.FinishInfomation, 20, 20, EnumLibrary.ScoreMaxLimitUnit.Times, false));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.RealNameCertification, 30, 30, EnumLibrary.ScoreMaxLimitUnit.Times, false));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.SignIn, 10, 10, EnumLibrary.ScoreMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.ClickLike, 1, 30, EnumLibrary.ScoreMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.PublishTopic, 5, 50, EnumLibrary.ScoreMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.ReplyTopic, 1, 30, EnumLibrary.ScoreMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.InviteUserRegister, 30, 30, EnumLibrary.ScoreMaxLimitUnit.Times, true));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.TopicStick, 30, 30, EnumLibrary.ScoreMaxLimitUnit.Times, true));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.ShareData, 10, 100, EnumLibrary.ScoreMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.Feedback, 5, 100, EnumLibrary.ScoreMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.CreateResume, 20, 20, EnumLibrary.ScoreMaxLimitUnit.Times, false));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.OrderFinish, 20, 20, EnumLibrary.ScoreMaxLimitUnit.Times, true));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.Evaluate, 2, 2, EnumLibrary.ScoreMaxLimitUnit.Times, true));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.FinishReceiptAddress, 5, 5, EnumLibrary.ScoreMaxLimitUnit.Times, false));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.AddFriend, 1, 10, EnumLibrary.ScoreMaxLimitUnit.Day, true));
            _list.Add(GetConfig(EnumLibrary.UserActivityType.StoreUp, 1, 10, EnumLibrary.ScoreMaxLimitUnit.Day, true));
        }

        static System_PointsConfig GetConfig(EnumLibrary.UserActivityType type, int score, int maxScore, EnumLibrary.ScoreMaxLimitUnit unit, bool isRepeatable)
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
