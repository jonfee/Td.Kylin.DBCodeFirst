using Microsoft.Data.Entity;
using Td.Kylin.DBCodeFirst.Models;

namespace Td.Kylin.DBCodeFirst
{
    public partial class DataContext
    {
        #region 广告

        //广告页
        public DbSet<Ad_Page> Ad_Page { get { return Set<Ad_Page>(); } }

        /// <summary>
        /// 广告位
        /// </summary>
        public DbSet<Ad_Position> Ad_Position { get { return Set<Ad_Position>(); } }

        /// <summary>
        /// 广告内容
        /// </summary>
        public DbSet<Ad_Content> Ad_Content { get { return Set<Ad_Content>(); } }

        #endregion

        #region 管理员

        /// <summary>
        /// 管理员账户
        /// </summary>
        public DbSet<Admin_Account> Admin_Account { get { return Set<Admin_Account>(); } }

        /// <summary>
        /// 管理员权限
        /// 
        /// </summary>
        public DbSet<Admin_Permission> Admin_Permission { get { return Set<Admin_Permission>(); } }

        #endregion

        #region 商家

        /// <summary>
        /// 商家所属行业
        /// </summary>
        public DbSet<Merchant_Industry> Merchant_Industry { get { return Set<Merchant_Industry>(); } }

        /// <summary>
        /// 商家账户信息
        /// </summary>
        public DbSet<Merchant_Account> Merchant_Account { get { return Set<Merchant_Account>(); } }

        /// <summary>
        /// 商家认证
        /// </summary>
        public DbSet<Merchant_Certificate> Merchant_Certificate { get { return Set<Merchant_Certificate>(); } }

        #endregion

        #region 用户

        /// <summary>
        /// 用户账户信息
        /// </summary>
        public DbSet<User_Account> User_Account { get { return Set<User_Account>(); } }

        /// <summary>
        /// 用户地址库
        /// </summary>
        public DbSet<User_Address> User_Address { get { return Set<User_Address>(); } }

        /// <summary>
        /// 用户使用设备
        /// </summary>
        public DbSet<User_Device> User_Device { get { return Set<User_Device>(); } }

        /// <summary>
        /// 用户社区信息
        /// </summary>
        public DbSet<User_Forum> User_Forum { get { return Set<User_Forum>(); } }

        /// <summary>
        /// 用户位置轨迹
        /// </summary>
        public DbSet<User_LocationTrack> User_LocationTrack { get { return Set<User_LocationTrack>(); } }

        /// <summary>
        /// 用户在线数据
        /// </summary>
        public DbSet<User_Online> User_Online { get { return Set<User_Online>(); } }

        /// <summary>
        /// 用户附属资料
        /// </summary>
        public DbSet<User_Profile> User_Profile { get { return Set<User_Profile>(); } }

        /// <summary>
        /// 用户摇一摇记录
        /// </summary>
        public DbSet<User_ShakeRecord> User_ShakeRecord { get { return Set<User_ShakeRecord>(); } }

        #endregion

        #region 摇一摇

        /// <summary>
        /// 摇一摇数据内容
        /// </summary>
        public DbSet<Shake_Content> Shake_Content { get { return Set<Shake_Content>(); } }

        /// <summary>
        /// 摇一摇记录
        /// </summary>
        public DbSet<Shake_UserRecord> Shake_UserRecord { get { return Set<Shake_UserRecord>(); } }

        #endregion

        #region 短信

        /// <summary>
        /// 系统短信
        /// </summary>
        public DbSet<System_SMS> System_SMS { get { return Set<System_SMS>(); } }

        #endregion

        #region 模块授权

        /// <summary>
        /// 模块授权
        /// </summary>
        public DbSet<System_ModuleAuthorize> System_ModuleAuthorize { get { return Set<System_ModuleAuthorize>(); } }

        #endregion
    }
}
