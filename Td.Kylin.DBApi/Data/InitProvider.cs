using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using Td.AspNet.Utils;
using Td.Kylin.DBApi.Core;
using Td.Kylin.DBApi.Enum;
using Td.Kylin.DBCodeFirst;
using Td.Kylin.Entity;

namespace Td.Kylin.DBApi.Data
{
    public class InitProvider
    {
        /// <summary>
        /// 初始化接口与模块授权
        /// </summary>
        /// <returns></returns>
        public static int InitApiMoudleAuthoriza()
        {
            using (var db = new DataContext())
            {
                var list = db.System_ModuleAuthorize.ToList();

                if (null != list && list.Count > 0)
                {
                    db.System_ModuleAuthorize.RemoveRange(list);
                    db.SaveChanges();
                }

                db.System_ModuleAuthorize.AddRange(SysData.ApiModuleAuthoriza.Data);

                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 初始化超级管理员
        /// </summary>
        /// <returns></returns>
        public static int InitSuperAdmin(string account, string pwd)
        {
            using (var db = new DataContext())
            {
                string password = Cryptography.MD5Encrypt(Cryptography.SHA1Encrypt(Cryptography.MD5Encrypt(pwd)));

                db.Admin_Account.Add(new Admin_Account
                {
                    AdminID = IDProvider.NewId(),
                    CreateTime = DateTime.Now,
                    DataStatus = true,
                    LastIp = "127.0.0.1",
                    LastTime = DateTime.Now,
                    Logins = 0,
                    Password = password,
                    PowerLevel = (int)EnumPowerLevel.Super,
                    Realname = "超级管理员",
                    Username = account,
                    UserPic = string.Empty
                });

                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 初始化行业/业务等数据
        /// </summary>
        public static List<SysData.Industry> InitIndustry()
        {
            using (var db = new DataContext())
            {
                var removeIndustryArr = db.Merchant_Industry.ToList();
                var removeBusinessArr = db.KylinService_Business.ToList();
                var removeBusOptionArr = db.KylinService_BusinessOptions.ToList();
                if (removeIndustryArr.Count() > 0) db.Merchant_Industry.RemoveRange(removeIndustryArr);
                if (removeBusinessArr.Count() > 0) db.KylinService_Business.RemoveRange(removeBusinessArr);
                if (removeBusOptionArr.Count() > 0) db.KylinService_BusinessOptions.RemoveRange(removeBusOptionArr);

                db.SaveChanges();

                List<Merchant_Industry> industryList = new List<Merchant_Industry>();

                List<KylinService_Business> businessList = new List<KylinService_Business>();

                List<KylinService_BusinessOptions> businessOptions = new List<KylinService_BusinessOptions>();

                List<KylinService_BusinessConfig> businessConfigs = new List<KylinService_BusinessConfig>();

                var data = SysData.IndustryBusiness.Data;

                foreach (var item in data)
                {
                    //一级类
                    industryList.Add(new Merchant_Industry
                    {
                        CreateTime = DateTime.Now,
                        Disabled = false,
                        Icon = string.Empty,
                        IndustryID = item.ID,
                        Name = item.Name,
                        OrderNo = 0,
                        ParentID = 0,
                        Layer = item.ID.ToString(),
                        TagStatus = 0
                    });

                    //二级类
                    if (null != item.Childrens && item.Childrens.Length > 0)
                    {
                        foreach (var child in item.Childrens)
                        {
                            industryList.Add(new Merchant_Industry
                            {
                                CreateTime = DateTime.Now,
                                Disabled = false,
                                Icon = string.Empty,
                                IndustryID = child.ID,
                                Name = child.Name,
                                OrderNo = 0,
                                ParentID = item.ID,
                                Layer = string.Format("{0}|{1}", item.ID, child.ID),
                                TagStatus = 0
                            });

                            //业务
                            if (null != child.Business && child.Business.Length > 0)
                            {
                                foreach (var busi in child.Business)
                                {
                                    businessList.Add(new KylinService_Business
                                    {
                                        AllowPerson = busi.AllowPerson,
                                        BusinessID = busi.BusinessID,
                                        BusinessType = busi.BusinessType,
                                        CreateTime = DateTime.Now,
                                        Disabled = false,
                                        Icon = string.Empty,
                                        IndustryID = child.ID,
                                        IsDelete = false,
                                        IsOpenService = busi.IsOpenService,
                                        Name = busi.Name,
                                        OrderNo = 0,
                                        PayerType = busi.PayerType,
                                        QuoteWays = busi.QuoteWays,
                                        TagStatus = 0
                                    });

                                    //子业务项
                                    if (null != busi.Options && busi.Options.Length > 0)
                                    {
                                        foreach (var option in busi.Options)
                                        {
                                            businessOptions.Add(new KylinService_BusinessOptions
                                            {
                                                BusinessID = busi.BusinessID,
                                                CreateTime = DateTime.Now,
                                                IsDelete = false,
                                                Name = option.Name,
                                                OptionID = option.OptionID,
                                                Remark = string.Empty
                                            });
                                        }
                                    }//end 子业务
                                }
                            }//end 业务
                        }
                    }//end 二级类
                }//end 一级类循环

                db.Merchant_Industry.AddRange(industryList);
                db.KylinService_Business.AddRange(businessList);
                db.KylinService_BusinessOptions.AddRange(businessOptions);

                if (db.SaveChanges() > 0)
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 初始化全国地区
        /// </summary>
        /// <returns></returns>
        public static int InitArea()
        {
            using (var db = new DataContext())
            {
                var list = db.System_Area.ToList();

                if (null != list && list.Count > 0)
                {
                    db.System_Area.RemoveRange(list);
                    db.SaveChanges();
                }

                db.System_Area.AddRange(SysData.AreaCity.AreaList);

                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 初始化全局配置
        /// </summary>
        public static int InitGlobalConfig()
        {
            using (var db = new DataContext())
            {
                var list = db.System_GlobalResources.ToList();

                if (null != list && list.Count > 0)
                {
                    db.System_GlobalResources.RemoveRange(list);
                    db.SaveChanges();
                }

                db.System_GlobalResources.AddRange(SysData.GlobalConfig.GlobalResources);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 初始化系统广告位
        /// </summary>
        /// <returns></returns>
        public static int InitAdPosition(out List<Ad_Page> pageList, out List<Ad_Position> positionList)
        {
            using (var db = new DataContext())
            {
                pageList = SysData.AdPosition.AdPageList;
                positionList = SysData.AdPosition.AdPositionList;

                var tempPagelist = db.Ad_Page.ToList();
                var tempPositionlist = db.Ad_Position.ToList();

                if (null != tempPagelist && tempPagelist.Count > 0)
                {
                    db.Ad_Page.RemoveRange(tempPagelist);
                }
                if (null != tempPositionlist && tempPositionlist.Count > 0)
                {
                    db.Ad_Position.RemoveRange(tempPositionlist);
                }
                db.SaveChanges();

                db.Ad_Page.AddRange(pageList);
                db.Ad_Position.AddRange(positionList);

                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 初始化系统积分配置
        /// </summary>
        /// <returns></returns>
        public static List<System_PointsConfig> InitPointsConfig()
        {
            using (var db = new DataContext())
            {
                var list = db.System_PointsConfig.ToList();

                if (null != list && list.Count > 0)
                {
                    db.System_PointsConfig.RemoveRange(list);
                    db.SaveChanges();
                }

                db.System_PointsConfig.AddRange(SysData.Points.List);

                if (db.SaveChanges() > 0)
                {
                    return SysData.Points.List;
                }

                return null;
            }
        }

        /// <summary>
        /// 初始化系统经验值配置
        /// </summary>
        /// <returns></returns>
        public static List<System_EmpiricalConfig> InitEmpiricalConfig()
        {
            using (var db = new DataContext())
            {
                var list = db.System_EmpiricalConfig.ToList();

                if (null != list && list.Count > 0)
                {
                    db.System_EmpiricalConfig.RemoveRange(list);
                    db.SaveChanges();
                }

                db.System_EmpiricalConfig.AddRange(SysData.Empirical.List);

                if (db.SaveChanges() > 0)
                {
                    return SysData.Empirical.List;
                }

                return null;
            }
        }

        /// <summary>
        /// 初始化系统用户等级配置
        /// </summary>
        /// <returns></returns>
        public static List<System_Level> InitLevelConfig()
        {
            using (var db = new DataContext())
            {
                var list = db.System_Level.ToList();

                if (null != list && list.Count > 0)
                {
                    db.System_Level.RemoveRange(list);
                    db.SaveChanges();
                }

                db.System_Level.AddRange(SysData.Level.List);

                if (db.SaveChanges() > 0)
                {
                    return SysData.Level.List;
                }

                return null;
            }
        }
    }
}
