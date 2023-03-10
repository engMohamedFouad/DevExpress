// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("AccountBalance")]
    public partial class AccountBalance
    {
        public int ID { get; set; }
        [Key]
        [StringLength(50)]
        public string AccID { get; set; }
        [Key]
        public int FinancialID { get; set; }
        [Key]
        public int BranchID { get; set; }
        [Column(TypeName = "money")]
        public decimal? StartDebit { get; set; }
        [Column(TypeName = "money")]
        public decimal? StartCredit { get; set; }
        [Column(TypeName = "money")]
        public decimal? BalanceDebit { get; set; }
        [Column(TypeName = "money")]
        public decimal? BalanceCredit { get; set; }
        [StringLength(50)]
        public string MainAccountNo { get; set; }
        [Column(TypeName = "money")]
        public decimal? VirualBalance { get; set; }
        [Column(TypeName = "ntext")]
        public string NoteAccStat { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateGr { get; set; }
        public int? PCId { get; set; }

        [ForeignKey("AccID")]
        [InverseProperty("AccountBalances")]
        public virtual TreeAccount Acc { get; set; }
        [ForeignKey("BranchID")]
        [InverseProperty("AccountBalances")]
        public virtual BranchsAndWarehouse Branch { get; set; }
        [ForeignKey("FinancialID")]
        [InverseProperty("AccountBalances")]
        public virtual FinancialYear Financial { get; set; }
    }
}