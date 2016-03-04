using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class AddDataRowVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Worker_TradeRecords",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Worker_Profile",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Worker_Message",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Worker_CompanyBusiness",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Worker_Company",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Worker_Certification",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Worker_Business",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Worker_Account",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Welfare_Remind",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Welfare_Phases",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Welfare_PartUser",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Welfare_Goods",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Welfare_DonatedGoods",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Welfare_Coupon",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "User_Welfare",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "User_TradeRecords",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "User_ShakeRecord",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "User_Resume",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "User_Profiles",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "User_Online",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "User_Message",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "User_LocationTrack",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "User_Forum",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "User_Device",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "User_Address",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "User_Account",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "System_SMS",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "System_ModuleAuthorize",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Shake_UserRecord",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Shake_Content",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "MerchService_Goods",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "MerchGoods_Goods",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "MerchGoods_Category",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Merchant_Welfare",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Merchant_TradeRecords",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Merchant_Message",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Merchant_Industry",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Merchant_Certificate",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Merchant_Business",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Merchant_Account",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Mall_ShoppingCart",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Mall_PromotionProductRelevance",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Mall_PromotionConfig",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Mall_Promotion",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Mall_ProductSKU",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Mall_Product",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Mall_OrderProductSnapshot",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Mall_EvaluateStatistics",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Mall_Evaluate",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Mall_CategoryTag",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Mall_Category",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "KylinService_BusinessOptions",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "KylinService_BusinessConfig",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "KylinService_Business",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Job_Searcher",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Job_Recruitment",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Job_Category",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Job_Apply",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Complaint",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_Topic",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_Respond",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_PostTrend",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_Post",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_Location",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_Level",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_Good",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_Forum",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_Follow",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_EventUser",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_Event",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_CheckIn",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_Category",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_AttachmentUsage",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Circle_Attachment",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Area_OperatorRelation",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Area_OperatorProfile",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Area_Operator",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Admin_Permission",
                nullable: true);
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "dbo",
                table: "Admin_Account",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Worker_TradeRecords");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Worker_Message");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Worker_CompanyBusiness");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Worker_Company");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Worker_Certification");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Worker_Business");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Welfare_Remind");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Welfare_Phases");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Welfare_PartUser");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Welfare_Goods");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Welfare_DonatedGoods");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Welfare_Coupon");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "User_Welfare");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "User_TradeRecords");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "User_ShakeRecord");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "User_Resume");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "User_Profiles");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "User_Online");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "User_Message");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "User_LocationTrack");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "User_Forum");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "User_Device");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "User_Address");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "User_Account");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "System_SMS");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "System_ModuleAuthorize");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Shake_UserRecord");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Shake_Content");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "MerchGoods_Goods");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "MerchGoods_Category");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Merchant_Welfare");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Merchant_TradeRecords");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Merchant_Message");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Merchant_Industry");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Merchant_Certificate");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Merchant_Business");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Mall_ShoppingCart");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Mall_PromotionProductRelevance");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Mall_PromotionConfig");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Mall_Promotion");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Mall_ProductSKU");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Mall_Product");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Mall_OrderProductSnapshot");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Mall_Order");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Mall_EvaluateStatistics");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Mall_Evaluate");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Mall_CategoryTag");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Mall_Category");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "KylinService_Order");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "KylinService_BusinessOptions");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "KylinService_BusinessConfig");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "KylinService_Business");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Job_Searcher");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Job_Recruitment");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Job_Category");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Job_Apply");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Complaint");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_Topic");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_Respond");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_PostTrend");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_Post");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_Location");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_Level");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_Good");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_Follow");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_EventUser");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_Event");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_CheckIn");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_Category");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_AttachmentUsage");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Circle_Attachment");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Area_OperatorRelation");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Area_OperatorProfile");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Area_Operator");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Admin_Permission");
            migrationBuilder.DropColumn(name: "RowVersion", schema: "dbo", table: "Admin_Account");
        }
    }
}
