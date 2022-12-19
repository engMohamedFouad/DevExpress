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
    public partial class ViewSalesReturnDueDate
    {
        public int? InvoiceID { get; set; }
        public int? BranchID { get; set; }
        public int? FinancialID { get; set; }
        public int? PrCuID { get; set; }
        [StringLength(50)]
        public string DueDate { get; set; }
        [Column(TypeName = "money")]
        public decimal? TotalInv { get; set; }
        [Column(TypeName = "money")]
        public decimal? DiscountInv { get; set; }
        [Column(TypeName = "money")]
        public decimal? NetInv { get; set; }
        public bool? BookMark { get; set; }
        public int? FrmValue { get; set; }
        public int? PayType { get; set; }
        public bool? Done { get; set; }
        public int? ReturnInvoiceID { get; set; }
    }
}