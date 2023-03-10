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
    public partial class ViewSalesInvoice
    {
        public int? InvoiceID { get; set; }
        public int? BranchID { get; set; }
        public int? FinancialID { get; set; }
        public int? PrCuID { get; set; }
        public int? FrmValue { get; set; }
        [StringLength(50)]
        public string ItemID { get; set; }
        public int? UnitID { get; set; }
        public double? QuantityFull { get; set; }
        [Column(TypeName = "money")]
        public decimal? NetDetails { get; set; }
        [Column(TypeName = "money")]
        public decimal? CostPrice { get; set; }
        public double? Quantity { get; set; }
        [StringLength(50)]
        public string DateGr { get; set; }
        public int? SalesManCode { get; set; }
        public int? PayType { get; set; }
        [StringLength(100)]
        public string CustomerName { get; set; }
        public int? UserID { get; set; }
        public int? CashierID { get; set; }
        [Column(TypeName = "money")]
        public decimal? OtherPrice { get; set; }
    }
}