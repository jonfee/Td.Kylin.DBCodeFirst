using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.Common;
using Td.Kylin.DBApi.Core;
using Td.Kylin.Entity;

namespace Td.Kylin.DBApi.Data.SysData
{
    /// <summary>
    /// 广告位数据
    /// </summary>
    public class AdPosition
    {
        private static List<Ad_Page> _adPageList;
        private static List<Ad_Position> _adPositionList;

        /// <summary>
        /// 广告页集合
        /// </summary>
        public static List<Ad_Page> AdPageList
        {
            get
            {
                if (null == _adPageList)
                {
                    InitAdPage();
                }

                return _adPageList;
            }
        }

        /// <summary>
        /// 广告位集合
        /// </summary>
        public static List<Ad_Position> AdPositionList
        {
            get
            {
                if (null == _adPositionList)
                {
                    if (null == AdPageList)
                    {
                        InitAdPage();
                    }

                    InitAdPosition();
                }

                return _adPositionList;
            }
        }

        private static Dictionary<int, string> TerminalDic;

        /// <summary>
        /// 静态实例
        /// </summary>
        static AdPosition()
        {
            TerminalDic = EnumUtility.GetEnumDescriptions(typeof(EnumLibrary.ADTerminal));

            _adPageList = null;
            _adPositionList = null;
        }

        /// <summary>
        /// 初始化广告页
        /// </summary>
        static void InitAdPage()
        {
            _adPageList = new List<Ad_Page>();

            foreach (var kv in TerminalDic)
            {
                string[] pages = null;
                if (kv.Key == (int)EnumLibrary.ADTerminal.UserClient)
                {
                    pages = new[] { "启动页", "淘一淘首页", "附近购首页", "精品汇首页", "兴趣社区首页", "求职招聘首页", "发现首页", "附近首页" };//, "上门服务首页", "预约服务首页"
                }
                else if (kv.Key == (int)EnumLibrary.ADTerminal.MerchantClient)
                {
                    pages = new[] { "启动页" };
                }
                else if (kv.Key == (int)EnumLibrary.ADTerminal.WorkerClient)
                {
                    pages = new[] { "启动页" };
                }

                AddPage(kv.Key, pages);
            }
        }

        static void InitAdPosition()
        {
            if (null == AdPageList || AdPageList.Count < 1) return;

            _adPositionList = new List<Ad_Position>();

            foreach (var kv in TerminalDic)
            {
                var pages = AdPageList.Where(p => p.PlatformType == kv.Key);

                if (kv.Key == (int)EnumLibrary.ADTerminal.UserClient)//用户端广告位
                {
                    AddPositionForUserClient(pages);
                }
                else if (kv.Key == (int)EnumLibrary.ADTerminal.MerchantClient)//商家端广告位
                {
                    AddPositionForMerchantClient(pages);
                }
                else if (kv.Key == (int)EnumLibrary.ADTerminal.WorkerClient)//工作端广告位
                {
                    AddPositionForWorkerClient(pages);
                }
            }
        }

        /// <summary>
        /// 添加广告页到集合
        /// </summary>
        /// <param name="platformType"></param>
        /// <param name="pages"></param>
        static void AddPage(int platformType, string[] pages)
        {
            if (null == pages || pages.Length < 1) return;

            foreach (var page in pages)
            {
                _adPageList.Add(new Ad_Page
                {
                    PageID = IDProvider.NewId(),
                    PlatformType = platformType,
                    PageName = page
                });
            }
        }

        /// <summary>
        /// 添加广告位到集合  
        /// </summary>
        static void AddPosition(long pageId, string name, string code, EnumLibrary.ADDisplayType displayType, string intro, int maxCount)
        {
            Ad_Position item = new Ad_Position
            {
                ADDisplayType = (int)displayType,
                Code = code,
                CreateTime = DateTime.Now,
                Enable = true,
                Intro = intro,
                MaxCount = maxCount,
                Name = name,
                PageID = pageId,
                PositionID = IDProvider.NewId(),
                PreviewPicture = string.Format("/admin_img/advertposition/{0}.png", code)
            };
            _adPositionList.Add(item);
        }

