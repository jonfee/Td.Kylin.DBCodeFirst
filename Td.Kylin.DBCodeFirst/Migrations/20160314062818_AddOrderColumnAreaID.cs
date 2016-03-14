using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class AddOrderColumnAreaID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                schema: "dbo",
                table: "Worker_TradeRecords",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Worker_TradeRecords",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                schema: "dbo",
                table: "Worker_Profile",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Nation",
                schema: "dbo",
                table: "Worker_Profile",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Worker_Profile",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "JiGuan",
                schema: "dbo",
                table: "Worker_Profile",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Intro",
                schema: "dbo",
                table: "Worker_Profile",
                type: "text",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Worker_Profile",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                schema: "dbo",
                table: "Worker_Profile",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "dbo",
                table: "Worker_Profile",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "dbo",
                table: "Worker_Message",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Sign",
                schema: "dbo",
                table: "Worker_Message",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Worker_Message",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "Worker_Message",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                schema: "dbo",
                table: "Worker_Company",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Worker_Company",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                schema: "dbo",
                table: "Worker_Company",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Worker_Certification",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Worker_Certification",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                schema: "dbo",
                table: "Worker_Certification",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                schema: "dbo",
                table: "Worker_Certification",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditAdminName",
                schema: "dbo",
                table: "Worker_Certification",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenServiceTime",
                schema: "dbo",
                table: "Worker_Business",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Worker_Business",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "AudtiAdminName",
                schema: "dbo",
                table: "Worker_Business",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                schema: "dbo",
                table: "Worker_Business",
                type: "varchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Worker_Account",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Welfare_Remind",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StopTime",
                schema: "dbo",
                table: "Welfare_Phases",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                schema: "dbo",
                table: "Welfare_Phases",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LotteryTime",
                schema: "dbo",
                table: "Welfare_Phases",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Welfare_Phases",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Welfare_PartUser",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AwardTime",
                schema: "dbo",
                table: "Welfare_PartUser",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UseTime",
                schema: "dbo",
                table: "User_Welfare",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                schema: "dbo",
                table: "User_Welfare",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "User_Welfare",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "MerchantName",
                schema: "dbo",
                table: "User_Welfare",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryStartTime",
                schema: "dbo",
                table: "User_Welfare",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryEndTime",
                schema: "dbo",
                table: "User_Welfare",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User_Welfare",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AwardTime",
                schema: "dbo",
                table: "User_Welfare",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                schema: "dbo",
                table: "User_TradeRecords",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User_TradeRecords",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatetTime",
                schema: "dbo",
                table: "User_ShakeRecord",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                schema: "dbo",
                table: "User_ShakeRecord",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "WantWordArea",
                schema: "dbo",
                table: "User_Resume",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                schema: "dbo",
                table: "User_Resume",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "RealName",
                schema: "dbo",
                table: "User_Resume",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastRefreshTime",
                schema: "dbo",
                table: "User_Resume",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "JobName",
                schema: "dbo",
                table: "User_Resume",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Intro",
                schema: "dbo",
                table: "User_Resume",
                type: "text",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User_Resume",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "Both",
                schema: "dbo",
                table: "User_Resume",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                schema: "dbo",
                table: "User_Profiles",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PresentAddress",
                schema: "dbo",
                table: "User_Profiles",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "BothBirthday",
                schema: "dbo",
                table: "User_Profiles",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActiveTime",
                schema: "dbo",
                table: "User_Online",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "dbo",
                table: "User_Message",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Sign",
                schema: "dbo",
                table: "User_Message",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User_Message",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "User_Message",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User_LocationTrack",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastRead",
                schema: "dbo",
                table: "User_Forum",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                schema: "dbo",
                table: "User_Device",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "DeviceName",
                schema: "dbo",
                table: "User_Device",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Linkman",
                schema: "dbo",
                table: "User_Address",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User_Address",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Community",
                schema: "dbo",
                table: "User_Address",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "dbo",
                table: "User_Address",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                schema: "dbo",
                table: "User_Account",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                schema: "dbo",
                table: "User_Account",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User_Account",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                schema: "dbo",
                table: "System_SMS",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "System_SMS",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "System_SMS",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                schema: "dbo",
                table: "System_ModuleAuthorize",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "System_ModuleAuthorize",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                schema: "dbo",
                table: "System_Area",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "AreaName",
                schema: "dbo",
                table: "System_Area",
                type: "varchar(15)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "dbo",
                table: "Shake_UserRecord",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastPayTime",
                schema: "dbo",
                table: "Shake_UserRecord",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Shake_UserRecord",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "dbo",
                table: "Shake_Content",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                schema: "dbo",
                table: "Shake_Content",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                schema: "dbo",
                table: "Shake_Content",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                schema: "dbo",
                table: "Shake_Content",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Shake_Content",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "Shake_Content",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "MerchService_Goods",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                schema: "dbo",
                table: "MerchGoods_Goods",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pic",
                schema: "dbo",
                table: "MerchGoods_Goods",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "MerchGoods_Goods",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "MerchGoods_Goods",
                type: "nvarchar(140)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "MerchGoods_Goods",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "MerchGoods_Category",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "MerchGoods_Category",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                schema: "dbo",
                table: "Merchant_Welfare",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Regular",
                schema: "dbo",
                table: "Merchant_Welfare",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Merchant_Welfare",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "MerchantName",
                schema: "dbo",
                table: "Merchant_Welfare",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Intro",
                schema: "dbo",
                table: "Merchant_Welfare",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryStartTime",
                schema: "dbo",
                table: "Merchant_Welfare",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryEndTime",
                schema: "dbo",
                table: "Merchant_Welfare",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Merchant_Welfare",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                schema: "dbo",
                table: "Merchant_Welfare",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                schema: "dbo",
                table: "Merchant_Welfare",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditAdminName",
                schema: "dbo",
                table: "Merchant_Welfare",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                schema: "dbo",
                table: "Merchant_TradeRecords",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Merchant_TradeRecords",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Merchant_OrderSnapshot",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "SendTime",
                schema: "dbo",
                table: "Merchant_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                schema: "dbo",
                table: "Merchant_Order",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedTime",
                schema: "dbo",
                table: "Merchant_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PayTime",
                schema: "dbo",
                table: "Merchant_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                schema: "dbo",
                table: "Merchant_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "DeliveryInfo",
                schema: "dbo",
                table: "Merchant_Order",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Merchant_Order",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelTime",
                schema: "dbo",
                table: "Merchant_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "dbo",
                table: "Merchant_Message",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Sign",
                schema: "dbo",
                table: "Merchant_Message",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Merchant_Message",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "Merchant_Message",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Merchant_Industry",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Merchant_Industry",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Merchant_Certificate",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Merchant_Certificate",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                schema: "dbo",
                table: "Merchant_Certificate",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                schema: "dbo",
                table: "Merchant_Certificate",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditAdminName",
                schema: "dbo",
                table: "Merchant_Certificate",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenServiceTime",
                schema: "dbo",
                table: "Merchant_Business",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Merchant_Business",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "AudtiAdminName",
                schema: "dbo",
                table: "Merchant_Business",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                schema: "dbo",
                table: "Merchant_Business",
                type: "varchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Street",
                schema: "dbo",
                table: "Merchant_Account",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Merchant_Account",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LocationPlace",
                schema: "dbo",
                table: "Merchant_Account",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                schema: "dbo",
                table: "Merchant_Account",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Merchant_Account",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Merchant_Account",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                schema: "dbo",
                table: "Mall_ShoppingCart",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Mall_ShoppingCart",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Mall_PromotionProductRelevance",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                schema: "dbo",
                table: "Mall_PromotionConfig",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Mall_Promotion",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                schema: "dbo",
                table: "Mall_Promotion",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Mall_Promotion",
                type: "text",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Mall_Promotion",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginTime",
                schema: "dbo",
                table: "Mall_Promotion",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Specs",
                schema: "dbo",
                table: "Mall_ProductSKU",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "VenderName",
                schema: "dbo",
                table: "Mall_Product",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                schema: "dbo",
                table: "Mall_Product",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                schema: "dbo",
                table: "Mall_Product",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Mall_Product",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Mall_Product",
                type: "text",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Mall_Product",
                nullable: false);
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Mall_Product",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AlterColumn<string>(
                name: "VenderName",
                schema: "dbo",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Specs",
                schema: "dbo",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                schema: "dbo",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PromotionTags",
                schema: "dbo",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Mall_OrderProductSnapshot",
                type: "text",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ShipTime",
                schema: "dbo",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                schema: "dbo",
                table: "Mall_Order",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedTime",
                schema: "dbo",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ProductInfo",
                schema: "dbo",
                table: "Mall_Order",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PayTime",
                schema: "dbo",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "NeedPayTime",
                schema: "dbo",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ExpressCompany",
                schema: "dbo",
                table: "Mall_Order",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                schema: "dbo",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "DeliveryInfo",
                schema: "dbo",
                table: "Mall_Order",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Mall_Order",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelTime",
                schema: "dbo",
                table: "Mall_Order",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Mall_Order",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReplyTime",
                schema: "dbo",
                table: "Mall_Evaluate",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Mall_Evaluate",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Contents",
                schema: "dbo",
                table: "Mall_Evaluate",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TagName",
                schema: "dbo",
                table: "Mall_CategoryTag",
                type: "varchar(8)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Mall_CategoryTag",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Mall_Category",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Mall_Category",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                schema: "dbo",
                table: "Mall_Category",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Mall_Category",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "WorkerRemark",
                schema: "dbo",
                table: "KylinService_Order",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkerFinishTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserRemark",
                schema: "dbo",
                table: "KylinService_Order",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "dbo",
                table: "KylinService_Order",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UserFinishTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ServiceStartTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "ServiceContent",
                schema: "dbo",
                table: "KylinService_Order",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ServiceAddress",
                schema: "dbo",
                table: "KylinService_Order",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PaiedTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ConfirmTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AllotTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                schema: "dbo",
                table: "KylinService_BusinessOptions",
                type: "varchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "KylinService_BusinessOptions",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "KylinService_BusinessOptions",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                schema: "dbo",
                table: "KylinService_BusinessConfig",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                schema: "dbo",
                table: "KylinService_BusinessConfig",
                type: "varchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "KylinService_Business",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "KylinService_Business",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "WordAddress",
                schema: "dbo",
                table: "Job_Searcher",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "SearcherName",
                schema: "dbo",
                table: "Job_Searcher",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "JobName",
                schema: "dbo",
                table: "Job_Searcher",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Job_Searcher",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "WordAddress",
                schema: "dbo",
                table: "Job_Recruitment",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastRefreshTime",
                schema: "dbo",
                table: "Job_Recruitment",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "JobName",
                schema: "dbo",
                table: "Job_Recruitment",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Job_Recruitment",
                type: "text",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Job_Recruitment",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "ContactMan",
                schema: "dbo",
                table: "Job_Recruitment",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Job_Category",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Job_Category",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                schema: "dbo",
                table: "Job_Apply",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Job_Apply",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                schema: "dbo",
                table: "Complaint",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Complaint",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "Complaint",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ComplainantName",
                schema: "dbo",
                table: "Complaint",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                schema: "dbo",
                table: "Circle_Topic",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "dbo",
                table: "Circle_Topic",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                schema: "dbo",
                table: "Circle_Topic",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Circle_Topic",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "Circle_Topic",
                type: "text",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                schema: "dbo",
                table: "Circle_Respond",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ReplyUsername",
                schema: "dbo",
                table: "Circle_Respond",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Circle_Respond",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "Circle_Respond",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Circle_PostTrend",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "Circle_PostTrend",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                schema: "dbo",
                table: "Circle_Post",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "dbo",
                table: "Circle_Post",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Circle_Post",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "Circle_Post",
                type: "text",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Circle_Level",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Circle_Level",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                schema: "dbo",
                table: "Circle_Good",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Circle_Good",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "dbo",
                table: "Circle_Good",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Moderators",
                schema: "dbo",
                table: "Circle_Forum",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ForumName",
                schema: "dbo",
                table: "Circle_Forum",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Circle_Forum",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                schema: "dbo",
                table: "Circle_Forum",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Circle_Forum",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                schema: "dbo",
                table: "Circle_Follow",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Circle_Follow",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                schema: "dbo",
                table: "Circle_EventUser",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Circle_EventUser",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                schema: "dbo",
                table: "Circle_Event",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                schema: "dbo",
                table: "Circle_Event",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Circle_Event",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "dbo",
                table: "Circle_Event",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckTime",
                schema: "dbo",
                table: "Circle_CheckIn",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Circle_Category",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                schema: "dbo",
                table: "Circle_Category",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Circle_Category",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadTime",
                schema: "dbo",
                table: "Circle_Attachment",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteTime",
                schema: "dbo",
                table: "Circle_Attachment",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                schema: "dbo",
                table: "Area_OperatorRelation",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                schema: "dbo",
                table: "Area_OperatorRelation",
                type: "varchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                schema: "dbo",
                table: "Area_OperatorRelation",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                schema: "dbo",
                table: "Area_OperatorRelation",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Area_OperatorRelation",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "LocationPlace",
                schema: "dbo",
                table: "Area_OperatorProfile",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                schema: "dbo",
                table: "Area_OperatorProfile",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Area_Operator",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Area_Open",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "AreaName",
                schema: "dbo",
                table: "Area_Open",
                type: "varchar(15)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Admin_Permission",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                schema: "dbo",
                table: "Admin_Account",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Realname",
                schema: "dbo",
                table: "Admin_Account",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastTime",
                schema: "dbo",
                table: "Admin_Account",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Admin_Account",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Ad_Position",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Intro",
                schema: "dbo",
                table: "Ad_Position",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                schema: "dbo",
                table: "Ad_Position",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Ad_Position",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "PageName",
                schema: "dbo",
                table: "Ad_Page",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "dbo",
                table: "Ad_Content",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                schema: "dbo",
                table: "Ad_Content",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Html",
                schema: "dbo",
                table: "Ad_Content",
                type: "text",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                schema: "dbo",
                table: "Ad_Content",
                nullable: false);
            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                schema: "dbo",
                table: "Ad_Content",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Ad_Content",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Body",
                schema: "dbo",
                table: "Ad_Content",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.RenameTable(
                name: "Worker_TradeRecords",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_Profile",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_Message",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_CompanyBusiness",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_Company",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_Certification",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_Business",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_Account",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Welfare_Remind",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Welfare_Phases",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Welfare_PartUser",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Welfare_Goods",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Welfare_DonatedGoods",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Welfare_Coupon",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Welfare",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_TradeRecords",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_ShakeRecord",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Resume",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Profiles",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Online",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Message",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_LocationTrack",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Forum",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Device",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Address",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Account",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "System_SMS",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "System_ModuleAuthorize",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "System_Area",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Shake_UserRecord",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Shake_Content",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "MerchService_Goods",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "MerchGoods_Goods",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "MerchGoods_Category",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Welfare",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_TradeRecords",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_OrderSnapshot",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Order",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Message",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Industry",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Certificate",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Business",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Account",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_ShoppingCart",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_PromotionProductRelevance",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_PromotionConfig",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_Promotion",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_ProductSKU",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_Product",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_OrderProductSnapshot",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_Order",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_EvaluateStatistics",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_Evaluate",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_CategoryTag",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_Category",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "KylinService_Order",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "KylinService_BusinessOptions",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "KylinService_BusinessConfig",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "KylinService_Business",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Job_Searcher",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Job_Recruitment",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Job_Category",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Job_Apply",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Complaint",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Topic",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Respond",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_PostTrend",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Post",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Location",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Level",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Good",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Forum",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Follow",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_EventUser",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Event",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_CheckIn",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Category",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_AttachmentUsage",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Attachment",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Area_OperatorRelation",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Area_OperatorProfile",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Area_Operator",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Area_Open",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Admin_Permission",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Admin_Account",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Ad_Position",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Ad_Page",
                schema: "dbo");
            migrationBuilder.RenameTable(
                name: "Ad_Content",
                schema: "dbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AreaID", table: "Mall_Product");
            migrationBuilder.DropColumn(name: "AreaID", table: "Mall_Order");
            migrationBuilder.EnsureSchema("dbo");
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                table: "Worker_TradeRecords",
                type: "nvarchar(100)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Nation",
                table: "Worker_Profile",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Worker_Profile",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "JiGuan",
                table: "Worker_Profile",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Intro",
                table: "Worker_Profile",
                type: "nvarchar(max)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_Profile",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Worker_Profile",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Worker_Profile",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Worker_Message",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Sign",
                table: "Worker_Message",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_Message",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Worker_Message",
                type: "nvarchar(500)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Worker_Certification",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_Certification",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                table: "Worker_Certification",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                table: "Worker_Certification",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditAdminName",
                table: "Worker_Certification",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenServiceTime",
                table: "Worker_Business",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_Business",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "AudtiAdminName",
                table: "Worker_Business",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                table: "Worker_Business",
                type: "nvarchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_Account",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Welfare_Remind",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StopTime",
                table: "Welfare_Phases",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Welfare_Phases",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LotteryTime",
                table: "Welfare_Phases",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Welfare_Phases",
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
            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                table: "User_Welfare",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User_Welfare",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "MerchantName",
                table: "User_Welfare",
                type: "nvarchar(50)",
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
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                table: "User_TradeRecords",
                type: "nvarchar(100)",
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
            migrationBuilder.AlterColumn<string>(
                name: "WantWordArea",
                table: "User_Resume",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "User_Resume",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "RealName",
                table: "User_Resume",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastRefreshTime",
                table: "User_Resume",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "JobName",
                table: "User_Resume",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Intro",
                table: "User_Resume",
                type: "nvarchar(max)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "User_Profiles",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PresentAddress",
                table: "User_Profiles",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "BothBirthday",
                table: "User_Profiles",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActiveTime",
                table: "User_Online",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "User_Message",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Sign",
                table: "User_Message",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Message",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "User_Message",
                type: "nvarchar(500)",
                nullable: true);
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
                name: "LastTime",
                table: "User_Device",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "DeviceName",
                table: "User_Device",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Linkman",
                table: "User_Address",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "User_Address",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Community",
                table: "User_Address",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "User_Address",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User_Account",
                type: "nvarchar(50)",
                nullable: true);
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
                name: "Expires",
                table: "System_SMS",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "System_SMS",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "System_SMS",
                type: "nvarchar(200)",
                nullable: true);
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
                name: "UpdateTime",
                table: "System_Area",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "AreaName",
                table: "System_Area",
                type: "nvarchar(15)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Shake_UserRecord",
                type: "nvarchar(50)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Shake_Content",
                type: "nvarchar(50)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Shake_Content",
                type: "nvarchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "MerchService_Goods",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                table: "MerchGoods_Goods",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pic",
                table: "MerchGoods_Goods",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MerchGoods_Goods",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MerchGoods_Goods",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "MerchGoods_Goods",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MerchGoods_Category",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "MerchGoods_Category",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                table: "Merchant_Welfare",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Regular",
                table: "Merchant_Welfare",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_Welfare",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "MerchantName",
                table: "Merchant_Welfare",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Intro",
                table: "Merchant_Welfare",
                type: "nvarchar(500)",
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
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                table: "Merchant_Welfare",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditAdminName",
                table: "Merchant_Welfare",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                table: "Merchant_TradeRecords",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_TradeRecords",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_OrderSnapshot",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "SendTime",
                table: "Merchant_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Merchant_Order",
                type: "nvarchar(200)",
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
            migrationBuilder.AlterColumn<string>(
                name: "DeliveryInfo",
                table: "Merchant_Order",
                type: "nvarchar(200)",
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
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Merchant_Message",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Sign",
                table: "Merchant_Message",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Message",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Merchant_Message",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_Industry",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Merchant_Industry",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_Certificate",
                type: "nvarchar(50)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                table: "Merchant_Certificate",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditAdminName",
                table: "Merchant_Certificate",
                type: "nvarchar(20)",
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
            migrationBuilder.AlterColumn<string>(
                name: "AudtiAdminName",
                table: "Merchant_Business",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                table: "Merchant_Business",
                type: "nvarchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Merchant_Account",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_Account",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LocationPlace",
                table: "Merchant_Account",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                table: "Merchant_Account",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Merchant_Account",
                type: "nvarchar(500)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Mall_PromotionConfig",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mall_Promotion",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Mall_Promotion",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Mall_Promotion",
                type: "nvarchar(max)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Specs",
                table: "Mall_ProductSKU",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "VenderName",
                table: "Mall_Product",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "Mall_Product",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "Mall_Product",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mall_Product",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Mall_Product",
                type: "nvarchar(max)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_Product",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "VenderName",
                table: "Mall_OrderProductSnapshot",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Specs",
                table: "Mall_OrderProductSnapshot",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "Mall_OrderProductSnapshot",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PromotionTags",
                table: "Mall_OrderProductSnapshot",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mall_OrderProductSnapshot",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Mall_OrderProductSnapshot",
                type: "nvarchar(max)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ShipTime",
                table: "Mall_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Mall_Order",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedTime",
                table: "Mall_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ProductInfo",
                table: "Mall_Order",
                type: "nvarchar(100)",
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
            migrationBuilder.AlterColumn<string>(
                name: "ExpressCompany",
                table: "Mall_Order",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                table: "Mall_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "DeliveryInfo",
                table: "Mall_Order",
                type: "nvarchar(200)",
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
            migrationBuilder.AlterColumn<string>(
                name: "Contents",
                table: "Mall_Evaluate",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TagName",
                table: "Mall_CategoryTag",
                type: "nvarchar(8)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Mall_CategoryTag",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mall_Category",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Mall_Category",
                type: "nvarchar(100)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "WorkerRemark",
                table: "KylinService_Order",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkerFinishTime",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserRemark",
                table: "KylinService_Order",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "KylinService_Order",
                type: "nvarchar(20)",
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
            migrationBuilder.AlterColumn<string>(
                name: "ServiceContent",
                table: "KylinService_Order",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ServiceAddress",
                table: "KylinService_Order",
                type: "nvarchar(50)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "KylinService_BusinessOptions",
                type: "nvarchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "KylinService_BusinessOptions",
                type: "nvarchar(20)",
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
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "KylinService_BusinessConfig",
                type: "nvarchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "KylinService_Business",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "KylinService_Business",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "WordAddress",
                table: "Job_Searcher",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "SearcherName",
                table: "Job_Searcher",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "JobName",
                table: "Job_Searcher",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Job_Searcher",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "WordAddress",
                table: "Job_Recruitment",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastRefreshTime",
                table: "Job_Recruitment",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "JobName",
                table: "Job_Recruitment",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Job_Recruitment",
                type: "nvarchar(max)",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Job_Recruitment",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "ContactMan",
                table: "Job_Recruitment",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Job_Category",
                type: "nvarchar(20)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Complaint",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Complaint",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Complaint",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ComplainantName",
                table: "Complaint",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Circle_Topic",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Circle_Topic",
                type: "nvarchar(50)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Circle_Topic",
                type: "nvarchar(max)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Circle_Respond",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ReplyUsername",
                table: "Circle_Respond",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Respond",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Circle_Respond",
                type: "nvarchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_PostTrend",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Circle_PostTrend",
                type: "nvarchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Circle_Post",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Circle_Post",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Post",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Circle_Post",
                type: "nvarchar(max)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Circle_Level",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Level",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                table: "Circle_Good",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Circle_Good",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Circle_Good",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Moderators",
                table: "Circle_Forum",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ForumName",
                table: "Circle_Forum",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Circle_Forum",
                type: "nvarchar(50)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Circle_EventUser",
                type: "nvarchar(20)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Circle_Event",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckTime",
                table: "Circle_CheckIn",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Circle_Category",
                type: "nvarchar(50)",
                nullable: true);
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
                name: "StartTime",
                table: "Area_OperatorRelation",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Area_OperatorRelation",
                type: "nvarchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                table: "Area_OperatorRelation",
                type: "nvarchar(20)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "LocationPlace",
                table: "Area_OperatorProfile",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                table: "Area_OperatorProfile",
                type: "nvarchar(20)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "AreaName",
                table: "Area_Open",
                type: "nvarchar(15)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Admin_Permission",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Admin_Account",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Realname",
                table: "Admin_Account",
                type: "nvarchar(20)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ad_Position",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Intro",
                table: "Ad_Position",
                type: "nvarchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "Ad_Position",
                type: "bit",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Ad_Position",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "PageName",
                table: "Ad_Page",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Ad_Content",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Ad_Content",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Html",
                table: "Ad_Content",
                type: "nvarchar(max)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Ad_Content",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "Ad_Content",
                type: "bit",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Ad_Content",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "Ad_Content",
                type: "nvarchar(255)",
                nullable: true);
            migrationBuilder.RenameTable(
                name: "Worker_TradeRecords",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_Profile",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_Message",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_CompanyBusiness",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_Company",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_Certification",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_Business",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Worker_Account",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Welfare_Remind",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Welfare_Phases",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Welfare_PartUser",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Welfare_Goods",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Welfare_DonatedGoods",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Welfare_Coupon",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Welfare",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_TradeRecords",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_ShakeRecord",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Resume",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Profiles",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Online",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Message",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_LocationTrack",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Forum",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Device",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Address",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "User_Account",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "System_SMS",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "System_ModuleAuthorize",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "System_Area",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Shake_UserRecord",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Shake_Content",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "MerchService_Goods",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "MerchGoods_Goods",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "MerchGoods_Category",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Welfare",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_TradeRecords",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_OrderSnapshot",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Order",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Message",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Industry",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Certificate",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Business",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Merchant_Account",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_ShoppingCart",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_PromotionProductRelevance",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_PromotionConfig",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_Promotion",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_ProductSKU",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_Product",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_OrderProductSnapshot",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_Order",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_EvaluateStatistics",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_Evaluate",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_CategoryTag",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Mall_Category",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "KylinService_Order",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "KylinService_BusinessOptions",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "KylinService_BusinessConfig",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "KylinService_Business",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Job_Searcher",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Job_Recruitment",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Job_Category",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Job_Apply",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Complaint",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Topic",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Respond",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_PostTrend",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Post",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Location",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Level",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Good",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Forum",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Follow",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_EventUser",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Event",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_CheckIn",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Category",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_AttachmentUsage",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Circle_Attachment",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Area_OperatorRelation",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Area_OperatorProfile",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Area_Operator",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Area_Open",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Admin_Permission",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Admin_Account",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Ad_Position",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Ad_Page",
                newSchema: "dbo");
            migrationBuilder.RenameTable(
                name: "Ad_Content",
                newSchema: "dbo");
        }
    }
}
