// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Keyless]
    public partial class ViewSalesPriceItem
    {
        public int? InvoiceID { get; set; }
        public int? FinancialID { get; set; }
        public int? BranchID { get; set; }
        public double? Quantity { get; set; }
        public int? UnitID { get; set; }
        [StringLength(50)]
        public string ItemID { get; set; }
        public int? FrmValue { get; set; }
        [Column(TypeName = "money")]
        public decimal? TotalDetails { get; set; }
        [Column(TypeName = "money")]
        public decimal? NetDetails { get; set; }
        [Column(TypeName = "money")]
        public decimal? CostPrice { get; set; }
        public int? PrCuID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateGr { get; set; }
        [StringLength(100)]
        public string ItemName { get; set; }
        [StringLength(100)]
        public string Units { get; set; }
        [StringLength(100)]
        public string BranchName { get; set; }
        public int? GroupID { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [StringLength(100)]
        public string Groups { get; set; }
        [Column(TypeName = "money")]
        public decimal? DiscountDetails { get; set; }
        public int? PayType { get; set; }
        [StringLength(100)]
        public string PCName { get; set; }
        public int? SalesManCode { get; set; }
        public int? QutationID { get; set; }
        public int? MDCodeGroup1 { get; set; }
        public double? QuantityFull { get; set; }
        public double? QuantityBouns { get; set; }
        [StringLength(50)]
        public string TimeIN { get; set; }
        public double? TaxPerItem { get; set; }
        [Column(TypeName = "money")]
        public decimal? CiTax { get; set; }
        [Column(TypeName = "money")]
        public decimal? OtherDiscount { get; set; }
        [Column(TypeName = "money")]
        public decimal? PriceBeforeTax { get; set; }
    }
}