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
    public partial class ViewChartOfAccountEmp
    {
        [Required]
        [StringLength(50)]
        public string AccID { get; set; }
        [StringLength(50)]
        public string AccName { get; set; }
        public int? MainFinalAccount { get; set; }
        [Column(TypeName = "money")]
        public decimal? MaxBalance { get; set; }
        [StringLength(50)]
        public string MainAccountNo { get; set; }
        [StringLength(50)]
        public string AccPeriod { get; set; }
        public int? MainOrSub { get; set; }
        public int? FinancialID { get; set; }
        public int? BranchID { get; set; }
        [StringLength(100)]
        public string BranchName { get; set; }
        public int? LevelAccount { get; set; }
        [Column(TypeName = "money")]
        public decimal StartCredit { get; set; }
        [Column(TypeName = "money")]
        public decimal StartDebit { get; set; }
        [Column(TypeName = "money")]
        public decimal BalanceDebit { get; set; }
        [Column(TypeName = "money")]
        public decimal BalanceCredit { get; set; }
        [Column(TypeName = "money")]
        public decimal? CurrentBalance { get; set; }
        [StringLength(100)]
        public string EmpName { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeCode { get; set; }
    }
}