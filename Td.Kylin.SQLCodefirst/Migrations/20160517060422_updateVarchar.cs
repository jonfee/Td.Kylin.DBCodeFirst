using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class updateVarchar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "Worker_TradeRecords",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                table: "Worker_TradeRecords",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Worker_Profile",
                type: "nvarchar(100)",
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
            migrationBuilder.AlterColumn<string>(
                name: "RefDataID",
                table: "Worker_Message",
                type: "nvarchar(36)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Worker_Message",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PartCode",
                table: "Welfare_PartUser",
                type: "nvarchar(12)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                table: "User_Welfare",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "User_Welfare",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PartCode",
                table: "User_Welfare",
                type: "nvarchar(12)",
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
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "User_TradeRecords",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                table: "User_TradeRecords",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "WantWordArea",
                table: "User_Resume",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RealName",
                table: "User_Resume",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "User_Resume",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "JobName",
                table: "User_Resume",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ContactPhoto",
                table: "User_Resume",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RecommendCode",
                table: "User_RecommendRecord",
                type: "nvarchar(6)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User_Profiles",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Nation",
                table: "User_Profiles",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User_Profiles",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "JiGuan",
                table: "User_Profiles",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CardID",
                table: "User_Profiles",
                type: "nvarchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "User_PointsRecords",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "User_Online",
                type: "nvarchar(50)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "RefDataID",
                table: "User_Message",
                type: "nvarchar(36)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "User_Message",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "User_EmpiricalRecords",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Version",
                table: "User_Device",
                type: "nvarchar(15)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "DeviceName",
                table: "User_Device",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "User_Certification",
                type: "nvarchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User_Certification",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CertNo",
                table: "User_Certification",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                table: "User_Certification",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditAdminName",
                table: "User_Certification",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User_Address",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Linkman",
                table: "User_Address",
                type: "nvarchar(20)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "UserPic",
                table: "User_Account",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RecommendCode",
                table: "User_Account",
                type: "nvarchar(6)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User_Account",
                type: "nvarchar(32)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "User_Account",
                type: "nvarchar(11)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "System_SMS",
                type: "nvarchar(11)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "System_SMS",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "System_SMS",
                type: "nvarchar(6)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "System_Level",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "System_Level",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "System_GlobalResources",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "System_GlobalResources",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Group",
                table: "System_GlobalResources",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Points",
                table: "System_Area",
                type: "nvarchar(MAX)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "NameSpell",
                table: "System_Area",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Layer",
                table: "System_Area",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AreaName",
                table: "System_Area",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Shake_UserRecord",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Shake_Content",
                type: "nvarchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Shake_Content",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pic",
                table: "Shake_Content",
                type: "nvarchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Shake_Content",
                type: "nvarchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                table: "Shake_Content",
                type: "nvarchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ThirdTransactionCode",
                table: "Platform_MoneyTransaction",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Platform_MoneyTransaction",
                type: "nvarchar(150)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CustomName",
                table: "Platform_MoneyTransaction",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "MerchService_Goods",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MerchService_Goods",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AreaLayer",
                table: "MerchService_Goods",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                table: "MerchGoods_Goods",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pic",
                table: "MerchGoods_Goods",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MerchGoods_Goods",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MerchGoods_Goods",
                type: "nvarchar(140)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AreaLayer",
                table: "MerchGoods_Goods",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MerchGoods_Category",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MerchantGoods_SystemCategory",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "MerchantGoods_SystemCategory",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CategoryPath",
                table: "MerchantGoods_SystemCategory",
                type: "nvarchar(50)",
                nullable: true);
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
                name: "Picture",
                table: "Merchant_Welfare",
                type: "nvarchar(100)",
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
                name: "TradeNo",
                table: "Merchant_TradeRecords",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                table: "Merchant_TradeRecords",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RecommendCode",
                table: "Merchant_RecommendRecord",
                type: "nvarchar(6)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                table: "Merchant_OrderSnapshot",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pic",
                table: "Merchant_OrderSnapshot",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_OrderSnapshot",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Merchant_Order",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                table: "Merchant_Order",
                type: "nvarchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ExpressNumber",
                table: "Merchant_Order",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ExpressCompany",
                table: "Merchant_Order",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "DeliveryInfo",
                table: "Merchant_Order",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CancelRemark",
                table: "Merchant_Order",
                type: "nvarchar(100)",
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
            migrationBuilder.AlterColumn<string>(
                name: "RefDataID",
                table: "Merchant_Message",
                type: "nvarchar(36)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Layer",
                table: "Merchant_Industry",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Merchant_Industry",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Contents",
                table: "Merchant_Evaluate",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "BusinessEndTime",
                table: "Merchant_Config",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "BusinessBeginTime",
                table: "Merchant_Config",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Merchant_Certificate",
                type: "nvarchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_Certificate",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CertNo",
                table: "Merchant_Certificate",
                type: "nvarchar(20)",
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
                name: "RecommendCode",
                table: "Merchant_Account",
                type: "nvarchar(6)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Merchant_Account",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Merchant_Account",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Merchant_Account",
                type: "nvarchar(32)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_Account",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Merchant_Account",
                type: "nvarchar(11)",
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
            migrationBuilder.AlterColumn<string>(
                name: "AreaLayer",
                table: "Merchant_Account",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Mall_PromotionConfig",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pic",
                table: "Mall_Promotion",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mall_Promotion",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Specs",
                table: "Mall_ProductSKU",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "Mall_ProductSKU",
                type: "nvarchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Mall_ProductSKU",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "VenderName",
                table: "Mall_Product",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TagIDs",
                table: "Mall_Product",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "Mall_Product",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Mall_Product",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mall_Product",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "MainPic",
                table: "Mall_Product",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Mall_Product",
                type: "nvarchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "VenderName",
                table: "Mall_OrderProductSnapshot",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TagIDs",
                table: "Mall_OrderProductSnapshot",
                type: "nvarchar(500)",
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
                name: "Pics",
                table: "Mall_OrderProductSnapshot",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mall_OrderProductSnapshot",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "MainPic",
                table: "Mall_OrderProductSnapshot",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Mall_OrderProductSnapshot",
                type: "nvarchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Mall_Order",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ProductInfo",
                table: "Mall_Order",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                table: "Mall_Order",
                type: "nvarchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ExpressNumber",
                table: "Mall_Order",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ExpressCompany",
                table: "Mall_Order",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "DeliveryInfo",
                table: "Mall_Order",
                type: "nvarchar(200)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mall_Category",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Ico",
                table: "Mall_Category",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Mall_Category",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pictures",
                table: "Legwork_Order",
                type: "nvarchar(400)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                table: "Legwork_Order",
                type: "nvarchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Categories",
                table: "Legwork_Order",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OpenAreas",
                table: "Legwork_AreaConfig",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "WorkerRemark",
                table: "KylinService_Order",
                type: "nvarchar(200)",
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
            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                table: "KylinService_Order",
                type: "nvarchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "KylinService_Order",
                type: "nvarchar(20)",
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
            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "KylinService_Business",
                type: "nvarchar(100)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "WordAddress",
                table: "Job_Recruitment",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "JobName",
                table: "Job_Recruitment",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ContactPhoto",
                table: "Job_Recruitment",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ContactMan",
                table: "Job_Recruitment",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "Job_Recruitment",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Job_Category",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Complaint",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "DataID",
                table: "Complaint",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Complaint",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ComplainantPhone",
                table: "Complaint",
                type: "nvarchar(20)",
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
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Circle_Topic",
                type: "nvarchar(500)",
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
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Circle_Respond",
                type: "nvarchar(255)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Circle_Post",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Circle_Good",
                type: "nvarchar(13)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                table: "Circle_Good",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Circle_Good",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Circle_Forum",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ForumName",
                table: "Circle_Forum",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Circle_Forum",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Circle_EventUser",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Circle_Event",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Circle_Category",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Filename",
                table: "Circle_Attachment",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "FileType",
                table: "Circle_Attachment",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "Circle_Attachment",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Moderators",
                table: "Circle_AreaForum",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Circle_AreaForum",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Circle_AreaForum",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AliasName",
                table: "Circle_AreaForum",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "AreaOperator_TradeRecords",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                table: "AreaOperator_TradeRecords",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Area_OperatorRelation",
                type: "nvarchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CompactNumber",
                table: "Area_OperatorRelation",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Area_OperatorProfile",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Area_OperatorProfile",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNo",
                table: "Area_OperatorProfile",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Area_OperatorProfile",
                type: "nvarchar(11)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "LegalName",
                table: "Area_OperatorProfile",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LegalIDCard",
                table: "Area_OperatorProfile",
                type: "nvarchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Area_OperatorProfile",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Area_OperatorProfile",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Area_OperatorProfile",
                type: "nvarchar(16)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LoginPassword",
                table: "Area_Operator",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LoginAccount",
                table: "Area_Operator",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AreaName",
                table: "Area_Open",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Agent_Profile",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkPhone",
                table: "Agent_Profile",
                type: "nvarchar(11)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                table: "Agent_Profile",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "IDCardPhotoFront",
                table: "Agent_Profile",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "IDCardPhotoBack",
                table: "Agent_Profile",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "IDCardNo",
                table: "Agent_Profile",
                type: "nvarchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "BusinessLicensePhoto",
                table: "Agent_Profile",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Agent_AreaRelation",
                type: "nvarchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PaymentPassword",
                table: "Agent_Account",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Agent_Account",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Agent_Account",
                type: "nvarchar(11)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LoginPassword",
                table: "Agent_Account",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LoginAccount",
                table: "Agent_Account",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Admin_Account",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserPic",
                table: "Admin_Account",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Realname",
                table: "Admin_Account",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Admin_Account",
                type: "nvarchar(32)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LastIp",
                table: "Admin_Account",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PreviewPicture",
                table: "Ad_Position",
                type: "nvarchar(100)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Ad_Position",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Ad_PlatformContent",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ADFile",
                table: "Ad_PlatformContent",
                type: "nvarchar(200)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "ADFile",
                table: "Ad_Content",
                type: "nvarchar(200)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "Worker_TradeRecords",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                table: "Worker_TradeRecords",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Worker_Profile",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Worker_Message",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Sign",
                table: "Worker_Message",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RefDataID",
                table: "Worker_Message",
                type: "varchar(36)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Worker_Message",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PartCode",
                table: "Welfare_PartUser",
                type: "varchar(12)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                table: "User_Welfare",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "User_Welfare",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PartCode",
                table: "User_Welfare",
                type: "varchar(12)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User_Welfare",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "MerchantName",
                table: "User_Welfare",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "User_TradeRecords",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                table: "User_TradeRecords",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "WantWordArea",
                table: "User_Resume",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RealName",
                table: "User_Resume",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "User_Resume",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "JobName",
                table: "User_Resume",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ContactPhoto",
                table: "User_Resume",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RecommendCode",
                table: "User_RecommendRecord",
                type: "varchar(6)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "User_Profiles",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PresentAddress",
                table: "User_Profiles",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User_Profiles",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Nation",
                table: "User_Profiles",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User_Profiles",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "JiGuan",
                table: "User_Profiles",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CardID",
                table: "User_Profiles",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "User_PointsRecords",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "User_Online",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "User_Message",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Sign",
                table: "User_Message",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RefDataID",
                table: "User_Message",
                type: "varchar(36)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "User_Message",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "User_EmpiricalRecords",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Version",
                table: "User_Device",
                type: "varchar(15)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "DeviceName",
                table: "User_Device",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "User_Certification",
                type: "varchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User_Certification",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CertNo",
                table: "User_Certification",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                table: "User_Certification",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditAdminName",
                table: "User_Certification",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User_Address",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Linkman",
                table: "User_Address",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Community",
                table: "User_Address",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "User_Address",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User_Account",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserPic",
                table: "User_Account",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RecommendCode",
                table: "User_Account",
                type: "varchar(6)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User_Account",
                type: "varchar(32)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "User_Account",
                type: "varchar(11)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "System_SMS",
                type: "varchar(11)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "System_SMS",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "System_SMS",
                type: "varchar(6)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "System_Level",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "System_Level",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "System_GlobalResources",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "System_GlobalResources",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Group",
                table: "System_GlobalResources",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Points",
                table: "System_Area",
                type: "varchar(MAX)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "NameSpell",
                table: "System_Area",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Layer",
                table: "System_Area",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AreaName",
                table: "System_Area",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Shake_UserRecord",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Shake_Content",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Shake_Content",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pic",
                table: "Shake_Content",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Shake_Content",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                table: "Shake_Content",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ThirdTransactionCode",
                table: "Platform_MoneyTransaction",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Platform_MoneyTransaction",
                type: "varchar(150)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CustomName",
                table: "Platform_MoneyTransaction",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "MerchService_Goods",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MerchService_Goods",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AreaLayer",
                table: "MerchService_Goods",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                table: "MerchGoods_Goods",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pic",
                table: "MerchGoods_Goods",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MerchGoods_Goods",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MerchGoods_Goods",
                type: "varchar(140)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AreaLayer",
                table: "MerchGoods_Goods",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MerchGoods_Category",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MerchantGoods_SystemCategory",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "MerchantGoods_SystemCategory",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CategoryPath",
                table: "MerchantGoods_SystemCategory",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                table: "Merchant_Welfare",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Regular",
                table: "Merchant_Welfare",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Merchant_Welfare",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_Welfare",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "MerchantName",
                table: "Merchant_Welfare",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Intro",
                table: "Merchant_Welfare",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                table: "Merchant_Welfare",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditAdminName",
                table: "Merchant_Welfare",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "Merchant_TradeRecords",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                table: "Merchant_TradeRecords",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RecommendCode",
                table: "Merchant_RecommendRecord",
                type: "varchar(6)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                table: "Merchant_OrderSnapshot",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pic",
                table: "Merchant_OrderSnapshot",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_OrderSnapshot",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Merchant_Order",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                table: "Merchant_Order",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ExpressNumber",
                table: "Merchant_Order",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ExpressCompany",
                table: "Merchant_Order",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "DeliveryInfo",
                table: "Merchant_Order",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CancelRemark",
                table: "Merchant_Order",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Merchant_Message",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Sign",
                table: "Merchant_Message",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RefDataID",
                table: "Merchant_Message",
                type: "varchar(36)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Merchant_Message",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_Industry",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Layer",
                table: "Merchant_Industry",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Merchant_Industry",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Contents",
                table: "Merchant_Evaluate",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "BusinessEndTime",
                table: "Merchant_Config",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "BusinessBeginTime",
                table: "Merchant_Config",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Merchant_Certificate",
                type: "varchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_Certificate",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CertNo",
                table: "Merchant_Certificate",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                table: "Merchant_Certificate",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditAdminName",
                table: "Merchant_Certificate",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AudtiAdminName",
                table: "Merchant_Business",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                table: "Merchant_Business",
                type: "varchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Merchant_Account",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RecommendCode",
                table: "Merchant_Account",
                type: "varchar(6)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Merchant_Account",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Merchant_Account",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Merchant_Account",
                type: "varchar(32)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Merchant_Account",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Merchant_Account",
                type: "varchar(11)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LocationPlace",
                table: "Merchant_Account",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                table: "Merchant_Account",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Merchant_Account",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AreaLayer",
                table: "Merchant_Account",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Mall_PromotionConfig",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pic",
                table: "Mall_Promotion",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mall_Promotion",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Specs",
                table: "Mall_ProductSKU",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "Mall_ProductSKU",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Mall_ProductSKU",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "VenderName",
                table: "Mall_Product",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TagIDs",
                table: "Mall_Product",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "Mall_Product",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Mall_Product",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mall_Product",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "MainPic",
                table: "Mall_Product",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Mall_Product",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "VenderName",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TagIDs",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Specs",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PromotionTags",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "MainPic",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Mall_OrderProductSnapshot",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Mall_Order",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ProductInfo",
                table: "Mall_Order",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                table: "Mall_Order",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ExpressNumber",
                table: "Mall_Order",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ExpressCompany",
                table: "Mall_Order",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "DeliveryInfo",
                table: "Mall_Order",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Contents",
                table: "Mall_Evaluate",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TagName",
                table: "Mall_CategoryTag",
                type: "varchar(8)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mall_Category",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Ico",
                table: "Mall_Category",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Mall_Category",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pictures",
                table: "Legwork_Order",
                type: "varchar(400)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                table: "Legwork_Order",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Categories",
                table: "Legwork_Order",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OpenAreas",
                table: "Legwork_AreaConfig",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "WorkerRemark",
                table: "KylinService_Order",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserRemark",
                table: "KylinService_Order",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "KylinService_Order",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ServiceContent",
                table: "KylinService_Order",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ServiceAddress",
                table: "KylinService_Order",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                table: "KylinService_Order",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "KylinService_Order",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "KylinService_BusinessOptions",
                type: "varchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "KylinService_BusinessOptions",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "KylinService_BusinessConfig",
                type: "varchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "KylinService_Business",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "KylinService_Business",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "WordAddress",
                table: "Job_Searcher",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "SearcherName",
                table: "Job_Searcher",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "JobName",
                table: "Job_Searcher",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "WordAddress",
                table: "Job_Recruitment",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "JobName",
                table: "Job_Recruitment",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ContactPhoto",
                table: "Job_Recruitment",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ContactMan",
                table: "Job_Recruitment",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "Job_Recruitment",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Job_Category",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Complaint",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "DataID",
                table: "Complaint",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Complaint",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ComplainantPhone",
                table: "Complaint",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ComplainantName",
                table: "Complaint",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Circle_Topic",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Circle_Topic",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Circle_Topic",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Circle_Respond",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ReplyUsername",
                table: "Circle_Respond",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Circle_Respond",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Circle_PostTrend",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Circle_Post",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Circle_Post",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Circle_Post",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Circle_Good",
                type: "varchar(13)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                table: "Circle_Good",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Circle_Good",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Circle_Forum",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ForumName",
                table: "Circle_Forum",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Circle_Forum",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Circle_EventUser",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Circle_Event",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Circle_Category",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Filename",
                table: "Circle_Attachment",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "FileType",
                table: "Circle_Attachment",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "Circle_Attachment",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Moderators",
                table: "Circle_AreaForum",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Circle_AreaForum",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Circle_AreaForum",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AliasName",
                table: "Circle_AreaForum",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "AreaOperator_TradeRecords",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                table: "AreaOperator_TradeRecords",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Area_OperatorRelation",
                type: "varchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CompactNumber",
                table: "Area_OperatorRelation",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Area_OperatorProfile",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Area_OperatorProfile",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNo",
                table: "Area_OperatorProfile",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Area_OperatorProfile",
                type: "varchar(11)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LocationPlace",
                table: "Area_OperatorProfile",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                table: "Area_OperatorProfile",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LegalName",
                table: "Area_OperatorProfile",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LegalIDCard",
                table: "Area_OperatorProfile",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Area_OperatorProfile",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Area_OperatorProfile",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Area_OperatorProfile",
                type: "varchar(16)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LoginPassword",
                table: "Area_Operator",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LoginAccount",
                table: "Area_Operator",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AreaName",
                table: "Area_Open",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Agent_Profile",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkPhone",
                table: "Agent_Profile",
                type: "varchar(11)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LinkMan",
                table: "Agent_Profile",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "IDCardPhotoFront",
                table: "Agent_Profile",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "IDCardPhotoBack",
                table: "Agent_Profile",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "IDCardNo",
                table: "Agent_Profile",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "BusinessLicensePhoto",
                table: "Agent_Profile",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Agent_AreaRelation",
                type: "varchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PaymentPassword",
                table: "Agent_Account",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Agent_Account",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Agent_Account",
                type: "varchar(11)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LoginPassword",
                table: "Agent_Account",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LoginAccount",
                table: "Agent_Account",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Admin_Account",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserPic",
                table: "Admin_Account",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Realname",
                table: "Admin_Account",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Admin_Account",
                type: "varchar(32)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LastIp",
                table: "Admin_Account",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PreviewPicture",
                table: "Ad_Position",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ad_Position",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Intro",
                table: "Ad_Position",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Ad_Position",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Ad_PlatformContent",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ADFile",
                table: "Ad_PlatformContent",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "PageName",
                table: "Ad_Page",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Ad_Content",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ADFile",
                table: "Ad_Content",
                type: "varchar(200)",
                nullable: true);
        }
    }
}
