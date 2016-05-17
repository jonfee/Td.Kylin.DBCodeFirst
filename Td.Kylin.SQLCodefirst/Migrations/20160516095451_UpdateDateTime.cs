using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class UpdateDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_TradeRecords",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Worker_Profile",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_Profile",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_Message",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_CompanyBusiness",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Worker_Company",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_Company",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "Worker_Company",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenServiceTime",
                table: "Worker_BusinessRelation",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_BusinessRelation",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "Worker_Account",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActiveTime",
                table: "Worker_Account",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Welfare_Remind",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Welfare_PartUser",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AwardTime",
                table: "Welfare_PartUser",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UseTime",
                table: "User_Welfare",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryStartTime",
                table: "User_Welfare",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryEndTime",
                table: "User_Welfare",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Welfare",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AwardTime",
                table: "User_Welfare",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_TradeRecords",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatetTime",
                table: "User_ShakeRecord",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                table: "User_ShakeRecord",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "User_Resume",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastRefreshTime",
                table: "User_Resume",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Resume",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "Both",
                table: "User_Resume",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User_RecommendRecord",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "BothBirthday",
                table: "User_Profiles",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_PointsRecords",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "User_Online",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActiveTime",
                table: "User_Online",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Message",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_LocationTrack",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastRead",
                table: "User_Forum",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_EmpiricalRecords",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                table: "User_Device",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Certification",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "User_Certification",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Address",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                table: "User_Account",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Account",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Tao_ProductRecommend",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Tao_ProductRecommend",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginTime",
                table: "Tao_ProductRecommend",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                table: "System_SMS",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "System_SMS",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "System_PointsConfig",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "System_ModuleAuthorize",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "System_ModuleAuthorize",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "System_Level",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "System_GlobalResources",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "System_EmpiricalConfig",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "System_Area",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastPayTime",
                table: "Shake_UserRecord",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Shake_UserRecord",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Shake_Content",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                table: "Shake_Content",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Shake_Content",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Shake_Content",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "Shake_Content",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionTime",
                table: "Platform_MoneyTransaction",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "MerchService_Goods",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "MerchGoods_Goods",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "MerchGoods_Category",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "MerchantGoods_SystemCategory",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LotteryTime",
                table: "Merchant_Welfare",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryStartTime",
                table: "Merchant_Welfare",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryEndTime",
                table: "Merchant_Welfare",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Welfare",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "Merchant_Welfare",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ApplyStartTime",
                table: "Merchant_Welfare",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ApplyEndTime",
                table: "Merchant_Welfare",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_TradeRecords",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Merchant_RecommendRecord",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "SendTime",
                table: "Merchant_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedTime",
                table: "Merchant_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PayTime",
                table: "Merchant_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                table: "Merchant_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Order",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelTime",
                table: "Merchant_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Message",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Industry",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReplyTime",
                table: "Merchant_Evaluate",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Evaluate",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Merchant_Config",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Certificate",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "Merchant_Certificate",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenServiceTime",
                table: "Merchant_Business",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Business",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Account",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Mall_ShoppingCart",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_ShoppingCart",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_PromotionProductRelevance",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Mall_Promotion",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_Promotion",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginTime",
                table: "Mall_Promotion",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Mall_Product",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_Product",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ShipTime",
                table: "Mall_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedTime",
                table: "Mall_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PayTime",
                table: "Mall_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "NeedPayTime",
                table: "Mall_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                table: "Mall_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_Order",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelTime",
                table: "Mall_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReplyTime",
                table: "Mall_Evaluate",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_Evaluate",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_CategoryTag",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                table: "Mall_Category",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_Category",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "SubmitTime",
                table: "Legwork_Order",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "RequiredPickTime",
                table: "Legwork_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "RequiredDeliveryTime",
                table: "Legwork_Order",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentTime",
                table: "Legwork_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "OfferAcceptTime",
                table: "Legwork_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                table: "Legwork_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CompleteTime",
                table: "Legwork_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelTime",
                table: "Legwork_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActualPickTime",
                table: "Legwork_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActualDeliveryTime",
                table: "Legwork_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Legwork_OfferRecord",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Legwork_GoodsCategory",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Legwork_Evaluate",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkerFinishTime",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UserFinishTime",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ServiceStartTime",
                table: "KylinService_Order",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedTime",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PaiedTime",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "KylinService_Order",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ConfirmTime",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelTime",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AllotTime",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "KylinService_BusinessOptions",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "KylinService_BusinessConfig",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "KylinService_Business",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Job_Searcher",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastRefreshTime",
                table: "Job_Recruitment",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Job_Recruitment",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Job_Category",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Job_Apply",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Job_Apply",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Complaint",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Commission_Platform",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Commission_OperatorFromWorker",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Commission_OperatorFromMerchant",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Commission_OperatorDefault",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                table: "Circle_Topic",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Topic",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Respond",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_PostTrend",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Post",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Good",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                table: "Circle_Forum",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Forum",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                table: "Circle_Follow",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Follow",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_EventUser",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Circle_Event",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Circle_Event",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Event",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckTime",
                table: "Circle_CheckIn",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                table: "Circle_Category",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Category",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadTime",
                table: "Circle_Attachment",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                table: "Circle_Attachment",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                table: "Circle_AreaForum",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_AreaForum",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "AreaOperator_TradeRecords",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Area_OperatorRelation",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Area_OperatorRelation",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Area_OperatorRelation",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Area_Operator",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Area_Open",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Agent_AreaRelation",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Agent_AreaRelation",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Agent_AreaRelation",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Agent_Account",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Admin_Permission",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                table: "Admin_Account",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Admin_Account",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Ad_Position",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Ad_PlatformToArea",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Ad_PlatformToArea",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Ad_PlatformContent",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Ad_PlatformContent",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Ad_PlatformContent",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Ad_Content",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Ad_Content",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Ad_Content",
                type: "datetime",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_TradeRecords",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Worker_Profile",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_Profile",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_Message",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_CompanyBusiness",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Worker_Company",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_Company",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "Worker_Company",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenServiceTime",
                table: "Worker_BusinessRelation",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_BusinessRelation",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "Worker_Account",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActiveTime",
                table: "Worker_Account",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Welfare_Remind",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Welfare_PartUser",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AwardTime",
                table: "Welfare_PartUser",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UseTime",
                table: "User_Welfare",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryStartTime",
                table: "User_Welfare",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryEndTime",
                table: "User_Welfare",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Welfare",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AwardTime",
                table: "User_Welfare",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_TradeRecords",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatetTime",
                table: "User_ShakeRecord",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                table: "User_ShakeRecord",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "User_Resume",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastRefreshTime",
                table: "User_Resume",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Resume",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "Both",
                table: "User_Resume",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User_RecommendRecord",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "BothBirthday",
                table: "User_Profiles",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_PointsRecords",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "User_Online",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActiveTime",
                table: "User_Online",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Message",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_LocationTrack",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastRead",
                table: "User_Forum",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_EmpiricalRecords",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                table: "User_Device",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Certification",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "User_Certification",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Address",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                table: "User_Account",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Account",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Tao_ProductRecommend",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Tao_ProductRecommend",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginTime",
                table: "Tao_ProductRecommend",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                table: "System_SMS",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "System_SMS",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "System_PointsConfig",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "System_ModuleAuthorize",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "System_ModuleAuthorize",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "System_Level",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "System_GlobalResources",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "System_EmpiricalConfig",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "System_Area",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastPayTime",
                table: "Shake_UserRecord",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Shake_UserRecord",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Shake_Content",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                table: "Shake_Content",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Shake_Content",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Shake_Content",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "Shake_Content",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionTime",
                table: "Platform_MoneyTransaction",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "MerchService_Goods",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "MerchGoods_Goods",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "MerchGoods_Category",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "MerchantGoods_SystemCategory",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LotteryTime",
                table: "Merchant_Welfare",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryStartTime",
                table: "Merchant_Welfare",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryEndTime",
                table: "Merchant_Welfare",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Welfare",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "Merchant_Welfare",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ApplyStartTime",
                table: "Merchant_Welfare",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ApplyEndTime",
                table: "Merchant_Welfare",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_TradeRecords",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Merchant_RecommendRecord",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "SendTime",
                table: "Merchant_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedTime",
                table: "Merchant_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PayTime",
                table: "Merchant_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                table: "Merchant_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Order",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelTime",
                table: "Merchant_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Message",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Industry",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReplyTime",
                table: "Merchant_Evaluate",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Evaluate",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Merchant_Config",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Certificate",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "Merchant_Certificate",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenServiceTime",
                table: "Merchant_Business",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Business",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Account",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Mall_ShoppingCart",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_ShoppingCart",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_PromotionProductRelevance",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Mall_Promotion",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_Promotion",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginTime",
                table: "Mall_Promotion",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Mall_Product",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_Product",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ShipTime",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedTime",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PayTime",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "NeedPayTime",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_Order",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelTime",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReplyTime",
                table: "Mall_Evaluate",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_Evaluate",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_CategoryTag",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                table: "Mall_Category",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_Category",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "SubmitTime",
                table: "Legwork_Order",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "RequiredPickTime",
                table: "Legwork_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "RequiredDeliveryTime",
                table: "Legwork_Order",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentTime",
                table: "Legwork_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "OfferAcceptTime",
                table: "Legwork_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                table: "Legwork_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CompleteTime",
                table: "Legwork_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelTime",
                table: "Legwork_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActualPickTime",
                table: "Legwork_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActualDeliveryTime",
                table: "Legwork_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Legwork_OfferRecord",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Legwork_GoodsCategory",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Legwork_Evaluate",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkerFinishTime",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UserFinishTime",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ServiceStartTime",
                table: "KylinService_Order",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedTime",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PaiedTime",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "KylinService_Order",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ConfirmTime",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelTime",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AllotTime",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "KylinService_BusinessOptions",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "KylinService_BusinessConfig",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "KylinService_Business",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Job_Searcher",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastRefreshTime",
                table: "Job_Recruitment",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Job_Recruitment",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Job_Category",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Job_Apply",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Job_Apply",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Complaint",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Commission_Platform",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Commission_OperatorFromWorker",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Commission_OperatorFromMerchant",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Commission_OperatorDefault",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                table: "Circle_Topic",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Topic",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Respond",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_PostTrend",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Post",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Good",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                table: "Circle_Forum",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Forum",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                table: "Circle_Follow",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Follow",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_EventUser",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Circle_Event",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Circle_Event",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Event",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckTime",
                table: "Circle_CheckIn",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                table: "Circle_Category",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Category",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadTime",
                table: "Circle_Attachment",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                table: "Circle_Attachment",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                table: "Circle_AreaForum",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_AreaForum",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "AreaOperator_TradeRecords",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Area_OperatorRelation",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Area_OperatorRelation",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Area_OperatorRelation",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Area_Operator",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Area_Open",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Agent_AreaRelation",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Agent_AreaRelation",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Agent_AreaRelation",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Agent_Account",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Admin_Permission",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                table: "Admin_Account",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Admin_Account",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Ad_Position",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Ad_PlatformToArea",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Ad_PlatformToArea",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Ad_PlatformContent",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Ad_PlatformContent",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Ad_PlatformContent",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Ad_Content",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Ad_Content",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Ad_Content",
                nullable: false);
        }
    }
}
