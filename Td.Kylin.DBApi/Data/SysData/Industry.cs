using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.Kylin.Entity;

namespace Td.Kylin.DBApi.Data.SysData
{
    /// <summary>
    /// 一级行业
    /// </summary>
    public class Industry
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public IndustryOption[] Childrens { get; set; }
    }

    /// <summary>
    /// 二级行业
    /// </summary>
    public class IndustryOption
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public Business[] Business { get; set; }
    }

    /// <summary>
    /// 业务
    /// </summary>
    public class Business
    {
        /// <summary>
        /// 业务ID
        /// </summary>
        public long BusinessID { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 业务类型（如：上门|预约）
        /// </summary>
        public int BusinessType { get; set; }

        /// <summary>
        /// 是否已开通线上服务（未开通时表示不能进行业务操作，如：上门服务|预约服务）
        /// </summary>
        public bool IsOpenService { get; set; }

        /// <summary>
        /// 报价方式（枚举：线下报价｜下单时报价｜上门时报价等）
        /// </summary>
        public int QuoteWays { get; set; }

        /// <summary>
        /// 付款方类型（枚举：下单方｜服务方）
        /// </summary>
        public int PayerType { get; set; }

        /// <summary>
        /// 是否允许个人开展业务
        /// </summary>
        public bool AllowPerson { get; set; }

        public BusinessOption[] Options { get; set; }
    }

    /// <summary>
    /// 业务子项
    /// </summary>
    public class BusinessOption
    {
        /// <summary>
        /// 子项ID
        /// </summary>
        public long OptionID { get; set; }

        /// <summary>
        /// 子项名称
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// 数据配置项
    /// </summary>
    public class IndustryBusiness
    {
        /// <summary>
        /// 数据
        /// </summary>
        public static List<Industry> Data
        {
            get
            {
                List<Industry> data = new List<Industry>();

                data.Add(new Industry
                {
                    ID = 101,
                    Name = "餐饮美食",
                    Childrens = new IndustryOption[]
                    {
                        new IndustryOption{ ID = 101101, Name = "火锅"},
                        new IndustryOption{ ID = 101102, Name = "小吃快餐"},
                        new IndustryOption{ ID = 101103, Name = "烧烤"},
                        new IndustryOption{ ID = 101104, Name = "面包甜点"},
                        new IndustryOption{ ID = 101105, Name = "川菜"},
                        new IndustryOption{ ID = 101106, Name = "自助餐"},
                        new IndustryOption{ ID = 101107, Name = "西餐"},
                        new IndustryOption{ ID = 101108, Name = "韩国料理"},
                        new IndustryOption{ ID = 101109, Name = "日本料理"},
                        new IndustryOption{ ID = 101110, Name = "江浙菜"},
                        new IndustryOption{ ID = 101111, Name = "粤菜"},
                        new IndustryOption{ ID = 101112, Name = "清真菜"},
                        new IndustryOption{ ID = 101113, Name = "湘菜"},
                        new IndustryOption{ ID = 101114, Name = "东北菜"},
                        new IndustryOption{ ID = 101115, Name = "海鲜"},
                        new IndustryOption{ ID = 101116, Name = "其他"}
                    }
                });
                data.Add(new Industry
                {
                    ID = 102,
                    Name = "休闲娱乐",
                    Childrens = new IndustryOption[]
                    {
                        new IndustryOption{ ID = 102101, Name = "KTV"},
                        new IndustryOption{ ID = 102102, Name = "电影院"},
                        new IndustryOption{ ID = 102103, Name = "运动健身"},
                        new IndustryOption{ ID = 102104, Name = "咖啡厅"},
                        new IndustryOption{ ID = 102105, Name = "酒吧"},
                        new IndustryOption{ ID = 102106, Name = "足疗按摩"},
                        new IndustryOption{ ID = 102107, Name = "洗浴"},
                        new IndustryOption{ ID = 102108, Name = "棋牌室"},
                        new IndustryOption{ ID = 102109, Name = "茶馆"},
                        new IndustryOption{ ID = 102110, Name = "游乐游艺"},
                        new IndustryOption{ ID = 102111, Name = "休闲网吧/网咖"},
                        new IndustryOption{ ID = 102112, Name = "公园"},
                        new IndustryOption{ ID = 102113, Name = "旅行社"},
                        new IndustryOption{ ID = 102114, Name = "采摘/农家乐"},
                        new IndustryOption{ ID = 102115, Name = "中医养生"},
                        new IndustryOption{ ID = 102116, Name = "DIY手工坊"},
                        new IndustryOption{ ID = 102117, Name = "温泉"},
                        new IndustryOption{ ID = 102118, Name = "桌球馆"},
                        new IndustryOption{ ID = 102119, Name = "其他"}

                    }
                });
                data.Add(new Industry
                {
                    ID = 103,
                    Name = "丽人",
                    Childrens = new IndustryOption[]
                    {
                        new IndustryOption{ ID = 103101, Name = "美发"},
                        new IndustryOption{ ID = 103102, Name = "美容/spa"},
                        new IndustryOption{ ID = 103103, Name = "美甲"},
                        new IndustryOption{ ID = 103104, Name = "瘦身纤体"},
                        new IndustryOption{ ID = 103105, Name = "美瞳"},
                        new IndustryOption{ ID = 103106, Name = "美睫"},
                        new IndustryOption{ ID = 103107, Name = "个性写真"},
                        new IndustryOption{ ID = 103108, Name = "瑜伽"},
                        new IndustryOption{ ID = 103109, Name = "舞蹈"},
                        new IndustryOption{ ID = 103110, Name = "整形"},
                        new IndustryOption{ ID = 103111, Name = "纹身"},
                        new IndustryOption{ ID = 103112, Name = "产后恢复整形"},
                        new IndustryOption{ ID = 103113, Name = "其他"}
                    }
                });
                data.Add(new Industry
                {
                    ID = 104,
                    Name = "购物",
                    Childrens = new IndustryOption[]
                    {
                        new IndustryOption{ ID = 104101, Name = "超市/便利店"},
                        new IndustryOption{ ID = 104102, Name = "食品茶酒"},
                        new IndustryOption{ ID = 104103, Name = "水果店"},
                        new IndustryOption{ ID = 104104, Name = "综合商场"},
                        new IndustryOption{ ID = 104105, Name = "品牌折扣店"},
                        new IndustryOption{ ID = 104106, Name = "运动户外"},
                        new IndustryOption{ ID = 104107, Name = "服饰鞋包"},
                        new IndustryOption{ ID = 104108, Name = "化妆品"},
                        new IndustryOption{ ID = 104109, Name = "珠宝饰品"},
                        new IndustryOption{ ID = 104110, Name = "办公/文化用品"},
                        new IndustryOption{ ID = 104111, Name = "数码产品"},
                        new IndustryOption{ ID = 104112, Name = "花店"},
                        new IndustryOption{ ID = 104113, Name = "书店"},
                        new IndustryOption{ ID = 104114, Name = "眼镜店"},
                        new IndustryOption{ ID = 104115, Name = "家居建材"},
                        new IndustryOption{ ID = 104116, Name = "蔬菜店"},
                        new IndustryOption{ ID = 104117, Name = "报刊亭"},
                        new IndustryOption{ ID = 104118, Name = "其他"}

                    }
                });
                data.Add(new Industry
                {
                    ID = 105,
                    Name = "生活服务",
                    Childrens = new IndustryOption[]
                    {
                        new IndustryOption{
                            ID = 105101,
                            Name = "家政",
                            Business=new Business[]
                            {
                               new Business {BusinessID=105101101,Name="月嫂", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working},
                               new Business {BusinessID=105101102,Name="育儿嫂", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working},
                               new Business {BusinessID=105101103,Name="老人陪护", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working},
                               new Business {BusinessID=105101104,Name="保姆", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working},
                               new Business {BusinessID=105101105,Name="病患陪护", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working},
                               new Business {BusinessID=105101106,Name="长期钟点工", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working}
                            }
                        },
                        new IndustryOption{
                            ID = 105102,
                            Name = "洗衣店",
                            Business=new Business[]
                            {
                                new Business {BusinessID=105102101,Name="洗衣", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.ShangMen,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working},
                                new Business {BusinessID=105102102,Name="洗鞋", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.ShangMen,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working},
                                new Business {BusinessID=105102103,Name="居家用品", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.ShangMen,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working},
                                new Business {BusinessID=105102104,Name="奢侈品洗护", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.ShangMen,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working}
                            }
                        },
                        new IndustryOption{ ID = 105103, Name = "宠物"},
                        new IndustryOption{ ID = 105104, Name = "快递"},
                        new IndustryOption{ ID = 105105, Name = "送水"},
                        new IndustryOption{ ID = 105106, Name = "家电维修"},
                        new IndustryOption{ ID = 105107, Name = "搬家"},
                        new IndustryOption{ ID = 105108, Name = "房屋维修"},
                        new IndustryOption{
                            ID = 105109,
                            Name = "保洁",
                            Business=new Business[]
                            {
                                 new Business {
                                     BusinessID =105109101,
                                     Name ="日常保洁",
                                     AllowPerson =true,
                                     BusinessType =(int)Enum.EnumBusinessType.ShangMen,
                                     IsOpenService =true,
                                     PayerType =(int)Enum.EnumPayerType.User,
                                     QuoteWays =(int)Enum.EnumQuoteWays.CreateOrder
                                 },
                                 new Business {
                                     BusinessID =105109102,
                                     Name ="油烟机清洗",
                                     AllowPerson =false,
                                     BusinessType =(int)Enum.EnumBusinessType.ShangMen,
                                     IsOpenService =true,PayerType=(int)Enum.EnumPayerType.User,
                                     QuoteWays =(int)Enum.EnumQuoteWays.CreateOrder,
                                     Options=new BusinessOption[]
                                     {
                                         new BusinessOption {OptionID=105109102101,Name="中式油烟机" },
                                         new BusinessOption {OptionID=105109102102,Name="西式油烟机" },
                                         new BusinessOption {OptionID=105109102103,Name="侧吸式油烟机" }
                                     }
                                 },
                                 new Business {
                                     BusinessID =105109103,
                                     Name ="空调服务",
                                     AllowPerson =false,
                                     BusinessType =(int)Enum.EnumBusinessType.ShangMen,
                                     IsOpenService =true,
                                     PayerType =(int)Enum.EnumPayerType.User,
                                     QuoteWays =(int)Enum.EnumQuoteWays.CreateOrder,
                                     Options=new BusinessOption[]
                                     {
                                         new BusinessOption {OptionID=105109103101,Name="挂式空调" },
                                         new BusinessOption {OptionID=105109103102,Name="柜式空调" }
                                     }
                                 }
                            }
                        },
                        new IndustryOption{
                            ID = 105110,
                            Name = "回收",
                            Business=new Business[]
                            {
                                new Business {
                                    BusinessID =105110101,
                                    Name ="废品回收",
                                    AllowPerson =true,
                                    BusinessType =(int)Enum.EnumBusinessType.ShangMen,
                                    IsOpenService =true,
                                    PayerType =(int)Enum.EnumPayerType.Worker,
                                    QuoteWays =(int)Enum.EnumQuoteWays.Working
                                }
                            }
                        },
                        new IndustryOption{ ID = 105111, Name = "装修设计"},
                        new IndustryOption{ ID = 105112, Name = "公司企业"},
                        new IndustryOption{ ID = 105113, Name = "手机维修"},
                        new IndustryOption{
                            ID = 105114,
                            Name = "汽车服务",
                            Business=new Business[]
                            {
                                new Business {BusinessID=105114101,Name="到店洗车", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.CreateOrder},
                                new Business {BusinessID=105114102,Name="汽车保养", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working},
                                new Business {BusinessID=105114103,Name="汽车美容", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.CreateOrder},
                                new Business {BusinessID=105114104,Name="汽车维修", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working},
                                new Business {BusinessID=105114105,Name="汽车轮胎", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.CreateOrder},
                                new Business {BusinessID=105114106,Name="汽车改装", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.Working},
                                new Business {BusinessID=105114107,Name="汽车救援", AllowPerson=false,BusinessType=(int)Enum.EnumBusinessType.YuYue,IsOpenService=true,PayerType=(int)Enum.EnumPayerType.User,QuoteWays=(int)Enum.EnumQuoteWays.CreateOrder}
                            }
                        },
                        new IndustryOption{ ID = 105115, Name = "代驾"},
                        new IndustryOption{ ID = 105116, Name = "管道疏通/打孔"},
                        new IndustryOption{ ID = 105117, Name = "装修"},
                        new IndustryOption{ ID = 105118, Name = "开锁换锁"},
                        new IndustryOption{ ID = 105119, Name = "快照/冲印"},
                        new IndustryOption{ ID = 105120, Name = "修鞋擦鞋"},
                        new IndustryOption{ ID = 105121, Name = "裁缝铺"},
                        new IndustryOption{ ID = 105122, Name = "酒店"},
                        new IndustryOption{ ID = 105123, Name = "婚庆策划"},
                        new IndustryOption{ ID = 105124, Name = "货运物流"},
                        new IndustryOption{ ID = 105125, Name = "其他"}

                    }
                });
                data.Add(new Industry
                {
                    ID = 106,
                    Name = "公共服务",
                    Childrens = new IndustryOption[]
                    {
                        new IndustryOption{ ID = 106101, Name = "居委会/街道办"},
                        new IndustryOption{ ID = 106102, Name = "水/电/燃气/供暖"},
                        new IndustryOption{ ID = 106103, Name = "派出所"},
                        new IndustryOption{ ID = 106104, Name = "医院"},
                        new IndustryOption{ ID = 106105, Name = "诊所"},
                        new IndustryOption{ ID = 106106, Name = "药店"},
                        new IndustryOption{ ID = 106107, Name = "加油站"},
                        new IndustryOption{ ID = 106108, Name = "教育培训"},
                        new IndustryOption{ ID = 106109, Name = "银行"},
                        new IndustryOption{ ID = 106110, Name = "邮政"},
                        new IndustryOption{ ID = 106111, Name = "火车票/飞机票"},
                        new IndustryOption{ ID = 106112, Name = "电信营业厅"},
                        new IndustryOption{ ID = 106113, Name = "其他"}
                    }
                });

                return data;
            }
        }
    }
}
