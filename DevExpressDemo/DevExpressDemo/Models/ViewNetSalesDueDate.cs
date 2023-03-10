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
    public partial class ViewNetSalesDueDate
    {
        public int? InvoiceID { get; set; }
        public int? BranchID { get; set; }
        public int? FinancialID { get; set; }
        public int? PrCuID { get; set; }
        public bool? BookMark { get; set; }
        [Column(TypeName = "money")]
        public decimal NetS { get; set; }
        [Column(TypeName = "money")]
        public decimal NetR { get; set; }
        [Column(TypeName = "money")]
        public decimal? Net { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        public bool? DoneS { get; set; }
        public bool? DoneR { get; set; }
        [StringLength(100)]
        public string PCName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateGr { get; set; }
        public int? FrmValue { get; set; }
        public int? PayType { get; set; }
        public int? SalesManCode { get; set; }
        public int MoveCode { get; set; }
        [Column(TypeName = "ntext")]
        public string Note { get; set; }
    }
}