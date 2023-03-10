// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("SettingSystem")]
    public partial class SettingSystem
    {
        [Key]
        public int ID { get; set; }
        public bool? PrintNameC { get; set; }
        public bool? WarningDue { get; set; }
        public bool? InvoiceReturn { get; set; }
        public int? WarningDays { get; set; }
        public int? afterDays { get; set; }
        public bool? CeateBackupExitP { get; set; }
        public bool? CreateBackupFDay { get; set; }
        [StringLength(200)]
        public string BackupPath { get; set; }
        public int? TypeCalendarNo { get; set; }
        public int? TybeLangeugeNo { get; set; }
        [StringLength(50)]
        public string CurrencyName { get; set; }
        [StringLength(50)]
        public string CurrencyPart { get; set; }
        [StringLength(50)]
        public string CurrencyCode { get; set; }
        [Column(TypeName = "ntext")]
        public string NamePrintInvoice { get; set; }
        [Column(TypeName = "ntext")]
        public string NamePrintVouchars { get; set; }
        public bool? ChSelectPrint { get; set; }
        public bool? BarcodeInvoice { get; set; }
        public bool? ShowIcons { get; set; }
        public bool? PostType { get; set; }
        public int? ShowSetup { get; set; }
        public bool? SerialInvoiceNo { get; set; }
        public bool? ExpressInvoicePrint { get; set; }
        public bool? ShowFormSalesman { get; set; }
        public int? TypeCardNo { get; set; }
        public int? StatsCardNo { get; set; }
        public double? DisPercent { get; set; }
        public double? MinAmount { get; set; }
        public double? DisPoint { get; set; }
        public bool? InvoiceReturnCh { get; set; }
        public int? WarningDaysCh { get; set; }
        [Column(TypeName = "ntext")]
        public string CashierUnder { get; set; }
        public int? SalesmanPrice { get; set; }
        public bool? ItemSerail { get; set; }
        public bool? ItemSerialGroup { get; set; }
        public bool? AddWarehouseAuto { get; set; }
        public bool? SendSMSCusto { get; set; }
        public bool? GaidOnly { get; set; }
        public bool? RepDescGaid { get; set; }
        [Column(TypeName = "ntext")]
        public string LetterPoint { get; set; }
        public int? TypeIn { get; set; }
        public bool? UpdatePirce { get; set; }
        public bool? TableInvoice { get; set; }
        public bool? PrintOptionDoc { get; set; }
        public int? PriceTransferQty { get; set; }
        public bool? ShowPaymentPos { get; set; }
        public bool? SelectDepPos { get; set; }
        public int? BookingDay { get; set; }
        [StringLength(20)]
        public string TimeOrder { get; set; }
        public int? ExpireDate { get; set; }
        [StringLength(20)]
        public string QtyDeci { get; set; }
        [StringLength(20)]
        public string PriceDeci { get; set; }
        public int? TaxType { get; set; }
        public double? TaxRatio { get; set; }
        public bool? ItemSerailGrSub { get; set; }
        public bool? CbPriceF { get; set; }
        public bool? CbPriceFS { get; set; }
        public bool? ChPriceTaxAdd { get; set; }
        public bool? ChBTrasPrice { get; set; }
        public bool? ChkCigaretTax { get; set; }
        public double? CigaretTaxValue { get; set; }
        public bool? ChSalesC { get; set; }
        public bool? ChPurC { get; set; }
        public bool? ChVoucherC { get; set; }
        public bool? ChSalesVAT { get; set; }
        public bool? ChPurVAT { get; set; }
        public bool? ChVoucherVAT { get; set; }
        public bool? ChSalesTTC { get; set; }
        public bool? ChPurTTC { get; set; }
        public bool? ChVoucherTTC { get; set; }
        public bool? ChTTC { get; set; }
        public double? TTCVAlue { get; set; }
        [StringLength(200)]
        public string DesignPath { get; set; }
        public bool? ChBBounsQ { get; set; }
        public bool? ChItemNote { get; set; }
        public bool? ChPOS { get; set; }
        public bool? ChPOSN { get; set; }
        public int? CmbInvPrice { get; set; }
        [StringLength(200)]
        public string PathPDF { get; set; }
        public bool? ChCostCenter { get; set; }
        public bool? E_Invoice { get; set; }
        public int? ChReturnAllPOS { get; set; }
        [StringLength(50)]
        public string E_InvStartDate { get; set; }
        [StringLength(200)]
        public string PathXML { get; set; }
        public bool? E_InvEnabled { get; set; }
        public int? Country { get; set; }
        public bool? PostPOS { get; set; }
        public int? StockType { get; set; }
        public int? InvType { get; set; }
        public int? GroupNo { get; set; }
        public int? ItemsNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }
        public int? InvoicesType { get; set; }
        public bool? UnderSaleAlert { get; set; }
        [StringLength(100)]
        public string PrintInvoicesPath { get; set; }
    }
}