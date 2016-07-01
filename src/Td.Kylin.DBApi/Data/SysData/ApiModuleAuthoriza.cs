using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.Kylin.Entity;

namespace Td.Kylin.DBApi.Data.SysData
{
    /// <summary>
    /// 接口与模块授权系统数据
    /// </summary>
    public class ApiModuleAuthoriza
    {
        /// <summary>
        /// API与模块授权数据
        /// </summary>
        public static List<System_ModuleAuthorize> Data
        {
            get
            {
                List<System_ModuleAuthorize> list = new List<System_ModuleAuthorize>();

                //短信接口
                list.Add(new System_ModuleAuthorize { ServerID = "S0100", ModuleID = "U001", AppSecret = "a2228c69-119f-499f-aefc-be089fed409c", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0100", ModuleID = "U002", AppSecret = "ab11176a-224b-48f7-b669-436794546e49", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0100", ModuleID = "U003", AppSecret = "93bc82d1-bd41-4892-b3f5-0e7a554eff64", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0100", ModuleID = "V001", AppSecret = "bd4182d1-93bc-8942-f5b3-ff640e7a554e", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0100", ModuleID = "M100", AppSecret = "138f7793-3c71-4703-8014-e44c50ffadcd", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0100", ModuleID = "M200", AppSecret = "fc0af996-e039-4e14-8679-cf70505c27aa", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0100", ModuleID = "M300", AppSecret = "f60a75a6-1ed8-4cbb-9ec6-8652ebbacf97", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                
                //消息推送
                list.Add(new System_ModuleAuthorize { ServerID = "S0200", ModuleID = "T001", AppSecret = "960a08e0-9447-4530-bf59-4506873126dd", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0200", ModuleID = "T002", AppSecret = "ee55cb51-8e95-4afc-92ec-58958782e4ed", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0200", ModuleID = "T003", AppSecret = "3d16024f-d7fb-4f64-b0f1-72d0112671ea", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0200", ModuleID = "T004", AppSecret = "ed1d5820-3a29-406d-ae56-3f9c7fd3b904", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                
                //兴趣社区
                list.Add(new System_ModuleAuthorize { ServerID = "S0400", ModuleID = "U001", AppSecret = "20cf8952-d34c-4e61-aab2-fcaec01c0eae", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0400", ModuleID = "U002", AppSecret = "2db0a75a-1c28-461f-b482-b941e642cd02", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0400", ModuleID = "U003", AppSecret = "46d74140-bf58-4a60-a728-992c410f876b", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //精品汇商城
                list.Add(new System_ModuleAuthorize { ServerID = "S0500", ModuleID = "U001", AppSecret = "c5cf3512-18bc-49de-b7fc-d7889c8188df", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0500", ModuleID = "U002", AppSecret = "273b49db-3982-4e39-9440-52a591bfce40", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0500", ModuleID = "U003", AppSecret = "6e7ddda9-0245-477f-97e8-6d939a615642", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //广告
                list.Add(new System_ModuleAuthorize { ServerID = "S0600", ModuleID = "U001", AppSecret = "133b84a7-840b-4e2f-881d-0b842ec5ed54", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0600", ModuleID = "U002", AppSecret = "e070d6c8-a977-4791-a20e-023a6bf6a28b", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0600", ModuleID = "U003", AppSecret = "693891d9-dd64-48d6-9b0e-caa3e44c92a1", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //招聘
                list.Add(new System_ModuleAuthorize { ServerID = "S0700", ModuleID = "E001", AppSecret = "94d9f748-a641-4161-9ae2-07f3dbfa518b", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0700", ModuleID = "E002", AppSecret = "43f771a2-61f6-41f0-aee6-75dca6e31ecc", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0700", ModuleID = "E003", AppSecret = "308da2c4-0bef-412e-ba18-c9672ed1f7c2", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0700", ModuleID = "U001", AppSecret = "c3c3e125-91af-4a5d-9577-cf69f07a8f81", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0700", ModuleID = "U002", AppSecret = "3dcb1770-a5ba-4e6e-ac7b-bce133cac945", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0700", ModuleID = "U003", AppSecret = "a91d1d07-d33a-450d-a57d-6268f392d7c4", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //摇一摇
                list.Add(new System_ModuleAuthorize { ServerID = "S0800", ModuleID = "U001", AppSecret = "696563e7-1608-4514-adfc-9fec5c080793", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0800", ModuleID = "U002", AppSecret = "04cf82f8-20ad-4d02-902f-f7de2f5ae3c8", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0800", ModuleID = "U003", AppSecret = "194d5682-d8de-44ad-9573-8ac933e27c38", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });


                //限时福利
                list.Add(new System_ModuleAuthorize { ServerID = "S0900", ModuleID = "E001", AppSecret = "556697cb-8064-4c3a-be50-a480ce2e302f", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0900", ModuleID = "E002", AppSecret = "af5a9e3e-2159-48d4-98a2-07827e502877", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0900", ModuleID = "E003", AppSecret = "72259d51-d85a-4f21-b609-6e0d32dcd944", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0900", ModuleID = "U001", AppSecret = "638fa0b9-7712-41fc-a1f0-c13f9e1ac9df", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0900", ModuleID = "U002", AppSecret = "ef2d80e1-690d-4acc-848e-2dd77666a9d7", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S0900", ModuleID = "U003", AppSecret = "19ad0417-d090-450d-91ce-4fc30d23dcdb", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //商家商品/服务
                list.Add(new System_ModuleAuthorize { ServerID = "S1000", ModuleID = "E001", AppSecret = "49afbe33-5c52-49eb-babb-237487776757", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1000", ModuleID = "E002", AppSecret = "9db94859-3a0a-48db-828b-39d328f6e5f5", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1000", ModuleID = "E003", AppSecret = "f5972372-92ba-4077-8310-8be0e3ed6ffa", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1000", ModuleID = "U001", AppSecret = "857abc9e-6cb1-44cb-b760-896c8680954f", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1000", ModuleID = "U002", AppSecret = "56135707-e4e5-4346-ba2a-22c073b7daf6", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1000", ModuleID = "U003", AppSecret = "b8867b86-1a90-46af-8bd2-42ce412e9f30", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //上门预约
                list.Add(new System_ModuleAuthorize { ServerID = "S1100", ModuleID = "E001", AppSecret = "349db2ba-cb20-4869-ab2e-71cd37ca3b0b", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1100", ModuleID = "E002", AppSecret = "ed32fb58-dfaa-4ba3-b0a1-4e24d216de12", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1100", ModuleID = "E003", AppSecret = "ffbdc977-d8d7-452f-8256-ed285d09bedf", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1100", ModuleID = "F001", AppSecret = "e9d76fc0-1313-443a-b23d-5f23ecf75279", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1100", ModuleID = "F002", AppSecret = "77147857-6162-4dc1-a822-c501aefa2cc1", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1100", ModuleID = "F003", AppSecret = "b71fcb9a-5534-49d0-b2d6-872f99302743", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1100", ModuleID = "U001", AppSecret = "79330328-6892-4f8f-aec9-a1f29ad91d17", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1100", ModuleID = "U002", AppSecret = "a8d3af58-296c-4d65-9625-0a7085b3798e", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1100", ModuleID = "U003", AppSecret = "168c3a34-9261-4219-90fa-bcbbbebcb8f2", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //用户订单
                list.Add(new System_ModuleAuthorize { ServerID = "S1200", ModuleID = "U001", AppSecret = "6f24ce3c-af01-4e8f-8e3b-be129c335fc0", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1200", ModuleID = "U002", AppSecret = "071a4e6e-1341-4801-997c-29d801ad8933", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1200", ModuleID = "U003", AppSecret = "9e1e172e-7864-4184-a89e-18caeab9f92d", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //企业增值服务商城
                list.Add(new System_ModuleAuthorize { ServerID = "S1300", ModuleID = "E001", AppSecret = "ceef36e5-f91e-4a7a-b4f6-2472caa720c9", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1300", ModuleID = "E002", AppSecret = "b5f66d11-ddfb-435c-bfea-ef6e21439322", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1300", ModuleID = "E003", AppSecret = "31c1ebef-1291-48c1-a811-8840ec22130b", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //用户
                list.Add(new System_ModuleAuthorize { ServerID = "S1400", ModuleID = "U001", AppSecret = "d1871e36-715b-4926-8fd7-5fed4d7d55df", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1400", ModuleID = "U002", AppSecret = "cab9f6e5-55e5-4804-95be-4682c2fff978", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1400", ModuleID = "U003", AppSecret = "e1a62329-416b-49c2-8783-bf155ee590dd", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //商家
                list.Add(new System_ModuleAuthorize { ServerID = "S1500", ModuleID = "E001", AppSecret = "ddc5a0ac-c7a4-42cd-8ca1-7e431774cb1d", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1500", ModuleID = "E002", AppSecret = "99c7b378-fc05-465b-bd3f-fe664bca738f", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1500", ModuleID = "E003", AppSecret = "434ff26f-c793-46a7-a564-3070f280f4c6", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1500", ModuleID = "U001", AppSecret = "eaf186c4-817d-4a7f-9eb7-31a42ecbe8fa", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1500", ModuleID = "U002", AppSecret = "c2084927-57ff-4b34-8fe2-96ae6221c8ad", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1500", ModuleID = "U003", AppSecret = "79ce0971-c849-4f54-bc51-df778ad62975", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //员工
                list.Add(new System_ModuleAuthorize { ServerID = "S1600", ModuleID = "E001", AppSecret = "f82f5a8b-32ff-4393-97dc-737053e58fde", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1600", ModuleID = "E002", AppSecret = "c94f6a7a-d7fe-4c82-9d06-bec5a09607a2", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1600", ModuleID = "E003", AppSecret = "f5468a2a-8ad6-4738-b08a-8392aee3470f", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1600", ModuleID = "F001", AppSecret = "7a55d823-a899-4cd4-971f-1ea3e2abed15", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1600", ModuleID = "F002", AppSecret = "73e3fbb2-0992-4892-b238-30b060496333", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1600", ModuleID = "F003", AppSecret = "a9017054-dcc0-4a86-8365-325b491ec8f9", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //系统综合服务
                list.Add(new System_ModuleAuthorize { ServerID = "S1700", ModuleID = "E001", AppSecret = "238081C1-635A-40E8-91CC-6621EF4EB540", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1700", ModuleID = "E002", AppSecret = "3268A4A1-F34E-4B59-92A0-8077D4076690", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1700", ModuleID = "E003", AppSecret = "B32EF529-CE3C-4517-93CC-475B373160AB", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1700", ModuleID = "F001", AppSecret = "BE1B5A39-51B1-4657-81F0-D9DAE374AE7F", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1700", ModuleID = "F002", AppSecret = "236603C4-8D25-495B-8ED3-C6C517FB29BD", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1700", ModuleID = "F003", AppSecret = "1B8C5A0B-BC0F-4538-BE59-C7F54FE70B4A", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1700", ModuleID = "U001", AppSecret = "165FC884-182B-4487-A3D7-E2BCDDDC90FD", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1700", ModuleID = "U002", AppSecret = "1D892F4C-0851-425D-A974-EE7F69CF30F7", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1700", ModuleID = "U003", AppSecret = "6D9B0D43-C1CE-4FDC-B48A-CBC8658404F1", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //搜索
                list.Add(new System_ModuleAuthorize { ServerID = "S1800", ModuleID = "E001", AppSecret = "e564bd05-fbbf-4e2b-a095-a0f817ed9e8e", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1800", ModuleID = "E002", AppSecret = "6ea6aaf8-d81e-401f-84f9-d53c77fb3b5f", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1800", ModuleID = "E003", AppSecret = "c579b4a4-a84c-4261-9d83-1259aad2b8b0", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1800", ModuleID = "F001", AppSecret = "3dd1ad87-fb74-4542-95d4-7ab0162f01ac", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1800", ModuleID = "F002", AppSecret = "c2c302d8-a3d1-4d38-9f2f-8c48bc4fd446", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1800", ModuleID = "F003", AppSecret = "78a01de7-857e-4c69-ad88-fea79b8d1ab9", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1800", ModuleID = "U001", AppSecret = "486e8b79-b99f-4bbb-9743-71a864b1620a", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1800", ModuleID = "U002", AppSecret = "ce44be0c-11e3-4069-8e76-e539ac6e09c8", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1800", ModuleID = "U003", AppSecret = "ad296230-d855-447b-8353-4cb301d5f3cc", Role = 4, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1800", ModuleID = "M100", AppSecret = "c5bb0a27-0660-46c6-bf37-703d194e8e43", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1800", ModuleID = "M200", AppSecret = "f755178f-72b9-4a26-97fd-7eab94063cad", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1800", ModuleID = "M300", AppSecret = "c624f49b-d0b2-4985-8563-d966605ba33b", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                //配送
                list.Add(new System_ModuleAuthorize { ServerID = "S1900", ModuleID = "E001", AppSecret = "777ec773-8adb-469b-a64a-99d20f48e4db", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1900", ModuleID = "E002", AppSecret = "31065038-d588-4a24-814b-c41c777cddf2", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1900", ModuleID = "E003", AppSecret = "e4fdf7d9-2a85-4411-9afa-fe142963cf17", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1900", ModuleID = "F001", AppSecret = "5b960c00-cc06-4876-9232-43a07763fd87", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1900", ModuleID = "F002", AppSecret = "88ce28ed-09f1-4bc9-8b9a-6c5551148212", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1900", ModuleID = "F003", AppSecret = "decaa8e7-7b6e-4c07-ad90-2f2456e35b94", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1900", ModuleID = "U001", AppSecret = "56ada4e3-97fe-43ea-b102-9ef304f18a27", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1900", ModuleID = "U002", AppSecret = "d3d5f19e-8934-45d3-8e53-801090969ff6", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1900", ModuleID = "U003", AppSecret = "f2640421-8f8b-4ed4-8a35-8efe67c592ed", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1900", ModuleID = "M100", AppSecret = "3064399c-4834-4841-ad2a-be6c91a9fe28", Role = 1, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1900", ModuleID = "M200", AppSecret = "64018293-35df-42a1-8639-a474dc40891f", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });
                list.Add(new System_ModuleAuthorize { ServerID = "S1900", ModuleID = "M300", AppSecret = "05011631-04dd-4ee3-a74c-6d769742e953", Role = 2, CreateTime = DateTime.Now, UpdateTime = DateTime.Now });

                return list;
            }
        }
    }
}