        static void AddPositionForUserClient(IEnumerable<Ad_Page> pages)
        {
            if (null == pages || pages.Count() < 1) return;

            foreach (var page in pages)
            {
                if (page.PageName.Equals("启动页"))
                {
                    AddPosition(page.PageID, "启动广告", "U01001_startalways", EnumLibrary.ADDisplayType.TimerPass, "APP启动时展示图片，默认N秒后自动进入APP首页，无任何点击事件", 1);
                    //AddPosition(page.PageID, "产品介绍", "U01001_startproducts", EnumLibrary.ADDisplayType.SlidePass, "APP新安装/更新后首次启动APP时对APP的介绍或推荐功能的展示，一般为多张图片且无任何点击事件，一张张向后查看结束后进入APP首页", 4);
                }
                else if (page.PageName.Equals("淘一淘首页"))
                {
                    AddPosition(page.PageID, "顶部通栏Banner", "U01001_malltyt001", EnumLibrary.ADDisplayType.Viwepager, "一般为多个图片广告，自动滚动（或手动滑动）广告图可切换，点击后进入相应的内容页", 6);
                    AddPosition(page.PageID, "导航栏下左一按钮广告", "U01001_malltyt002", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "导航栏下右一按钮广告", "U01001_malltyt003", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "导航栏下右二按钮广告", "U01001_malltyt004", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "导航栏下左二按钮广告", "U01001_malltyt005", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "导航栏下右三按钮广告", "U01001_malltyt006", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    // AddPosition(page.PageID, "中部横幅", "U01001_malltyt008", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                }
                else if (page.PageName.Equals("附近购首页"))
                {
                    AddPosition(page.PageID, "左一按钮广告", "U01001_mallsjsc001", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "右一按钮广告", "U01001_mallsjsc002", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "右二按钮广告", "U01001_mallsjsc003", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "左二按钮广告", "U01001_mallsjsc004", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "右三按钮广告", "U01001_mallsjsc005", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                }
                else if (page.PageName.Equals("精品汇首页"))
                {
                    AddPosition(page.PageID, "左一按钮广告", "U01001_mallqysc001", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "右一按钮广告", "U01001_mallqysc002", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "右二按钮广告", "U01001_mallqysc003", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    //AddPosition(page.PageID, "中部左侧按钮广告", "U01001_mallqysc004", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    //AddPosition(page.PageID, "中部右一按钮广告", "U01001_mallqysc005", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    //AddPosition(page.PageID, "中部右二按钮广告", "U01001_mallqysc006", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                }
                else if (page.PageName.Equals("兴趣社区首页"))
                {
                    AddPosition(page.PageID, "顶部通栏", "U01001_forumxqsq001", EnumLibrary.ADDisplayType.Viwepager, "一般为多个图片广告，自动滚动（或手动滑动）广告图可切换，点击后进入相应的内容页", 6);
                }
                //else if (page.PageName.Equals("上门服务首页"))
                //{
                //    AddPosition(page.PageID, "顶部通栏", "U01001_servicesm001", EnumLibrary.ADDisplayType.Viwepager, "一般为多个图片广告，自动滚动（或手动滑动）广告图可切换，点击后进入相应的内容页", 6);
                //}
                //else if (page.PageName.Equals("预约服务首页"))
                //{
                //    AddPosition(page.PageID, "顶部通栏", "U01001_serviceyj001", EnumLibrary.ADDisplayType.Viwepager, "一般为多个图片广告，自动滚动（或手动滑动）广告图可切换，点击后进入相应的内容页", 6);
                //}
                else if (page.PageName.Equals("求职招聘首页"))
                {
                    AddPosition(page.PageID, "顶部通栏", "U01001_hrqzzp001", EnumLibrary.ADDisplayType.Viwepager, "一般为多个图片广告，自动滚动（或手动滑动）广告图可切换，点击后进入相应的内容页", 6);
                }
                else if (page.PageName.Equals("发现首页"))
                {
                    AddPosition(page.PageID, "顶部通栏Banner", "U01001_find001", EnumLibrary.ADDisplayType.Viwepager, "一般为多个图片广告，自动滚动（或手动滑动）广告图可切换，点击后进入相应的内容页", 6);
                    AddPosition(page.PageID, "顶部左一按钮广告", "U01001_find002", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "顶部右一按钮广告", "U01001_find003", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "中部左一按钮广告", "U01001_find004", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "中部右一按钮广告", "U01001_find005", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "中部右二按钮广告", "U01001_find006", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "中部右三按钮广告", "U01001_find007", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "中部横幅", "U01001_find008", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "底部左一按钮广告", "U01001_find009", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "底部右一按钮广告", "U01001_find010", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "底部右二按钮广告", "U01001_find011", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "底部左二按钮广告", "U01001_find012", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "底部右三按钮广告", "U01001_find013", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                }
                else if (page.PageName.Equals("附近首页"))
                {
                    AddPosition(page.PageID, "顶部通栏Banner", "U01001_nearby001", EnumLibrary.ADDisplayType.Viwepager, "一般为多个图片广告，自动滚动（或手动滑动）广告图可切换，点击后进入相应的内容页", 6);
                    AddPosition(page.PageID, "左一按钮广告", "U01001_nearby002", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "右一按钮广告", "U01001_nearby003", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "左二按钮广告", "U01001_nearby004", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                    AddPosition(page.PageID, "右二按钮广告", "U01001_nearby005", EnumLibrary.ADDisplayType.SingleImage, "一般为单个图片广告，点击后进入相应的内容页", 1);
                }
            }
        }

        static void AddPositionForMerchantClient(IEnumerable<Ad_Page> pages)
        {
            if (null == pages || pages.Count() < 1) return;

            foreach (var page in pages)
            {
                if (page.PageName.Equals("启动页"))
                {
                    AddPosition(page.PageID, "启动广告", "M01001_startalways", EnumLibrary.ADDisplayType.TimerPass, "APP启动时展示图片，默认N秒后自动进入APP首页，无任何点击事件", 1);
                    //AddPosition(page.PageID, "产品介绍", "M01001_startproducts", EnumLibrary.ADDisplayType.SlidePass, "APP新安装/更新后首次启动APP时对APP的介绍或推荐功能的展示，一般为多张图片且无任何点击事件，一张张向后查看结束后进入APP首页", 4);
                }
            }
        }

        static void AddPositionForWorkerClient(IEnumerable<Ad_Page> pages)
        {
            if (null == pages || pages.Count() < 1) return;

            foreach (var page in pages)
            {
                if (page.PageName.Equals("启动页"))
                {
                    AddPosition(page.PageID, "启动广告", "W01001_startalways", EnumLibrary.ADDisplayType.TimerPass, "APP启动时展示图片，默认N秒后自动进入APP首页，无任何点击事件", 1);
                    //AddPosition(page.PageID, "产品介绍", "W01001_startproducts", EnumLibrary.ADDisplayType.SlidePass, "APP新安装/更新后首次启动APP时对APP的介绍或推荐功能的展示，一般为多张图片且无任何点击事件，一张张向后查看结束后进入APP首页", 4);
                }
            }
        }
    }
}
