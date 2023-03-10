// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("TrialBal")]
    public partial class TrialBal
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string AccID { get; set; }
        public int? BranchID { get; set; }
        public int? FinancialID { get; set; }
        [Column(TypeName = "money")]
        public decimal? Debit { get; set; }
        [Column(TypeName = "money")]
        public decimal? Credit { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateGr { get; set; }
        public int? CostCenterID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("AccID")]
        [InverseProperty("TrialBals")]
        public virtual TreeAccount Acc { get; set; }
    }
}