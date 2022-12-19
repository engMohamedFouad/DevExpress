﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    public partial class AllVoucher
    {
        public int VID { get; set; }
        [Key]
        public int VoucherID { get; set; }
        public int VoucherCode { get; set; }
        public int? BranchID { get; set; }
        public int? UserID { get; set; }
        public int? FrmValueVoucher { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateGr { get; set; }
        [StringLength(50)]
        public string DateHi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateVoucher { get; set; }
        [StringLength(50)]
        public string FromAccID { get; set; }
        [Column(TypeName = "ntext")]
        public string VoucherDetails { get; set; }
        public bool? Done { get; set; }
        [Column(TypeName = "money")]
        public decimal? VoucherTotal { get; set; }
        [StringLength(20)]
        public string RefDocNo { get; set; }
        [StringLength(50)]
        public string RefDocDate { get; set; }
        public int? FinancialID { get; set; }
        public int? SalesManCode { get; set; }
        public int? PrintCopyNo { get; set; }
        [Column(TypeName = "money")]
        public decimal? TaxAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal? CigaretTax { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "money")]
        public decimal? VoucherNet { get; set; }
        public int? BankFundID { get; set; }

        [ForeignKey("FinancialID")]
        [InverseProperty("AllVouchers")]
        public virtual FinancialYear Financial { get; set; }
        [ForeignKey("FromAccID")]
        [InverseProperty("AllVouchers")]
        public virtual TreeAccount FromAcc { get; set; }
        [ForeignKey("SalesManCode")]
        [InverseProperty("AllVouchers")]
        public virtual SalesManInfo SalesManCodeNavigation { get; set; }
        [ForeignKey("UserID")]
        [InverseProperty("AllVouchers")]
        public virtual AspNetUser User { get; set; }
    }
}