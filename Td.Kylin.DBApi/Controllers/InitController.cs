using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Td.Common;
using Td.Kylin.DBApi.Data;
using Td.Kylin.Entity;
using Td.Kylin.WebApi;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Td.Kylin.DBApi.Controllers
{
    [Route("api/init")]
    public class InitController : BaseController
    {
        #region 初始化模块授权
        /// <summary>
        /// 初始化模块授权
        /// </summary>
        /// <returns></returns>
        [HttpGet("apiauth")]
        public IActionResult InitApiModuleAuthorize()
        {
            int rows = InitProvider.InitApiMoudleAuthoriza();

            return Ok(string.Format("共初始化接口授权 {0} 项", rows));
        }
        #endregion

        #region 初始化超级管理员
        /// <summary>
        /// 初始化超级管理员
        /// </summary>
        /// <returns></returns>
        [HttpGet("superadmin")]
        public IActionResult InitSuperAdmin()
        {
            string account = "admin";

            string pwd = "123456";

            int rows = InitProvider.InitSuperAdmin(account, pwd);

            return Ok(string.Format("超级管理初始化成功！账号：{0}，密码：{1}", account, pwd));
        }
        #endregion

        #region 初始化商家行业
        /// <summary>
        /// 初始化商家行业
        /// </summary>
        /// <returns></returns>
        [HttpGet("industry")]
        public IActionResult InitIndustry()
        {
            var result = InitProvider.InitIndustry();

            return KylinOk(result);
        }
        #endregion

        #region 初始化全国行政地区
        /// <summary>
        /// 初始化全国行政地区
        /// </summary>
        /// <returns></returns>
        [HttpGet("area")]
        public IActionResult InitArea()
        {
            var result = InitProvider.InitArea();

            string txt = string.Format("本次共初始化 {0} 个区域", result);

            return KylinOk(txt);
        }
        #endregion

        #region 初始化系统默认配置
        /// <summary>
        /// 初始化全局配置項
        /// </summary>
        /// <returns></returns>
        [HttpGet("globalconfig")]
        public IActionResult InitGlobalConfig()
        {
            var result = InitProvider.InitGlobalConfig();

            string txt = string.Format("本次共初始化 {0} 个全局配置项", result);

            return KylinOk(txt);
        }
        #endregion

        #region 初始化系统广告位

        class InitAdPositionResult : Ad_Page
        {
            public string PlatformName { get; set; }
            public List<Ad_Position> PositionList { get; set; }
        }

        /// <summary>
        /// 初始化全局配置項
        /// </summary>
        /// <returns></returns>
        [HttpGet("adposition")]
        public IActionResult InitAdPosition()
        {
            List<Ad_Page> pageList = null;
            List<Ad_Position> positionList = null;

            var result = InitProvider.InitAdPosition(out pageList, out positionList);

            List<InitAdPositionResult> data = new List<InitAdPositionResult>();

            if (result > 0 && null != pageList && pageList.Count > 0)
            {
                foreach (var page in pageList)
                {
                    data.Add(new InitAdPositionResult
                    {
                        PageID = page.PageID,
                        PageName = page.PageName,
                        PlatformType = page.PlatformType,
                        PlatformName = EnumUtility.GetEnumDescription<EnumLibrary.ADTerminal>(page.PlatformType),
                        PositionList = positionList.Where(p => p.PageID == page.PageID).ToList()
                    });
                }
            }

            return KylinOk(data);
        }
        #endregion

        #region 初始化系统积分配置
        /// <summary>
        /// 初始化系统积分配置
        /// </summary>
        /// <returns></returns>
        [HttpGet("pointsconfig")]
        public IActionResult InitPointsConfig()
        {
            var result = InitProvider.InitPointsConfig();

            return KylinOk(result);
        }
        #endregion

        #region 初始化系统等级配置
        /// <summary>
        /// 初始化系统等级配置
        /// </summary>
        /// <returns></returns>
        [HttpGet("levelconfig")]
        public IActionResult InitLevelConfig()
        {
            var result = InitProvider.InitLevelConfig();

            return KylinOk(result);
        }
        #endregion

        [HttpGet("img")]
        public IActionResult GetImgUrl(int width, int height)
        {
            string img = @"http://139.129.194.132:9000/users/headphoto/6236979476647968772.jpg";

            string newImg = GetThumbnailPath(img, width, height);

            return Ok(newImg);
        }

        /// <summary>
        /// 获取缩略图地址
        /// </summary>
        /// <param name="imgUrl">原图地址，如：/upload/photo/aaa.jpg</param>
        /// <param name="width">缩略图宽度（px）</param>
        /// <param name="height">缩略图高度（px）</param>
        /// <returns></returns>
        public string GetThumbnailPath(string imgUrl, int width, int height)
        {
            if (string.IsNullOrEmpty(imgUrl)) return string.Empty;

            string[] arr = imgUrl.Split(new[] { @"\", @"/" }, StringSplitOptions.RemoveEmptyEntries);

            int len = arr.Length;

            string fn = arr[len - 1];

            arr[len - 1] = string.Format("T_W{0}H{1}_{2}", width, height, fn);

            return Path.Combine(arr).ToLower();
        }
    }
}
