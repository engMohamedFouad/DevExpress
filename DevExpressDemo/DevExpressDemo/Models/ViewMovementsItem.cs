﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Keyless]
    public partial class ViewMovementsItem
    {
        public int InvoiceCode { get; set; }
        public int? InvoiceID { get; set; }
        public int? BranchID { get; set; }
        public int? PrCuID { get; set; }
        public int? FinancialID { get; set; }
        public int? FrmValue { get; set; }
        public int? PayType { get; set; }
        public int? SalesManCode { get; set; }
        [StringLength(50)]
        public string ItemID { get; set; }
        [StringLength(100)]
        public string ItemName { get; set; }
        public int? MDCodeGroup { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string FromDate { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string ToDate { get; set; }
        [Column(TypeName = "numeric(2, 2)")]
        public decimal CASIN { get; set; }
        [Column(TypeName = "numeric(2, 2)")]
        public decimal CRSIN { get; set; }
        [Column(TypeName = "numeric(2, 2)")]
        public decimal CSRSIN { get; set; }
        [Column(TypeName = "numeric(2, 2)")]
        public decimal CRRSIN { get; set; }
        [Column(TypeName = "numeric(2, 2)")]
        public decimal NCACIN { get; set; }
        [Column(TypeName = "numeric(2, 2)")]
        public decimal NCRCIN { get; set; }
        [StringLength(50)]
        public string DateGr { get; set; }
        [Column(TypeName = "money")]
        public decimal? NetDetails { get; set; }
        public double? Quantity { get; set; }
        public double? QuantityBouns { get; set; }
        [StringLength(50)]
        public string TimeIN { get; set; }
        [StringLength(50)]
        public string ProductItem { get; set; }
        public int? UnitID { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        public double? QuantityFull { get; set; }
        [Column(TypeName = "money")]
        public decimal? TotalDetails { get; set; }
        public int? WarehouseID { get; set; }
        public double? TaxPerItem { get; set; }
        [Column(TypeName = "money")]
        public decimal? CiTax { get; set; }
    }
}